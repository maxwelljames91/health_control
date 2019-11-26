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

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela_cadastro newForm = new tela_cadastro();
            newForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela_login newForm = new tela_login();
            newForm.ShowDialog();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void txt_controle_Click(object sender, EventArgs e)
        {

        }

        private void txt_sejabemvindo_Click(object sender, EventArgs e)
        {

        }

        private void pnl_data_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_data_Click(object sender, EventArgs e)
        {

        }

        private void btn_filtro_Click(object sender, EventArgs e)
        {

        }

        private void btn_acoes_Click(object sender, EventArgs e)
        {

        }

        private void textbox_pesquisa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void btn_novo_cadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela_cadastro newForm = new tela_cadastro();
            newForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_config_Click(object sender, EventArgs e)
        {

        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            this.Hide();
            tela_login newForm = new tela_login();
            newForm.ShowDialog();
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
