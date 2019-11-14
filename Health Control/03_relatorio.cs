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
            tela_cadastro newForm = new tela_cadastro();
            newForm.ShowDialog();
            this.Close();
        }
    }
}
