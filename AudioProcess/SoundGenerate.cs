using System;
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

        #region Povided Functions
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

            sound.ApplyDelegateByTime(t =>
            {
                float val = sineParams.amplitude * SinFunc(t, sineParams.freq1);
                return (val, val);
            });

        }
        #endregion

        #region Tutorial 3
        public void MakeSineAdditive(Sound sound)
        {
            if (SoundIsNull(sound))
                return;

            sound.ApplyDelegateByTime(t =>
            {
                float channel1 = sineParams.amplitude * SinFunc(t, sineParams.freq1);
                float channel2 = sineParams.amplitude * SinFunc(t, sineParams.freq2);
                return (channel1, channel2);
            });
        }

        public void Make234Harm(Sound sound)
        {
            if (SoundIsNull(sound))
                return;

            sound.ApplyDelegateByTime(time =>
            {
                float channel1 = sineParams.amplitude * SinFunc(time, sineParams.freq1);
                channel1 += sineParams.amplitude * SinFunc(time, sineParams.freq1 * 2) / 2;
                channel1 += sineParams.amplitude * SinFunc(time, sineParams.freq1 * 3) / 3;
                channel1 += sineParams.amplitude * SinFunc(time, sineParams.freq1 * 4) / 4;

                float channel2 = sineParams.amplitude * SinFunc(time, sineParams.freq2);
                channel2 += sineParams.amplitude * SinFunc(time, sineParams.freq2 * 2) / 2;
                channel2 += sineParams.amplitude * SinFunc(time, sineParams.freq2 * 3) / 3;
                channel2 += sineParams.amplitude * SinFunc(time, sineParams.freq2 * 4) / 4;

                return (channel1, channel2);
            });
        }

        public void Make357Harm(Sound sound)
        {
            if (SoundIsNull(sound))
                return;

            sound.ApplyDelegateByTime(t =>
            {
                float channel1 = sineParams.amplitude * SinFunc(t, sineParams.freq1);
                channel1 += sineParams.amplitude * SinFunc(t, sineParams.freq1 * 3) / 3;
                channel1 += sineParams.amplitude * SinFunc(t, sineParams.freq1 * 5) / 5;
                channel1 += sineParams.amplitude * SinFunc(t, sineParams.freq1 * 7) / 7;

                float channel2 = sineParams.amplitude * SinFunc(t, sineParams.freq2);
                channel2 += sineParams.amplitude * SinFunc(t, sineParams.freq2 * 3) / 3;
                channel2 += sineParams.amplitude * SinFunc(t, sineParams.freq2 * 5) / 5;
                channel2 += sineParams.amplitude * SinFunc(t, sineParams.freq2 * 7) / 7;

                return (channel1, channel2);
            });
        }

        public void MakeAllHarm(Sound sound)
        {
            if (SoundIsNull(sound))
                return;

            sound.ApplyDelegateByTime(t =>
            {
                float channel1 = 0;
                for (float i = 1; i < sineParams.freq1 / 2; i++)
                {
                    channel1 += sineParams.amplitude * SinFunc(t, sineParams.freq1 * i) / i;
                }

                float channel2 = 0;
                for (float i = 1; i < sineParams.freq1 / 2; i++)
                {
                    channel2 += sineParams.amplitude * SinFunc(t, sineParams.freq2 * i) / i;
                }

                return (channel1, channel2);
            });
        }

        public void MakeOddHarm(Sound sound)
        {
            if (SoundIsNull(sound))
                return;

            sound.ApplyDelegateByTime(t =>
            {
                float channel1 = 0;
                for (float i = 1; i < sineParams.freq1 / 2; i += 2)
                {
                    channel1 += sineParams.amplitude * SinFunc(t, sineParams.freq1 * i) / i;
                }

                float channel2 = 0;
                for (float i = 1; i < sineParams.freq1 / 2; i += 2)
                {
                    channel2 += sineParams.amplitude * SinFunc(t, sineParams.freq2 * i) / i;
                }

                return (channel1, channel2);
            });
        }

        private bool SoundIsNull(Sound sound)
        {
            if (sound == null)
            {
                MessageBox.Show("Need a sound loaded first", "Generation Error");
                return true;
            }
            return false;
        }

        private float SinFunc(double time, float freq)
        {
            return (float)(Math.Sin(time * 2 * Math.PI * freq));
        }
        #endregion
    }
}
