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
            this.txt_sejabemvindo = new System.Windows.Forms.Label();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.txt_data = new System.Windows.Forms.Label();
            this.txt_data_hoje = new System.Windows.Forms.Label();
            this.pnl_pesquisa = new System.Windows.Forms.Panel();
            this.textbox_pesquisa = new System.Windows.Forms.TextBox();
            this.dgv_relatorio = new System.Windows.Forms.DataGridView();
            this.btn_logoff = new System.Windows.Forms.Button();
            this.btn_config = new System.Windows.Forms.Button();
            this.btn_novo_cadastro = new System.Windows.Forms.Button();
            this.btn_filtro = new System.Windows.Forms.Button();
            this.btn_pesquisar = new System.Windows.Forms.Button();
            this.btn_acoes = new System.Windows.Forms.Button();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pnl_data.SuspendLayout();
            this.pnl_pesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_controle
            // 
            this.txt_controle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_controle.AutoSize = true;
            this.txt_controle.BackColor = System.Drawing.Color.Transparent;
            this.txt_controle.Font = new System.Drawing.Font("Arial Narrow", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_controle.Location = new System.Drawing.Point(14, 56);
            this.txt_controle.Name = "txt_controle";
            this.txt_controle.Size = new System.Drawing.Size(336, 20);
            this.txt_controle.TabIndex = 9;
            this.txt_controle.Text = "RELATÓRIO DO CONTROLE DE EXAMES DE SAÚDE";
            // 
            // txt_sejabemvindo
            // 
            this.txt_sejabemvindo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_sejabemvindo.AutoSize = true;
            this.txt_sejabemvindo.BackColor = System.Drawing.Color.Transparent;
            this.txt_sejabemvindo.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sejabemvindo.ForeColor = System.Drawing.Color.Black;
            this.txt_sejabemvindo.Location = new System.Drawing.Point(14, 18);
            this.txt_sejabemvindo.Name = "txt_sejabemvindo";
            this.txt_sejabemvindo.Size = new System.Drawing.Size(190, 27);
            this.txt_sejabemvindo.TabIndex = 10;
            this.txt_sejabemvindo.Text = "BEM-VINDO(A), ";
            // 
            // pnl_data
            // 
            this.pnl_data.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_data.BackColor = System.Drawing.Color.Khaki;
            this.pnl_data.Controls.Add(this.txt_data);
            this.pnl_data.Controls.Add(this.txt_data_hoje);
            this.pnl_data.Location = new System.Drawing.Point(585, 13);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(108, 69);
            this.pnl_data.TabIndex = 11;
            // 
            // txt_data
            // 
            this.txt_data.AutoSize = true;
            this.txt_data.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold);
            this.txt_data.Location = new System.Drawing.Point(12, 34);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(42, 22);
            this.txt_data.TabIndex = 13;
            this.txt_data.Text = "Data";
            // 
            // txt_data_hoje
            // 
            this.txt_data_hoje.AutoSize = true;
            this.txt_data_hoje.BackColor = System.Drawing.Color.Khaki;
            this.txt_data_hoje.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_data_hoje.Location = new System.Drawing.Point(11, 11);
            this.txt_data_hoje.Name = "txt_data_hoje";
            this.txt_data_hoje.Size = new System.Drawing.Size(86, 16);
            this.txt_data_hoje.TabIndex = 12;
            this.txt_data_hoje.Text = "DATA DE HOJE";
            // 
            // pnl_pesquisa
            // 
            this.pnl_pesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_pesquisa.BackColor = System.Drawing.Color.White;
            this.pnl_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_pesquisa.Controls.Add(this.btn_pesquisar);
            this.pnl_pesquisa.Controls.Add(this.textbox_pesquisa);
            this.pnl_pesquisa.Location = new System.Drawing.Point(706, 13);
            this.pnl_pesquisa.Name = "pnl_pesquisa";
            this.pnl_pesquisa.Size = new System.Drawing.Size(290, 30);
            this.pnl_pesquisa.TabIndex = 1;
            // 
            // textbox_pesquisa
            // 
            this.textbox_pesquisa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_pesquisa.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_pesquisa.ForeColor = System.Drawing.Color.Gray;
            this.textbox_pesquisa.Location = new System.Drawing.Point(8, 6);
            this.textbox_pesquisa.Name = "textbox_pesquisa";
            this.textbox_pesquisa.Size = new System.Drawing.Size(237, 15);
            this.textbox_pesquisa.TabIndex = 0;
            this.textbox_pesquisa.Text = "Pesquisar";
            this.textbox_pesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_pesquisa_KeyDown);
            this.textbox_pesquisa.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textbox_pesquisa_KeyUp);
            // 
            // dgv_relatorio
            // 
            this.dgv_relatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgv_relatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_relatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewImageColumn1});
            this.dgv_relatorio.Location = new System.Drawing.Point(15, 92);
            this.dgv_relatorio.Name = "dgv_relatorio";
            this.dgv_relatorio.Size = new System.Drawing.Size(832, 457);
            this.dgv_relatorio.TabIndex = 0;
            // 
            // btn_logoff
            // 
            this.btn_logoff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_logoff.BackColor = System.Drawing.Color.Red;
            this.btn_logoff.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_logoff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logoff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logoff.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_logoff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logoff.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logoff.ForeColor = System.Drawing.Color.White;
            this.btn_logoff.Image = global::Health_Control.Properties.Resources.btn_logoff;
            this.btn_logoff.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_logoff.Location = new System.Drawing.Point(855, 519);
            this.btn_logoff.Name = "btn_logoff";
            this.btn_logoff.Size = new System.Drawing.Size(141, 30);
            this.btn_logoff.TabIndex = 6;
            this.btn_logoff.Text = "     LOGOFF";
            this.btn_logoff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_logoff.UseVisualStyleBackColor = false;
            this.btn_logoff.Click += new System.EventHandler(this.btn_logoff_Click);
            // 
            // btn_config
            // 
            this.btn_config.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_config.BackColor = System.Drawing.Color.Gray;
            this.btn_config.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_config.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_config.Font = new System.Drawing.Font("Arial Black", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_config.ForeColor = System.Drawing.Color.White;
            this.btn_config.Image = global::Health_Control.Properties.Resources.btn_config;
            this.btn_config.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_config.Location = new System.Drawing.Point(855, 479);
            this.btn_config.Name = "btn_config";
            this.btn_config.Size = new System.Drawing.Size(141, 30);
            this.btn_config.TabIndex = 5;
            this.btn_config.Text = " CONFIGURAÇÕES";
            this.btn_config.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_config.UseVisualStyleBackColor = false;
            // 
            // btn_novo_cadastro
            // 
            this.btn_novo_cadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_novo_cadastro.TabIndex = 4;
            this.btn_novo_cadastro.Text = "  NOVO\r\n  CADASTRO";
            this.btn_novo_cadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_novo_cadastro.UseVisualStyleBackColor = false;
            this.btn_novo_cadastro.Click += new System.EventHandler(this.btn_novo_cadastro_Click);
            // 
            // btn_filtro
            // 
            this.btn_filtro.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_filtro.TabIndex = 2;
            this.btn_filtro.Text = "   FILTRAGEM";
            this.btn_filtro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtro.UseVisualStyleBackColor = false;
            // 
            // btn_pesquisar
            // 
            this.btn_pesquisar.BackgroundImage = global::Health_Control.Properties.Resources.btn_pesquisa;
            this.btn_pesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_pesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pesquisar.FlatAppearance.BorderSize = 0;
            this.btn_pesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pesquisar.Location = new System.Drawing.Point(250, 0);
            this.btn_pesquisar.Name = "btn_pesquisar";
            this.btn_pesquisar.Size = new System.Drawing.Size(38, 29);
            this.btn_pesquisar.TabIndex = 1;
            this.btn_pesquisar.UseVisualStyleBackColor = true;
            // 
            // btn_acoes
            // 
            this.btn_acoes.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_acoes.TabIndex = 3;
            this.btn_acoes.Text = "       AÇÕES";
            this.btn_acoes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_acoes.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewCheckBoxColumn1.HeaderText = "SELEC.";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn1.HeaderText = "COLABORADOR";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "FUNÇÃO";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "TIPO DE EXAME";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "DATA DE REALIZAÇÃO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "PRÓXIMO EXAME";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "STATUS";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Width = 80;
            // 
            // tela_relatorio
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.dgv_relatorio);
            this.Controls.Add(this.btn_logoff);
            this.Controls.Add(this.btn_config);
            this.Controls.Add(this.btn_novo_cadastro);
            this.Controls.Add(this.btn_filtro);
            this.Controls.Add(this.pnl_pesquisa);
            this.Controls.Add(this.txt_sejabemvindo);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.btn_acoes);
            this.Controls.Add(this.txt_controle);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_relatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Control";
            this.Load += new System.EventHandler(this.tela_relatorio_Load);
            this.pnl_data.ResumeLayout(false);
            this.pnl_data.PerformLayout();
            this.pnl_pesquisa.ResumeLayout(false);
            this.pnl_pesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_controle;
        private System.Windows.Forms.Label txt_sejabemvindo;
        private System.Windows.Forms.Button btn_acoes;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.Label txt_data_hoje;
        private System.Windows.Forms.Panel pnl_pesquisa;
        private System.Windows.Forms.TextBox textbox_pesquisa;
        private System.Windows.Forms.Button btn_filtro;
        private System.Windows.Forms.Button btn_pesquisar;
        private System.Windows.Forms.Button btn_novo_cadastro;
        private System.Windows.Forms.Button btn_config;
        private System.Windows.Forms.Button btn_logoff;
        private System.Windows.Forms.DataGridView dgv_relatorio;
        private System.Windows.Forms.Label txt_data;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}