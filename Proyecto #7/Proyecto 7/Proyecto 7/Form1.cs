﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_7
{
    public partial class F_A : Form
    {
        public F_A()
        {
            InitializeComponent();
        }

        private void BT_Cambio_Click(object sender, EventArgs e)
        {
            F_B miforma = new F_B();

            miforma.ShowDialog();

        }
    }
}
