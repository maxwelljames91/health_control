namespace Health_Control
{
    partial class tela_relatorio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_relatorio));
            this.txt_controle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_pesquisa = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_acoes = new System.Windows.Forms.Button();
            this.btn_filtro = new System.Windows.Forms.Button();
            this.btn_novo_cadastro = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_controle
            // 
            this.txt_controle.AutoSize = true;
            this.txt_controle.BackColor = System.Drawing.Color.Transparent;
            this.txt_controle.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_controle.Location = new System.Drawing.Point(14, 56);
            this.txt_controle.Name = "txt_controle";
            this.txt_controle.Size = new System.Drawing.Size(336, 20);
            this.txt_controle.TabIndex = 9;
            this.txt_controle.Text = "RELATÓRIO DO CONTROLE DE EXAMES DE SAÚDE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "BEM-VINDO(A), ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Khaki;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(585, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(108, 69);
            this.panel2.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Khaki;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "DATA DE HOJE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_pesquisa);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Location = new System.Drawing.Point(706, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 30);
            this.panel1.TabIndex = 8;
            // 
            // txt_pesquisa
            // 
            this.txt_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pesquisa.Location = new System.Drawing.Point(8, 6);
            this.txt_pesquisa.Name = "txt_pesquisa";
            this.txt_pesquisa.Size = new System.Drawing.Size(237, 15);
            this.txt_pesquisa.TabIndex = 9;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Health_Control.Properties.Resources.btn_pesquisa;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(251, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(38, 29);
            this.button3.TabIndex = 4;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(15, 92);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(832, 457);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.HeaderText = "SELEC.";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "COLABORADOR";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "FUNÇÃO";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "TIPO DE EXAME";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "ÚLTIMO EXAME";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "PRÓXIMO EXAME";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "STATUS";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::Health_Control.Properties.Resources.btn_logoff;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(855, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "     LOGOFF";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial Black", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = global::Health_Control.Properties.Resources.btn_config;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(855, 480);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 30);
            this.button2.TabIndex = 3;
            this.button2.Text = " CONFIGURAÇÕES";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btn_acoes
            // 
            this.btn_acoes.BackColor = System.Drawing.Color.Gray;
            this.btn_acoes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_acoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_acoes.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_acoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_acoes.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_acoes.ForeColor = System.Drawing.Color.White;
            this.btn_acoes.Image = global::Health_Control.Properties.Resources.btn_acoes;
            this.btn_acoes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_acoes.Location = new System.Drawing.Point(855, 52);
            this.btn_acoes.Name = "btn_acoes";
            this.btn_acoes.Size = new System.Drawing.Size(141, 30);
            this.btn_acoes.TabIndex = 7;
            this.btn_acoes.Text = "       AÇÕES";
            this.btn_acoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acoes.UseVisualStyleBackColor = false;
            // 
            // btn_filtro
            // 
            this.btn_filtro.BackColor = System.Drawing.Color.Gray;
            this.btn_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_filtro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtro.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtro.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtro.ForeColor = System.Drawing.Color.White;
            this.btn_filtro.Image = global::Health_Control.Properties.Resources.btn_filtro;
            this.btn_filtro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtro.Location = new System.Drawing.Point(706, 52);
            this.btn_filtro.Name = "btn_filtro";
            this.btn_filtro.Size = new System.Drawing.Size(141, 30);
            this.btn_filtro.TabIndex = 5;
            this.btn_filtro.Text = "   FILTRAGEM";
            this.btn_filtro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtro.UseVisualStyleBackColor = false;
            this.btn_filtro.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_novo_cadastro
            // 
            this.btn_novo_cadastro.BackColor = System.Drawing.Color.Green;
            this.btn_novo_cadastro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_novo_cadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo_cadastro.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_novo_cadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo_cadastro.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo_cadastro.ForeColor = System.Drawing.Color.White;
            this.btn_novo_cadastro.Image = global::Health_Control.Properties.Resources.btn_novo_cadastro;
            this.btn_novo_cadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo_cadastro.Location = new System.Drawing.Point(855, 92);
            this.btn_novo_cadastro.Name = "btn_novo_cadastro";
            this.btn_novo_cadastro.Size = new System.Drawing.Size(141, 59);
            this.btn_novo_cadastro.TabIndex = 6;
            this.btn_novo_cadastro.Text = "  NOVO\r\n  CADASTRO";
            this.btn_novo_cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo_cadastro.UseVisualStyleBackColor = false;
            this.btn_novo_cadastro.Click += new System.EventHandler(this.button5_Click);
            // 
            // tela_relatorio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_acoes);
            this.Controls.Add(this.btn_filtro);
            this.Controls.Add(this.btn_novo_cadastro);
            this.Controls.Add(this.txt_controle);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tela_relatorio";
            this.Text = "Health Control";
            this.Load += new System.EventHandler(this.tela_relatorio_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_controle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_novo_cadastro;
        private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_acoes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_pesquisa;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewImageColumn Column7;
    }
}