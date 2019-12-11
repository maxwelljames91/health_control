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
    public partial class tela_relatorio : Form
    {
        public tela_relatorio()
        {
            InitializeComponent();

        }

        private void tela_relatorio_Load(object sender, EventArgs e)
        {
            txt_data.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }


        private void btn_novo_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela_cadastro newForm = new tela_cadastro();
            newForm.ShowDialog();
        }


        private void btn_logoff_Click(object sender, EventArgs e)
        {
               
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", caption: "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                this.Hide();
                tela_login newForm = new tela_login();
                newForm.ShowDialog();
            }

        }

        private void textbox_pesquisa_KeyUp(object sender, KeyEventArgs e)
        {
            if (textbox_pesquisa.Text == "")
            {
                textbox_pesquisa.Text = "Pesquisar";
                textbox_pesquisa.ForeColor = Color.Gray;
            }
        }
        
        private void textbox_pesquisa_KeyDown(object sender, KeyEventArgs e)
        {
            if (textbox_pesquisa.Text == "Pesquisar")
            {
                textbox_pesquisa.Text = "";
                textbox_pesquisa.ForeColor = Color.Black;
            }
        }

    }
}
