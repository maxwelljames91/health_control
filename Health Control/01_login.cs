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

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (textbox_login.Text == "")
            {
                MessageBox.Show("Insira seu nome de usuário.", caption: "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_login.Focus();
                return;
            }

            if (ValidarLogin(textbox_login.Text) == false)

            {
                MessageBox.Show("O nome de usuário que você forneceu é inválido.", caption: "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_login.Focus();
                return;
            }

            // Sub rotina para validar login a partir de uma 
            // substring contendo os caracteres permitidos
            static bool ValidarLogin(string strEmail)
            {
                string strModelo = "abcdefghijklmnopqrstuvwxyzçABCDEFGHIJKLMNOPQRSTUVWXYZÇ0123456789_-";
                bool achou = false;
                for (int i = 0; i < strEmail.Length; i++)
                {
                    achou = false;
                    for (int j = 0; j < strModelo.Length; j++)
                    {
                        if (strEmail.Substring(i, 1) == strModelo.Substring(j, 1))
                        {
                            achou = true;
                            break;
                        }
                    }
                    if (achou == false) { break; }
                }
                return achou;
            }

            if (textbox_senha.Text == "")
            {
                MessageBox.Show("Por favor, insira sua senha.", caption: "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_senha.Focus();
                return;
            }

            this.Hide();
            tela_relatorio newForm = new tela_relatorio();
            newForm.ShowDialog();
        }

    }
}
