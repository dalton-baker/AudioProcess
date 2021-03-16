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
    public partial class Volume_Adjust : Form
    {
        public float Adjust { get; set; } = 1;

        public Volume_Adjust()
        {
            InitializeComponent();
            vAdjust.Text = 1.ToString();
        }

       

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Adjust = (float)Convert.ToDouble(vAdjust.Text);
        }
    }
}
