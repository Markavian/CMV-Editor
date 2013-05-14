using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using CMVData;
using CMVEditorComponents;

namespace CMVEditor
{
    public partial class MainForm : Form
    {
        CMV cmv;
        TileSet tileset;

        List<CMVFrame> rawframes;
        ImmutableList<CMVFrame> cmvframes;
        List<CMVFrame> copybuffer;
        CMVFrame clonedFrame;

        AboutBox aboutBox;
        ChooseDimensionsBox newFileDialog;
        Timer updateDelayTimer;

        public MainForm()
        {
            InitializeComponent();

            cmv = new CMV();
            rawframes = new List<CMVFrame>();
            cmvframes = new ImmutableList<CMVFrame>(rawframes, "empty");
            copybuffer = new List<CMVFrame>();

            foregroundColourPicker.Colors = CMVColours.ForegroundColors;
            backgroundColourPicker.Colors = CMVColours.BackgroundColors;

            updateDelayTimer = new Timer();
                updateDelayTimer.Interval = 24;
                updateDelayTimer.Tick += handleUpdateDelayTimer;

            aboutBox = new AboutBox();
            aboutBox.HelpButtonClicked += new EventHandler(action_HelpTopics);

            newFileDialog = new ChooseDimensionsBox();

            loadTileset();

            RefreshControls();
        }

        /* Public methods */
        public void RefreshTimelineControl()
        {
            timelineControl.FrameCount = (int)cmvPlayer.CMV.FrameCount;
            timelineControl.PlayHeadPosition = cmvPlayer.Frame;
            playerControls.FrameNumberText = cmvPlayer.Frame + "\r of " + cmvPlayer.CMV.FrameCount;
        }

        public void RefreshToolControls()
        {
            ToolMode mode = cmvPlayer.ToolMode;

            toolButtonNone.Checked = (mode == ToolMode.NONE);
            toolButtonPaint.Checked = (mode == ToolMode.PAINT_TOOL);
            toolButtonSelection.Checked = (mode == ToolMode.SELECTION_TOOL);
            toolButtonText.Checked = (mode == ToolMode.TEXT_TOOL);
        }

        public void RefreshControls()
        {
            RefreshTimelineControl();
            RefreshToolControls();

            CMVEditorComponents.TimelineControls controls = timelineControls;

            controls.PasteEnabled = (copybuffer.Count > 0) ? true : false;
            controls.UndoEnabled = (cmvframes.PreviousState != cmvframes) ? true : false;

            timelineControl_FrameSelected(this, timelineControl.PlayHeadPosition);
        }

        public void UpdateCMV()
        {
            cmv.Frames = cmvframes.List;
            cmvPlayer.ForceRedraw();
        }

        /* Private methods */
        private void loadTileset()
        {
            tileset = new TileSet(Application.StartupPath + "/curses_800x600.png");
            tileSelector.TileSet = tileset;

            tileSelector.ForegroundColor = CMVColours.LBLUE;
            tileSelector.BackgroundColor = CMVColours.BLACK;

            tileSelector.SelectedTile = 16;
        }

        /* Actions */
        private void action_NewFile(object sender, EventArgs e)
        {
            int width, height;

            newFileDialog.ShowDialog(this);
            width = newFileDialog.FormWidth;
            height = newFileDialog.FormHeight;

            cmv = new CMV((uint)width, (uint)height);

            registerCMVWithForm(cmv);
        }

        private void action_OpenCMV(object sender, EventArgs e)
        {
            string filename;
            DialogResult result;

            result = openCMVFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = openCMVFileDialog.FileName;
                openFileName(filename);
            }
        }

        private void openFileName(string filename)
        {
            cmv = new CMV(filename);

            registerCMVWithForm(cmv);
        }

        private void registerCMVWithForm(CMV cmv)
        {
            this.cmv = cmv;

            rawframes = cmv.Frames;
            cmvframes = new ImmutableList<CMVFrame>(rawframes, cmv.Filename);

            cmvInfoControl.CMV = cmv;
            cmvPlayer.TileSet = tileset;
            cmvPlayer.CMV = cmv;
        }

        private void action_SaveCMV(object sender, EventArgs e)
        {
            if (cmv.Filename.Length > 0)
            {
                cmv.Save(cmv.Filename);
            }
            else
            {
                action_SaveAsCMV(sender, e);
            }
        }

