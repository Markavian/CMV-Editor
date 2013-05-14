using System;
using System.Collections.Generic;
using System.Text;

namespace CMVData
{
    [Serializable]
    public class CMVFrame
    {
        uint cols, rows;
        byte[] frame;

        public CMVFrame()
        {
            frame = new byte[0];
            cols = 0;
            rows = 0;
        }

        public CMVFrame(uint cols, uint rows)
        {
            this.rows = rows;
            this.cols = cols;
            frame = CreateBlankFrame(cols, rows);
        }

        public CMVFrame(byte[] sourceFrame, uint sourceCols, uint sourceRows)
        {
            frame = CloneFrame(sourceFrame);
            cols = sourceCols;
            rows = sourceRows;

            ValidateSize();
        }

        public void SetCell(uint col, uint row, byte tileIndex, byte color)
        {
            if (col > cols || row > rows)
                return;

            uint cellIndex = (col * rows) + row;
            SetCell(cellIndex, tileIndex, color);
        }

        public void SetCell(uint cellIndex, byte tileIndex, byte color)
        {
            int frameSize = frame.Length >> 1;

            frame[cellIndex] = tileIndex;
            frame[frameSize + cellIndex] = color;
        }

        public static byte[] CloneFrame(byte[] sourceFrame)
        {
            byte[] frame;
            int frameSize;

            frameSize = sourceFrame.Length;
            frame = new byte[frameSize];
            sourceFrame.CopyTo(frame, 0);

            return frame;
        }

        public static CMVFrame CloneFrame(CMVFrame sourceFrame)
        {
            CMVFrame frame;

            frame = new CMVFrame(sourceFrame.frame, sourceFrame.cols, sourceFrame.rows);

            return frame;
        }

        public void ValidateSize()
        {
            int frameSize;
            
            // Start with invalid frameSize
            frameSize = -1;

            if (cols > 0 && rows > 0)
            {
                
            }
            else if(cols > 0)
            {
                // Calculate projected rows
                if (frame.Length % cols == 0)
                {
                    rows = (uint)frame.Length / cols;
                }
            }
            else if (rows > 0)
            {
                // Calculate projected cols
                if (frame.Length % rows == 0)
                {
                    cols = (uint)frame.Length / rows;
                }
            }
            // Calculate projected framesize
            frameSize = (int)(cols * rows) << 1;

            if (frame.Length != frameSize)
            {
                throw new FrameSizeException("Invalid frame size", frame.Length, (int)cols, (int)rows);
            }
        }

        public static byte[] CreateBlankFrame(uint cols, uint rows)
        {
            byte[] frame;
            int frameSize;

            frameSize = (int)(cols * rows);

            frame = new byte[frameSize << 1];

            for (int i = 0; i < frameSize; i++)
            {
                // Set tile index
                frame[i] = 0;
            }

            for (int i = 0; i < frameSize; i++)
            {
                // Set colour code
                frame[frameSize + i] = 0;
            }

            return frame;
        }

        /* Properties */
        public byte[] Frame
        {
            get { return frame; }
            set { frame = value; ValidateSize(); }
        }

        public uint Columns {
            get { return cols; }
            set { cols = value; }
        }

        public uint Rows {
            get { return rows; }
            set { rows = value; }
        }
    }

    public class FrameSizeException : Exception
    {
        int frameSize, cols, rows;

        public FrameSizeException() : base() { }
        public FrameSizeException(string message) : base(message) { }
        public FrameSizeException(string message, int _frameSize, int _cols, int _rows)
            : base(message)
        {
            frameSize = _frameSize;
            cols = _cols;
            rows = _rows;
        }

        public int FrameSize
        {
            get { return frameSize; }
            set { frameSize = value; }
        }

        public int Rows
        {
            get { return rows; }
            set { rows = value; }
        }

        public int Columns
        {
            get { return cols; }
            set { cols = value; }
        }
    }
}
