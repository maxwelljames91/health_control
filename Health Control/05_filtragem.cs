﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Health_Control
{
    public partial class tela_filtragem : Form
    {
        public tela_filtragem()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
