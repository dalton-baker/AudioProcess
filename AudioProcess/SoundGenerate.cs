using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioProcess
{
    public struct SineParams
    {
        public float freq1;
        public float freq2;
        public float sampleRate;
        public float amplitude;
    }
    class SoundGenerate
    {


        private SineParams sineParams;

        public SoundGenerate()
        {
            sineParams.freq1 = 440.0f;
            sineParams.freq2 = 440.0f;
            sineParams.amplitude = 1f;
        }

        public void MakeParamSine()
        {
            Generic_Sine dlg = new Generic_Sine(sineParams);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                sineParams = dlg.SineParams;
            }
        }


       


        /// <summary>
        ///      Example procedure that generates a sine wave.
        ///      The sine wave frequency is set by freq1
        ///
        /// </summary>
        /// <param name="sound">The Sound to fill</param>
        public void MakeSine(Sound sound)
        {

            if (sound == null)
            {
                MessageBox.Show("Need a sound loaded first", "Generation Error");
                return;
            }

            //pull needed sound file encoding parameters
            int sampleRate = sound.Format.SampleRate;
            int channels = sound.Format.Channels;
            float duration = sound.Duration - 1.0f / sampleRate;

            //setup progress bar
            ProgressBar progress = new ProgressBar();
            progress.Runworker();

            //make the sine wave
            int index = 0;
            for (double time = 0.0; time < duration; time += 1.0 / sampleRate)
            {
                //make the value at this frame
                float val = (float)(sineParams.amplitude * Math.Sin(time * 2 * Math.PI * sineParams.freq1));

                //fill all channels with the value
                for (int c = 0; c < channels; c++)
                {
                    sound.Samples[index + c] = val;
                }

                index += channels;

                progress.UpdateProgress(time / duration);
            }
        }

    }
}
