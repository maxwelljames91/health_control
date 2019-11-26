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

        private void btn_esqueceu_Click(object sender, EventArgs e)
        {

        }

        private void cbx_lembrar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textbox_login_KeyUp(object sender, KeyEventArgs e)
        {
            if (textbox_login.Text == "")
            {
                textbox_login.Text = "Nome de Usuário";
                textbox_login.ForeColor = Color.DarkGray;
            }
        }

        private void textbox_login_KeyDown(object sender, KeyEventArgs e)
        {
            if (textbox_login.Text == "Nome de Usuário")
            {
                textbox_login.Text = "";
                textbox_login.ForeColor = Color.Gray;
            }
        }

        private void textbox_senha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textbox_senha_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void textbox_senha_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
