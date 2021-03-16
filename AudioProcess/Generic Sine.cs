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
    public partial class Generic_Sine : Form
    {
        private SineParams sineParams;
        public SineParams SineParams { get => sineParams; set => sineParams = value; }

        public Generic_Sine(SineParams p)
        {
            InitializeComponent();
            sineParams = p;
            freq1.Text = sineParams.freq1.ToString();
            freq2.Text = sineParams.freq2.ToString();
            amplitude.Text = sineParams.amplitude.ToString();
        }

       

        private void buttonOK_Click(object sender, EventArgs e)
        {
            sineParams.freq1 = (float)Convert.ToDouble(freq1.Text);
            sineParams.freq2 = (float)Convert.ToDouble(freq2.Text);
            sineParams.amplitude = (float)Convert.ToDouble(amplitude.Text);
        }
    }
}
