using System;
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
    public partial class tela_login : Form
    {
        public tela_login()
        {
            InitializeComponent();
        }

        private void tela_login_Load(object sender, EventArgs e)
        {

        }

        private void text_nome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela_relatorio newForm = new tela_relatorio();
            newForm.ShowDialog();
        }

        private void txt_bemvindo_Click(object sender, EventArgs e)
        {

        }

    }
}
