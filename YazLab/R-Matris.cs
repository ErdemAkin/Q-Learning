﻿using System;
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
            Control.initRDataTable();
            dataGridView1.DataSource = Control.rtable;
        }
    }
}
