using System;
using System.Collections.Generic;
using System.Text;

using System.IO;
using ICSharpCode.SharpZipLib;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace CMVData
{
    enum ExtensionType { Unknown, CMV, CCMV }
    
    public class CMV
    {
        const int NUM_SOUNDCHANNELS = 64;
        const int FRAMES_PER_CHUNK = 200;

        string file;
        List<CMVFrame> frames;
        
        uint version;
        uint cols;
        uint rows;
        uint delayRate;
        int numSounds;
        byte[] soundNames;
        byte[] soundTimings;

        public event EventHandler StructureChanged;

        public CMV()
        {
            init();
        }

        public CMV(string filename)
        {
            init();
            Read(filename);
        }

        public CMV(uint cols, uint rows)
        {
            init();

            CMVFrame firstFrame = new CMVFrame(cols, rows);
            frames.Add(firstFrame);
            version = 10005;
        }

        private void init()
        {
            file = "";
            frames = new List<CMVFrame>();

            delayRate = 400;
            numSounds = 0;
        }

        /// <summary>
        /// Reads the contents of the target file into this data structure.
        /// </summary>
        /// <param name="filename">The target path to read from.</param>
        /// <see cref="CMVException"/>
        public void Read(string filename)
        {
            file = filename;

            frames = new List<CMVFrame>();
            try
            {
                readCMV(file);
            }
            catch(Exception e)
            {
                throw new CMVException("Invalid file: " + e.Message);
            }

            if (StructureChanged != null)
                StructureChanged(this, new EventArgs());
        }

        /// <summary>
        /// Save the state of this CMV data structure to a binary file.
        /// </summary>
        /// <param name="filename">The target path to save to, will overwrite the file if it exists.</param>
        public void Save(string filename)
        {
            writeCMV(filename);
        }

        /* Private methods */
        private void readCMV(string inFilename)
        {
            byte[] source, decompressed;
            ExtensionType extension;
            InflaterInputStream zipInStream;
            Stream stream;
            FileStream fileStream;
            MemoryStream memoryStream;

            extension = checkExtension(inFilename);

            if (extension == ExtensionType.CCMV)
            {
                source = File.ReadAllBytes(inFilename);
                decompressed = new byte[0];

                memoryStream = new MemoryStream(source);
                zipInStream = new InflaterInputStream(memoryStream);
                zipInStream.Read(decompressed, 0, decompressed.Length);
                stream = new MemoryStream(decompressed);
            }
            else
            {
                fileStream = File.OpenRead(inFilename);
                stream = fileStream;
            }

            byte[] intBytes = new byte[4];

            stream.Read(intBytes, 0, 4);
            version = BitConverter.ToUInt32(intBytes, 0);

            stream.Read(intBytes, 0, 4);
            cols = BitConverter.ToUInt32(intBytes, 0);

            stream.Read(intBytes, 0, 4);
            rows = BitConverter.ToUInt32(intBytes, 0);

            stream.Read(intBytes, 0, 4);
            delayRate = BitConverter.ToUInt32(intBytes, 0);

            // Sounds
            if (version == 10001)
            {
                stream.Read(intBytes, 0, 4);
                numSounds = BitConverter.ToInt32(intBytes, 0);

                soundNames = new byte[50 * numSounds];
                stream.Read(soundNames, 0, 50 * numSounds);

                soundTimings = new byte[200 * NUM_SOUNDCHANNELS]; // 0x3200
                stream.Read(soundTimings, 0, 200 * NUM_SOUNDCHANNELS);
            }

            int frameSize = (int)(cols * rows);
            frameSize += frameSize;

            byte[] previousFrame = new byte[frameSize];
            for (int frameByte = 0; frameByte < frameSize; frameByte++)
            {
                previousFrame[frameByte] = 0;
            }

            byte[] curFrame = new byte[frameSize];
            int framesDone = 0;
            int frameSizeLeft = frameSize;
            int frameSizeDone = 0;

            while (stream.Position < stream.Length)
            {
                if (stream.Read(intBytes, 0, 4) == 4)
                {
                    int compressedChunkSize = BitConverter.ToInt32(intBytes, 0);
                    byte[] buffer = new byte[compressedChunkSize];
                    stream.Read(buffer, 0, compressedChunkSize);

                    memoryStream = new MemoryStream(buffer);
                    zipInStream = new InflaterInputStream(memoryStream);

                    int bytesRead = 0;
                    do
                    {
                        bytesRead = zipInStream.Read(curFrame, frameSizeDone, frameSizeLeft);

                        if (bytesRead == frameSizeLeft)
                        {
                            /* 
                             * Valid variables at this point: 
                             * frameSize
                             * byte[frameSize] previousFrame
                             * byte[frameSize] curFrame
                             */

                            framesDone++;

                            frames.Add(new CMVFrame(curFrame, cols, rows));
                            Array.Copy(curFrame, previousFrame, frameSize);

                            frameSizeLeft = frameSize;
                            frameSizeDone = 0;
                        }
                        else
                        {
                            frameSizeDone += bytesRead;
                            frameSizeLeft -= bytesRead;
                        }
                    } while (bytesRead == frameSize);
                }
                else
                {
                    break;
                }
            }

            stream.Close();
            stream.Dispose();
        }

        private void writeCMV(string outFilename)
        {
            byte[] target, compressed;
            ExtensionType extension;
            DeflaterOutputStream zipOutStream;
            MemoryStream stream;
            MemoryStream memoryStream;

            cols = Columns;
            rows = Rows;

            if (frames.Count == 0)
            {
                throw new CMVException("There are no frames to save.");
            }

            if (cols == 0 || rows == 0)
            {
                throw new CMVException(String.Format("Invalid columns ({0}), rows ({1}) combination", cols, rows));
            }

            extension = checkExtension(outFilename);

            stream = new MemoryStream();

            byte[] intBytes = new byte[4];

            intBytes = BitConverter.GetBytes((Int32)version);
            stream.Write(intBytes, 0, 4);

            intBytes = BitConverter.GetBytes((Int32)cols);
            stream.Write(intBytes, 0, 4);

            intBytes = BitConverter.GetBytes((Int32)rows);
            stream.Write(intBytes, 0, 4);

            intBytes = BitConverter.GetBytes((Int32)delayRate);
            stream.Write(intBytes, 0, 4);

            // Sounds
            if (version == 10001)
            {
                intBytes = BitConverter.GetBytes((Int32)numSounds);
                stream.Write(intBytes, 0, 4);

                stream.Write(soundNames, 0, soundNames.Length);

                stream.Write(soundTimings, 0, soundTimings.Length);
            }

            //int frameSize = (int)(cols * rows);
            //frameSize += frameSize;

            byte[] chunk;
            int i = 0;
            int framesInChunk;
            int compressedChunkSize;
            byte[] frame;
            while(i < frames.Count)
            {
                if ((frames.Count - i) > FRAMES_PER_CHUNK)
                {
                    framesInChunk = FRAMES_PER_CHUNK;
                }
                else
                {
                    framesInChunk = (Int32)(frames.Count - i);
                }

                memoryStream = new MemoryStream();
                zipOutStream = new DeflaterOutputStream(memoryStream, new Deflater(Deflater.BEST_COMPRESSION));

                for (int j = 0; j < framesInChunk; j++)
                {
                    frame = frames[i + j].Frame;
                    zipOutStream.Write(frame, 0, frame.Length);
                }

                zipOutStream.Finish();

                compressedChunkSize = (Int32)memoryStream.Length;

                intBytes = BitConverter.GetBytes((Int32)compressedChunkSize);
                stream.Write(intBytes, 0, 4);

                chunk = memoryStream.ToArray();
                stream.Write(chunk, 0, chunk.Length);

                i = i + framesInChunk;

                zipOutStream.Close();
            }

            target = stream.ToArray();
            stream.Close();

            if (extension == ExtensionType.CCMV)
            {
                compressed = new byte[0];

                memoryStream = new MemoryStream(target);
                zipOutStream = new DeflaterOutputStream(memoryStream);
                zipOutStream.Write(target, 0, target.Length);

                compressed = new byte[memoryStream.Length];
                memoryStream.Position = 0;
                memoryStream.Read(compressed, 0, (Int32)memoryStream.Length);
                File.WriteAllBytes(outFilename, compressed);
            }
            else
            {
                File.WriteAllBytes(outFilename, target);
            }

            stream.Close();
            stream.Dispose();
        }

        private ExtensionType checkExtension(string filename)
        {
            if (filename.EndsWith(".cmv"))
            {
                // that's good
                return ExtensionType.CMV;
            }
            else if (filename.EndsWith(".ccmv"))
            {
                // that's possibly good
                return ExtensionType.CCMV;
            }
            else
            {
                throw new CMVException("The supplied file type extension is not supported.");
            }
        }

        /* Public properties */
        public CMVFrame this[int index]
        {
            get { return frames[index]; }
            set {
                frames[index] = value;
                if (StructureChanged != null)
                    StructureChanged(this, new EventArgs());
            }
        }

        public List<CMVFrame> Frames
        {
            get { return frames; }
            set {
                frames = value;
                if (StructureChanged != null)
                    StructureChanged(this, new EventArgs());
            }
        }

        public string FilePath
        {
            get { return file; }
        }

        public string Filename
        {
            get {
                string[] raw = file.Split('\\');
                return raw[raw.Length - 1];
            }
        }

        public uint FrameCount
        {
            get { return (frames != null) ? (uint)frames.Count : 0; }
        }

        /// <summary>
        /// Returns the version number written into the CMV.
        /// </summary>
        public uint Version
        {
            get { return version; }
            set { version = value; }
        }

        /// <summary>
        /// Returns the number of columns in the first frame.
        /// </summary>
        public uint Columns
        {
            get { return (frames != null && frames.Count > 0 ) ? frames[0].Columns : 0; }
        }
        /// <summary>
        /// Returns the number of rows in the first frame.
        /// </summary>
        public uint Rows
        {
            get { return (frames != null && frames.Count > 0) ? frames[0].Rows : 0; }
        }

        /// <summary>
        /// Returns the number of sound channel associated with the CMV.
        /// </summary>
        public int Sounds
        {
            get { return numSounds; }
        }

        /* Protected events */
        protected virtual void OnStructureChanged(object sender, EventArgs e)
        {
            StructureChanged(sender, e);
        }
    }
}
