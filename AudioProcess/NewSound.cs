using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioProcess
{
    public partial class NewSound : Form
    {
        public int SampleRate { get; set; } = 44100;
        public float Seconds { get; set; } = 10;
        public int Channels { get; set; } = 1;

        public NewSound()
        {
            InitializeComponent();
            channels.SelectedIndex = 1;
        }

       

        private void buttonOK_Click(object sender, EventArgs e)
        {
            SampleRate = Convert.ToInt32(rate.Text);
            Seconds = (float)Convert.ToDouble(seconds.Text);
            Channels = channels.SelectedIndex +1;
        }
    }
}
