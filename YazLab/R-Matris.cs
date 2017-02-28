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
    public partial class R_Matris : Form
    {
        public R_Matris()
        {
            InitializeComponent();
        }

        private void R_Matris_Load(object sender, EventArgs e)
        {
            Control.CreateRMatris();
            for(int i=0;i<Control.inputMatrisSize;i++)
            {
                for(int y=0;y<Control.inputMatrisSize;y++)
                {
                    richTextBox1.Text += Control.rMatris[i, y];
                }
                richTextBox1.Text += "\n";
            }
        }
    }
}
