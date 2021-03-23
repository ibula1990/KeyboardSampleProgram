using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyboardSampleProgram
{
    public partial class KeyboardSample : Form
    {
        public KeyboardSample()
        {
            InitializeComponent();
        }

        private void KeyboardSample_Load(object sender, EventArgs e)
        {

        }

        private void KeyboardSample_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.R)
            {
                this.BackColor = Color.Red;

            }
            else if (e.KeyCode == Keys.G)
            {
                this.BackColor = Color.Green;

            }
            else if (e.KeyCode == Keys.Y)
            {
                this.BackColor = Color.Yellow;
            }
            else if (e.KeyCode == Keys.Q)
            {
                this.BackColor = Color.Black;
                this.Text = "Queen";
            }
            else if(e.KeyCode==Keys.M)
            {
                this.WindowState = FormWindowState.Maximized;

            }
            else
                MessageBox.Show("invalid");

        }
    }
}
