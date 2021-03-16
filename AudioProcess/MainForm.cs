using System;
using System.Drawing;
using System.Windows.Forms;
using NAudio.Wave;

/**********************************************************************************
* Mark off what items are complete (e.g. x, done, checkmark, etc), and put a P if 
* partially complete. If 'P' include how to test what is working for partial credit 
* below the checklist line.
* 
* Total available points:  100
* 
* ✓______   30	Tutorial completed (if not, what was the last section completed)
* ✓______   5	234 Menu Option
* ✓______   5	357 Menu Option
* ✓______   10	All Harmonics Option - These sounded much clearer and crisper than
* ✓______   5	Odd Harmonics Option - the 234 and 357 versions
* ✓______   10	Ramp In/Out
* ✓______   10	Tremolo
* ✓______   10	Half Speed
* ✓______   10	Backwards
* ✓______   5   Did you hear it? (Completion points)
* 			NASA Statement about Roswell: Before: 0 After: 9
* 			Joran van der Sloot: Before: 0 After: 9
* 			Nancy Pelosi: Before: 0 After: 9
* 			I really tried to hear anything in the reversed audio, but I couldn't until I read what I was supposed to hear
* ______	Total (please add the points and include the total here)
* 
* 
* The grade you compute is the starting point for course staff, who reserve the 
* right to change the grade if they disagree with your assessment and to deduct 
* points for other issues they may encounter, such as errors in the submission 
* process, naming issues, etc.
* 
**********************************************************************************/

namespace AudioProcess
{


    public partial class MainForm : Form
    {

        private Sound sound = null;
        private String lastFile = null;
        private SoundView soundRendering = new SoundView();
        private SoundGenerate gen = new SoundGenerate();
        private SoundProcess process = new SoundProcess();

        public MainForm()
        {
            InitializeComponent();
           
            //define the area to display the sound waves
            Rectangle drawArea = ClientRectangle;
            drawArea.Y = menuStrip1.Height;
            soundRendering.DrawArea = drawArea;
            soundRendering.SamplesPerPeak = vScrollBar.Value;
            saveItem.Enabled = false;

            DoubleBuffered = true;
        }

        #region Callbacks
        protected override void OnPaint(PaintEventArgs e)
        {
            if (sound == null)
                return;

            soundRendering.OnPaint(e.Graphics);
        }

        protected override void OnResize(EventArgs e)
        {
            
            base.OnResize(e);

            Rectangle drawArea = ClientRectangle;
            drawArea.Y = menuStrip1.Height;
            soundRendering.DrawArea = drawArea;

            Invalidate();
        }
        #endregion

        #region Menu Handlers
        private void closeItem_Click(object sender, EventArgs e)
        {
            sound = null;
            Invalidate();

        }

        private void darkModeItem_Click(object sender, EventArgs e)
        {
            soundRendering.MakeDarkFormat();
            Invalidate();
        }

        private void exitItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            soundRendering.SetOffsetFromPercent((double)e.NewValue / (hScrollBar.Maximum - hScrollBar.Minimum));

            Invalidate();
        }

        private void lightModeItem_Click(object sender, EventArgs e)
        {
            soundRendering.MakeLightFormat();
            Invalidate();
        }

        private void newMenu_Click(object sender, EventArgs e)
        {
            NewSound dlg = new NewSound();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sound = new Sound();
                sound.Format = WaveFormat.CreateIeeeFloatWaveFormat(dlg.SampleRate, dlg.Channels);
                sound.Samples = new float[(int)(dlg.SampleRate * dlg.Channels * dlg.Seconds)];
                soundRendering.Sound = sound;
            }
           dlg.Dispose();

            Invalidate();
        }

        private void openDefaultItem_Click(object sender, EventArgs e)
        {
            sound = new Sound();
            sound.Open(Properties.Resources.nasa);

            soundRendering.Sound = sound;
            Invalidate();
        }

        private void openItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sound = new Sound();
                sound.Open(openFileDialog.FileName);
                soundRendering.Sound = sound;
                Invalidate();
            }
            openFileDialog.Dispose();
        }

        private void pauseItem_Click(object sender, EventArgs e)
        {
            if (sound != null)
                sound.Pause();
        }

        private void playItem_Click(object sender, EventArgs e)
        {
            if (sound != null)
                sound.BasicPlay();
        }

        private void saveAsItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sound.SaveAs(saveFileDialog.FileName, saveFileDialog.FilterIndex);
                if (lastFile != null)
                {
                    saveItem.Enabled = true;
                    lastFile = saveFileDialog.FileName;
                }
            }
            saveFileDialog.Dispose();
        }

        private void saveItem_Click(object sender, EventArgs e)
        {
            if (lastFile != null)
                sound.Save();
            else
                MessageBox.Show("No prior file saved", "Error");
        }

        private void sineItem_Click(object sender, EventArgs e)
        {
            gen.MakeSine(sound);
            Invalidate();
        }

        private void stopItem_Click(object sender, EventArgs e)
        {
            if (sound != null)
                sound.Stop();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            soundRendering.SamplesPerPeak = e.NewValue;
            Invalidate();
        }

        private void sineParamsItem_Click(object sender, EventArgs e)
        {
            gen.MakeParamSine();
        }

        private void volumeAdjustItem_Click(object sender, EventArgs e)
        {
            Volume_Adjust dlg = new Volume_Adjust();
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                process.OnProcessVolume(sound, dlg.Adjust);
                Invalidate();
            }
            
        }
        #endregion

        #region Tutorial 3
        private void sineWavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gen.MakeSineAdditive(sound);
            Invalidate();
        }
        #endregion

        private void toolStripMenu234_Click(object sender, EventArgs e)
        {
            gen.Make234Harm(sound);
            Invalidate();
        }

        private void toolStripMenu357_Click(object sender, EventArgs e)
        {
            gen.Make357Harm(sound);
            Invalidate();
        }

        private void allHarmonicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gen.MakeAllHarm(sound);
            Invalidate();
        }

        private void oddHarmonicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gen.MakeOddHarm(sound);
            Invalidate();
        }

        private void rampToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process.OnProcessRamp(sound);
            Invalidate();
        }

        private void tremoloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            process.OnProcessTremolo(sound);
            Invalidate();
        }

        private void halfSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sound = process.OnProcessHalfSpeed(sound);
            soundRendering.Sound = sound;
            Invalidate();
        }

        private void doubleSpeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sound = process.OnProcessDoubleSpeed(sound);
            soundRendering.Sound = sound;
            Invalidate();
        }
        
        private void reverseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sound = process.OnProcessReverse(sound);
            soundRendering.Sound = sound;
            Invalidate();
        }
    }
}
