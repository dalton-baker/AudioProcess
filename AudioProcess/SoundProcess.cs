using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioProcess
{
    class SoundProcess
    {
        #region Provided Functions
        /// <summary>
        /// Increases or descrease the volume of a sound
        /// </summary>
        /// <param name="sound">the sound to change</param>
        /// <param name="volume">the new amplitude multiplier</param>
        public void OnProcessVolume(Sound sound, float volume)
        {
            if (SoundIsNull(sound))
                return;

            sound.ApplyDelegateBySample(s =>
            {
                var newVal = s * volume;
                return newVal;
            });
        }
        #endregion

        #region Tutorial 3
        public void OnProcessRamp(Sound sound)
        {
            if (SoundIsNull(sound))
                return;

            OnProcessVolume(sound, 2);

            sound.ApplyDelegateBySampleAndTime((s, t) =>
            {
                if (t < 1.5)
                {
                    return s * (t / 1.5f);
                }
                else if (sound.Duration - t < 1.5)
                {
                    return s * ((sound.Duration - t) / 1.5f);
                }
                else
                {
                    return s;
                }
            });
        }

        public void OnProcessTremolo(Sound sound)
        {
            if (SoundIsNull(sound))
                return;

            sound.ApplyDelegateBySampleAndTime((s, t) =>
            {
                return s * (float)(1.2 * Math.Sin(8 * Math.PI * t));
            });
        }

        public Sound OnProcessHalfSpeed(Sound sound)
        {
            if (SoundIsNull(sound))
                return sound;

            Sound slowSound = new Sound(sound.SampleRate, sound.Channels, sound.Duration * 2);

            slowSound.ApplyDelegateByIndex(i =>
            {
                int oldIndex = i / 2;

                if (i % 2 == 0 || oldIndex + 1 >= sound.Samples.Length)
                {
                    return sound.Samples[oldIndex];
                }

                return (sound.Samples[oldIndex] + sound.Samples[oldIndex +1]) / 2;
            });

            return slowSound;
        }

        public Sound OnProcessDoubleSpeed(Sound sound)
        {
            if (SoundIsNull(sound))
                return sound;

            Sound fastSound = new Sound(sound.SampleRate, sound.Channels, sound.Duration / 2);

            fastSound.ApplyDelegateByIndex(i => sound.Samples[i * 2]);

            return fastSound;
        }

        public Sound OnProcessReverse(Sound sound)
        {
            if (SoundIsNull(sound))
                return sound;

            Sound reverseSound = new Sound(sound.SampleRate, sound.Channels, sound.Duration);

            reverseSound.ApplyDelegateByIndex(i => sound.Samples[sound.Samples.Length - i - 1]);

            return reverseSound;
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
        #endregion
    }
}
