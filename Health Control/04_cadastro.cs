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
    public partial class tela_cadastro : Form
    {
        public tela_cadastro()
        {
            InitializeComponent();
        }


        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            
           
            //     VALIDAÇÃO DO NOME COMPLETO

            if (textbox_nomecompleto.Text == "")
            {
                MessageBox.Show("O campo 'NOME COMPLETO' é obrigatório.", caption: "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_nomecompleto.Focus();
                return;
            }

            if (ValidarNome(textbox_nomecompleto.Text) == false)

            {
                MessageBox.Show("O campo 'NOME COMPLETO' que você forneceu é inválido.", caption: "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_nomecompleto.Focus();
                return;
            }

            // Sub rotina para validar NOME COMPLETO a partir de uma 
            // substring contendo os caracteres permitidos
            static bool ValidarNome(string strEmail)
            {
                string strModelo = "abcdefghijklmnopqrstuvwxyzáàãâäéèêëíìîïóòõôöúùûüçABCDEFGHIJKLMNOPQRSTUVWXYZÁÀÃÂÄÉÈÊËÍÌÎÏÓÒÕÔÖÚÙÛÜÇ ";
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


            //           VALIDAÇÃO DO EMAIL

            if (textbox_email.Text == "")
            {
                MessageBox.Show("O campo 'E-MAIL' é obrigatório.", caption: "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_email.Focus();
                return;
            }

            if (Validar_Email(textbox_email.Text) == false)

            {
                MessageBox.Show("O campo 'E-MAIL' que você forneceu é inválido.", caption: "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_email.Focus();
                return;
            }
            
            // Sub rotina para validar EMAIL usando expressões regulares
            // Para maiores informações consulte:
            // https://docs.microsoft.com/pt-br/dotnet/standard/base-types/regular-expressions
            static bool Validar_Email(string strEmail)
            {
                string strModelo = "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (System.Text.RegularExpressions.Regex.IsMatch(strEmail, strModelo))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            //           VALIDAÇÃO DA FUNÇÃO

            if (textbox_funcao.Text == "")
            {
                MessageBox.Show("O campo 'FUNÇÃO' é obrigatório.", caption: "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_funcao.Focus();
                return;
            }

            if (ValidarFuncao(textbox_funcao.Text) == false)

            {
                MessageBox.Show("O campo 'FUNÇÃO' que você forneceu é inválido.", caption: "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_funcao.Focus();
                return;
            }

            // Sub rotina para validar EXAME a partir de uma 
            // substring contendo os caracteres permitidos
            static bool ValidarFuncao(string strEmail)
            {
                string strModelo = "abcdefghijklmnopqrstuvwxyzáàãâäéèêëíìîïóòõôöúùûüçABCDEFGHIJKLMNOPQRSTUVWXYZÁÀÃÂÄÉÈÊËÍÌÎÏÓÒÕÔÖÚÙÛÜÇ ";
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


            //           VALIDAÇÃO DO EXAME

            if (textbox_exame.Text == "")
            {
                MessageBox.Show("O campo 'EXAME' é obrigatório.", caption: "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_exame.Focus();
                return;
            }

            if (ValidarExame(textbox_exame.Text) == false)

            {
                MessageBox.Show("O campo 'EXAME' que você forneceu é inválido.", caption: "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                textbox_exame.Focus();
                return;
            }

            // Sub rotina para validar EXAME a partir de uma 
            // substring contendo os caracteres permitidos
            static bool ValidarExame(string strEmail)
            {
                string strModelo = "abcdefghijklmnopqrstuvwxyzáàãâäéèêëíìîïóòõôöúùûüçABCDEFGHIJKLMNOPQRSTUVWXYZÁÀÃÂÄÉÈÊËÍÌÎÏÓÒÕÔÖÚÙÛÜÇ ";
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
            
            //     VALIDAÇÃO DO TIPO

            if (combobox_tipo.Text == "[Selecione]")
            {
                MessageBox.Show("Por favor, selecione um tipo de exame no campo 'TIPO'.", caption: "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                combobox_tipo.Focus();
                return;
            }

            // CADASTRO REALIZADO COM SUCESSO
            MessageBox.Show("Cadastro realizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            this.Hide();
            tela_relatorio newForm = new tela_relatorio();
            newForm.ShowDialog();

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja cancelar o cadastro?", caption: "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                tela_relatorio newForm = new tela_relatorio();
                newForm.ShowDialog();
            }
        }
    }
}
