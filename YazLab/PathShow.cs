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
            foreach(int key in Control.pathFinder)
            {
                richTextBox1.Text += key.ToString();
                richTextBox1.Text += "\n";
            }
        }
    }
}
