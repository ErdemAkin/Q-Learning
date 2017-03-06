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
    public partial class Q_Matris : Form
    {
        public Q_Matris()
        {
            InitializeComponent();
        }

        private void Q_Matris_Load(object sender, EventArgs e)
        {
            Control.InitQMatris();
            Control.CreateQMatris();
            Control.initQDataTable();
            dataGridView2.DataSource = Control.qtable;
        }
    }
}
