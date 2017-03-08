using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YazLab
{
    public partial class PathShow : Form
    {
        public PathShow()
        {
            InitializeComponent();
        }

        private void PathShow_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Control.pathFinder.GetLength(0); i++)
            {
                richTextBox1.Text += Control.pathFinder[i, 0];
                richTextBox1.Text += Control.pathFinder[i, 1];
                richTextBox1.Text += "\n";
            }
        }
    }
}