        private void action_SaveAsCMV(object sender, EventArgs e)
        {
            string filename;
            DialogResult result;

            saveCMVFileDialog.FileName = cmv.Filename;
            result = saveCMVFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = saveCMVFileDialog.FileName;
                try
                {
                    cmv.Save(filename);
                }
                catch (CMVException e1)
                {
                    MessageBox.Show(this, "Error writing CMV File, Format exception: " + e1.Message, "Error Writing CMV File", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception e2)
                {
                    MessageBox.Show(this, "File access errror, general exception: " + e2.Message, "File access error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void action_Copy(object sender, EventArgs e)
        {
            TimelineControl control = timelineControl;
            copybuffer = cmvframes.GetRange(control.SelectionStart, control.SelectionEnd);

            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
        }

        private void action_Crop(object sender, EventArgs e)
        {
            TimelineControl control = timelineControl;
            cmvframes = cmvframes.Crop(control.SelectionStart, control.SelectionEnd);

            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
            control.SelectionStart = 0;
            control.SelectionEnd = control.FrameCount - 1;

        }

        private void action_Cut(object sender, EventArgs e)
        {
            TimelineControl control = timelineControl;
            copybuffer = cmvframes.GetRange(control.SelectionStart, control.SelectionEnd);
            cmvframes = cmvframes.RemoveRange(control.SelectionStart, control.SelectionEnd);

            control.SelectionEnd = control.SelectionStart;
            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
        }

        private void action_Delete(object sender, EventArgs e)
        {
            TimelineControl control = timelineControl;
            cmvframes = cmvframes.RemoveRange(control.SelectionStart, control.SelectionEnd);

            control.SelectionEnd = control.SelectionStart;

            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
        }

        private void action_DuplicateFrame(object sender, EventArgs e)
        {
            var frameIndex = cmvPlayer.Frame;
            if (cmvframes.Count > 0)
            {
                clonedFrame = CMVFrame.CloneFrame(cmvframes[frameIndex]);
                cmvframes = cmvframes.Insert(frameIndex, clonedFrame);
            }
            else
            {
                MessageBox.Show(this, "No frame available to duplicate, they've all been deleted.", "Duplicate Frame Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            cmvPlayer.Pause();
            cmvPlayer.Frame = frameIndex + 1;

            UpdateCMV();
            RefreshControls();

        }

        private void action_PaintStart(object sender, EventArgs e)
        {
            if (cmvPlayer.PaintedCell.X == -1)
                return;

            clonedFrame = CMVFrame.CloneFrame(cmvframes[cmvPlayer.Frame]);
            cmvframes = cmvframes.Replace(cmvPlayer.Frame, clonedFrame);

            if (cmvPlayer.PaintedCell.X < clonedFrame.Columns && cmvPlayer.PaintedCell.Y < clonedFrame.Rows)
            {
                clonedFrame.SetCell((uint)cmvPlayer.PaintedCell.X, (uint)cmvPlayer.PaintedCell.Y, (byte)tileSelector.SelectedTile, CMVColours.GenerateColorCode(tileSelector.BackgroundColor, tileSelector.ForegroundColor));
            }

            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
        }

        private void action_PaintMove(object sender, EventArgs e)
        {
            if (cmvPlayer.PaintedCell.X == -1)
                return;

            if (cmvPlayer.PaintedCell.X < clonedFrame.Columns && cmvPlayer.PaintedCell.Y < clonedFrame.Rows)
            {
                clonedFrame.SetCell((uint)cmvPlayer.PaintedCell.X, (uint)cmvPlayer.PaintedCell.Y, (byte)tileSelector.SelectedTile, CMVColours.GenerateColorCode(tileSelector.BackgroundColor, tileSelector.ForegroundColor));
            }

            UpdateCMV();
            RefreshControls();
        }

        private void action_Paste(object sender, EventArgs e)
        {
            if (copybuffer.Count == 0)
                return;

            CMVEditorComponents.TimelineControl control = timelineControl;
            if (control.SelectionStart == control.SelectionEnd)
            {
                // Insert just before selection
                CMVFrame[] range = new CMVFrame[copybuffer.Count];
                copybuffer.CopyTo(range);
                cmvframes = cmvframes.InsertRange(control.SelectionStart, range);

                control.SelectionEnd = control.SelectionStart + copybuffer.Count - 1;
            }
            else
            {
                // Replace selection
                CMVFrame[] range = new CMVFrame[copybuffer.Count];
                copybuffer.CopyTo(range);
                cmvframes = cmvframes.ReplaceRange(control.SelectionStart, control.SelectionEnd, range);

                control.SelectionEnd = control.SelectionStart + copybuffer.Count - 1;
            }

            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
        }

        private void action_Pad(object sender, EventArgs e)
        {
            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
        }

        private void action_Strip(object sender, EventArgs e)
        {
            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
        }

        private void action_Undo(object sender, EventArgs e)
        {
            cmvframes = cmvframes.PreviousState;
            cmvPlayer.Pause();
            UpdateCMV();
            RefreshControls();
        }

        private void action_selectAll(object sender, EventArgs e)
        {
            timelineControl.SelectionStart = 0;
            timelineControl.SelectionEnd = cmvframes.Count;
        }

        /* Event handlers */
        private void cmvPlayer_FrameChanged(object sender, EventArgs e)
        {
            RefreshTimelineControl();
        }

        private void cmvPlayer_CMVChanged(object sender, EventArgs e)
        {
            cmvPlayer.Width  = cmvPlayer.DrawArea.Width;
            cmvPlayer.Height = cmvPlayer.DrawArea.Height;

            // register structural changes to the CMV with a local method
            cmv.StructureChanged += new EventHandler(cmv_StructureChanged);

            // recall a frame changed event to update the timeline
            cmvPlayer_FrameChanged(sender, e);
        }

        private void cmv_StructureChanged(object sender, EventArgs e)
        {
            cmvPlayer_FrameChanged(sender, e);
            cmvInfoControl.updateInfo();
        }

        private void timelineControl_FrameSelected(object sender, int index)
        {
            updateDelayTimer.Tag = index;

            if (!updateDelayTimer.Enabled)
            {
                cmvPlayer.Frame = index;
                updateDelayTimer.Start();
            }
            RefreshTimelineControl();

            cmvPlayer.Pause();
        }

        private void handleUpdateDelayTimer(object sender, EventArgs e)
        {
            int frame;

            frame = (int)updateDelayTimer.Tag;
            if(frame > 0)
                cmvPlayer.Frame = frame;

            updateDelayTimer.Stop();
        }

        private void action_cmvPlayerPlay(object sender, EventArgs e)
        {
            cmvPlayer.Play();
        }

        private void action_cmvPlayerPause(object sender, EventArgs e)
        {
            cmvPlayer.Pause();
        }

        private void action_cmvPlayerRewind(object sender, EventArgs e)
        {
            if (cmvPlayer.Frame > timelineControl.SelectionStart)
                cmvPlayer.Frame = timelineControl.SelectionStart;
            else
                cmvPlayer.Frame = 0;
        }

        private void action_cmvPlayerSkipToEnd(object sender, EventArgs e)
        {
            if (cmvPlayer.Frame < timelineControl.SelectionEnd)
                cmvPlayer.Frame = timelineControl.SelectionEnd;
            else
                cmvPlayer.Frame = (int)cmvPlayer.CMV.FrameCount;
        }

        private void action_cmvPlayerStepBackwards(object sender, EventArgs e)
        {
            cmvPlayer.PreviousFrame();
        }

        private void action_cmvPlayerStepForwards(object sender, EventArgs e)
        {
            cmvPlayer.NextFrame();
        }

        private void action_VisitBay12gamesWebsite(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.bay12games.com/dwarves/?referrer=CMVEditor");
        }

        private void handleKeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Delete)
            {
                action_Delete(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Left)
            {
                action_cmvPlayerStepBackwards(sender, e);
            }
            else if (e.KeyChar == (char)Keys.Right)
            {
                action_cmvPlayerStepForwards(sender, e);
            }
        }

        private void action_uploadMovieToArchive(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mkv25.net/dfma/addmovie.php"); 
        }

        private void action_exportFrame(object sender, EventArgs e)
        {
            string filename;
            DialogResult result;
            Bitmap target;

            saveImageFileDialog.FileName = "cmv_frame_" + cmvPlayer.Frame + ".png";
            result = saveImageFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                try
                {
                    filename = saveImageFileDialog.FileName;
                    target = new Bitmap(cmvPlayer.DrawArea.Width, cmvPlayer.DrawArea.Height);
                    cmvPlayer.DrawToBitmap(target, cmvPlayer.DrawArea);
                    target.Save(filename);
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not export the specified frame.", "Frame Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void action_changeTileset(object sender, EventArgs e)
        {

        }

        private void action_ChooseNewTileset(object sender, EventArgs e)
        {
            string filename;
            DialogResult result;
            TileSet target;

            openImageFileDialog.FileName = "tileset.bmp";
            result = openImageFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                filename = openImageFileDialog.FileName;
                try
                {
                    target = new TileSet(filename);
                    tileset = target;
                    action_changeTileset(sender, e);
                }
                catch (Exception)
                {
                    MessageBox.Show(this, "The selected tileset was unusable, try another one. Compatable tilesets should be 16x16 grids (256) of icons.", "Error processing tileset", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void action_toolSelectNone(object sender, EventArgs e)
        {
            cmvPlayer.ToolMode = ToolMode.NONE;
            RefreshControls();
        }

        private void action_toolSelectPaintBrush(object sender, EventArgs e)
        {
            cmvPlayer.ToolMode = ToolMode.PAINT_TOOL;
            RefreshControls();
        }

        private void action_toolSelectSelection(object sender, EventArgs e)
        {
            cmvPlayer.ToolMode = ToolMode.SELECTION_TOOL;
            RefreshControls();
        }

        private void action_toolSelectText(object sender, EventArgs e)
        {
            cmvPlayer.ToolMode = ToolMode.TEXT_TOOL;
            RefreshControls();
        }

        private void action_About(object sender, EventArgs e)
        {
            aboutBox.ShowDialog(this);
        }

        private void action_Revert(object sender, EventArgs e)
        {
            DialogResult result;

            try
            {
                openFileName(cmv.Filename);
            }
            catch (Exception)
            {
                result = MessageBox.Show("Could not load original file to revert back to.\n\nDo you want to undo all changes instead?", "Error reverting", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    cmvframes = cmvframes.ListChanges[0];
                    UpdateCMV();
                    RefreshControls();
                }
            }
        }

        private void action_Exit(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {
                this.Dispose();
            }
        }

        private void action_HelpTopics(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("help.html");
        }

        private void backgroundColourPicked(Color colour)
        {
            tileSelector.BackgroundColor = colour;
        }

        private void foregroundColourPicked(Color colour)
        {
            tileSelector.ForegroundColor = colour;
        }
    }
}