namespace Health_Control
{
    partial class tela_cadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_cadastro));
            this.txt_cadastro = new System.Windows.Forms.Label();
            this.img_icon_cadastro = new System.Windows.Forms.PictureBox();
            this.txt_telefone = new System.Windows.Forms.Label();
            this.pnl_telefone = new System.Windows.Forms.Panel();
            this.maskedtextbox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.pnl_email = new System.Windows.Forms.Panel();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.txt_nascimento = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.Label();
            this.pnl_nomecompleto = new System.Windows.Forms.Panel();
            this.textbox_nomecompleto = new System.Windows.Forms.TextBox();
            this.txt_funcao = new System.Windows.Forms.Label();
            this.txt_nomecompleto = new System.Windows.Forms.Label();
            this.pnl_funcao = new System.Windows.Forms.Panel();
            this.textbox_funcao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.pnl_descricao_funcao = new System.Windows.Forms.Panel();
            this.textbox_descricao_funcao = new System.Windows.Forms.TextBox();
            this.dtp_nascimento = new System.Windows.Forms.DateTimePicker();
            this.txt_realizacao = new System.Windows.Forms.Label();
            this.txt_tipo = new System.Windows.Forms.Label();
            this.txt_exame = new System.Windows.Forms.Label();
            this.txt_periodo = new System.Windows.Forms.Label();
            this.txt_descricao_exame = new System.Windows.Forms.Label();
            this.pnl_exame = new System.Windows.Forms.Panel();
            this.textbox_exame = new System.Windows.Forms.TextBox();
            this.combobox_tipo = new System.Windows.Forms.ComboBox();
            this.dtp_realizacao = new System.Windows.Forms.DateTimePicker();
            this.pnl_descricao_exame = new System.Windows.Forms.Panel();
            this.textbox_descricao_exame = new System.Windows.Forms.TextBox();
            this.pnl_cadastro = new System.Windows.Forms.Panel();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.combobox_periodo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon_cadastro)).BeginInit();
            this.pnl_telefone.SuspendLayout();
            this.pnl_email.SuspendLayout();
            this.pnl_nomecompleto.SuspendLayout();
            this.pnl_funcao.SuspendLayout();
            this.pnl_descricao_funcao.SuspendLayout();
            this.pnl_exame.SuspendLayout();
            this.pnl_descricao_exame.SuspendLayout();
            this.pnl_cadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cadastro
            // 
            this.txt_cadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_cadastro.AutoSize = true;
            this.txt_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.txt_cadastro.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cadastro.Location = new System.Drawing.Point(290, 26);
            this.txt_cadastro.Name = "txt_cadastro";
            this.txt_cadastro.Size = new System.Drawing.Size(388, 33);
            this.txt_cadastro.TabIndex = 13;
            this.txt_cadastro.Text = "CADASTRO DE COLABORADOR";
            // 
            // img_icon_cadastro
            // 
            this.img_icon_cadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.img_icon_cadastro.Image = global::Health_Control.Properties.Resources.icon_cadastro;
            this.img_icon_cadastro.Location = new System.Drawing.Point(690, 22);
            this.img_icon_cadastro.Name = "img_icon_cadastro";
            this.img_icon_cadastro.Size = new System.Drawing.Size(44, 42);
            this.img_icon_cadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_icon_cadastro.TabIndex = 28;
            this.img_icon_cadastro.TabStop = false;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telefone.AutoSize = true;
            this.txt_telefone.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(87, 115);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(60, 14);
            this.txt_telefone.TabIndex = 8;
            this.txt_telefone.Text = "TELEFONE";
            this.txt_telefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_telefone
            // 
            this.pnl_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_telefone.BackColor = System.Drawing.Color.White;
            this.pnl_telefone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_telefone.Controls.Add(this.maskedtextbox_telefone);
            this.pnl_telefone.Location = new System.Drawing.Point(153, 111);
            this.pnl_telefone.Name = "pnl_telefone";
            this.pnl_telefone.Size = new System.Drawing.Size(93, 21);
            this.pnl_telefone.TabIndex = 2;
            // 
            // maskedtextbox_telefone
            // 
            this.maskedtextbox_telefone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedtextbox_telefone.BeepOnError = true;
            this.maskedtextbox_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedtextbox_telefone.Font = new System.Drawing.Font("Arial", 8.25F);
            this.maskedtextbox_telefone.ForeColor = System.Drawing.Color.DimGray;
            this.maskedtextbox_telefone.Location = new System.Drawing.Point(3, 3);
            this.maskedtextbox_telefone.Mask = "(99) 00000-0000";
            this.maskedtextbox_telefone.Name = "maskedtextbox_telefone";
            this.maskedtextbox_telefone.RejectInputOnFirstFailure = true;
            this.maskedtextbox_telefone.Size = new System.Drawing.Size(85, 13);
            this.maskedtextbox_telefone.TabIndex = 0;
            // 
            // pnl_email
            // 
            this.pnl_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_email.BackColor = System.Drawing.Color.White;
            this.pnl_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_email.Controls.Add(this.textbox_email);
            this.pnl_email.Location = new System.Drawing.Point(153, 74);
            this.pnl_email.Name = "pnl_email";
            this.pnl_email.Size = new System.Drawing.Size(309, 21);
            this.pnl_email.TabIndex = 1;
            // 
            // textbox_email
            // 
            this.textbox_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_email.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textbox_email.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_email.Location = new System.Drawing.Point(4, 3);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(300, 13);
            this.textbox_email.TabIndex = 0;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nascimento.AutoSize = true;
            this.txt_nascimento.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nascimento.Location = new System.Drawing.Point(22, 152);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(129, 14);
            this.txt_nascimento.TabIndex = 9;
            this.txt_nascimento.Text = "DATA DE NASCIMENTO*";
            this.txt_nascimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_email
            // 
            this.txt_email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_email.AutoSize = true;
            this.txt_email.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(102, 77);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(49, 14);
            this.txt_email.TabIndex = 7;
            this.txt_email.Text = "E-MAIL*";
            this.txt_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_nomecompleto
            // 
            this.pnl_nomecompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_nomecompleto.BackColor = System.Drawing.Color.White;
            this.pnl_nomecompleto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_nomecompleto.Controls.Add(this.textbox_nomecompleto);
            this.pnl_nomecompleto.Location = new System.Drawing.Point(153, 37);
            this.pnl_nomecompleto.Name = "pnl_nomecompleto";
            this.pnl_nomecompleto.Size = new System.Drawing.Size(309, 21);
            this.pnl_nomecompleto.TabIndex = 0;
            // 
            // textbox_nomecompleto
            // 
            this.textbox_nomecompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_nomecompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_nomecompleto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_nomecompleto.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_nomecompleto.Location = new System.Drawing.Point(4, 3);
            this.textbox_nomecompleto.Name = "textbox_nomecompleto";
            this.textbox_nomecompleto.Size = new System.Drawing.Size(300, 13);
            this.textbox_nomecompleto.TabIndex = 0;
            // 
            // txt_funcao
            // 
            this.txt_funcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_funcao.AutoSize = true;
            this.txt_funcao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcao.Location = new System.Drawing.Point(96, 188);
            this.txt_funcao.Name = "txt_funcao";
            this.txt_funcao.Size = new System.Drawing.Size(55, 14);
            this.txt_funcao.TabIndex = 10;
            this.txt_funcao.Text = "FUNÇÃO*";
            this.txt_funcao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_nomecompleto
            // 
            this.txt_nomecompleto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nomecompleto.AutoSize = true;
            this.txt_nomecompleto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomecompleto.Location = new System.Drawing.Point(45, 41);
            this.txt_nomecompleto.Name = "txt_nomecompleto";
            this.txt_nomecompleto.Size = new System.Drawing.Size(106, 14);
            this.txt_nomecompleto.TabIndex = 6;
            this.txt_nomecompleto.Text = "NOME COMPLETO*";
            this.txt_nomecompleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_funcao
            // 
            this.pnl_funcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_funcao.BackColor = System.Drawing.Color.White;
            this.pnl_funcao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_funcao.Controls.Add(this.textbox_funcao);
            this.pnl_funcao.Location = new System.Drawing.Point(153, 185);
            this.pnl_funcao.Name = "pnl_funcao";
            this.pnl_funcao.Size = new System.Drawing.Size(152, 21);
            this.pnl_funcao.TabIndex = 4;
            // 
            // textbox_funcao
            // 
            this.textbox_funcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_funcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_funcao.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textbox_funcao.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_funcao.Location = new System.Drawing.Point(3, 3);
            this.textbox_funcao.Name = "textbox_funcao";
            this.textbox_funcao.Size = new System.Drawing.Size(144, 13);
            this.textbox_funcao.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "DESCRIÇÃO\r\nDA FUNÇÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cadastrar.BackColor = System.Drawing.Color.Green;
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Image = global::Health_Control.Properties.Resources.btn_ok1;
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.Location = new System.Drawing.Point(475, 397);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(141, 30);
            this.btn_cadastrar.TabIndex = 11;
            this.btn_cadastrar.Text = " CADASTRAR";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // pnl_descricao_funcao
            // 
            this.pnl_descricao_funcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_descricao_funcao.BackColor = System.Drawing.Color.White;
            this.pnl_descricao_funcao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_descricao_funcao.Controls.Add(this.textbox_descricao_funcao);
            this.pnl_descricao_funcao.Location = new System.Drawing.Point(153, 223);
            this.pnl_descricao_funcao.Name = "pnl_descricao_funcao";
            this.pnl_descricao_funcao.Size = new System.Drawing.Size(243, 100);
            this.pnl_descricao_funcao.TabIndex = 5;
            // 
            // textbox_descricao_funcao
            // 
            this.textbox_descricao_funcao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_descricao_funcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_descricao_funcao.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textbox_descricao_funcao.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_descricao_funcao.Location = new System.Drawing.Point(3, 3);
            this.textbox_descricao_funcao.Multiline = true;
            this.textbox_descricao_funcao.Name = "textbox_descricao_funcao";
            this.textbox_descricao_funcao.Size = new System.Drawing.Size(235, 92);
            this.textbox_descricao_funcao.TabIndex = 0;
            // 
            // dtp_nascimento
            // 
            this.dtp_nascimento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_nascimento.Checked = false;
            this.dtp_nascimento.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtp_nascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nascimento.Location = new System.Drawing.Point(153, 149);
            this.dtp_nascimento.MaxDate = new System.DateTime(3019, 1, 1, 0, 0, 0, 0);
            this.dtp_nascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_nascimento.Name = "dtp_nascimento";
            this.dtp_nascimento.Size = new System.Drawing.Size(109, 20);
            this.dtp_nascimento.TabIndex = 3;
            // 
            // txt_realizacao
            // 
            this.txt_realizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_realizacao.AutoSize = true;
            this.txt_realizacao.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_realizacao.Location = new System.Drawing.Point(492, 115);
            this.txt_realizacao.Name = "txt_realizacao";
            this.txt_realizacao.Size = new System.Drawing.Size(128, 14);
            this.txt_realizacao.TabIndex = 14;
            this.txt_realizacao.Text = "DATA DE REALIZAÇÃO*";
            this.txt_realizacao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_tipo
            // 
            this.txt_tipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_tipo.AutoSize = true;
            this.txt_tipo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipo.Location = new System.Drawing.Point(584, 77);
            this.txt_tipo.Name = "txt_tipo";
            this.txt_tipo.Size = new System.Drawing.Size(36, 14);
            this.txt_tipo.TabIndex = 13;
            this.txt_tipo.Text = "TIPO*";
            this.txt_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_exame
            // 
            this.txt_exame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_exame.AutoSize = true;
            this.txt_exame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_exame.Location = new System.Drawing.Point(572, 41);
            this.txt_exame.Name = "txt_exame";
            this.txt_exame.Size = new System.Drawing.Size(48, 14);
            this.txt_exame.TabIndex = 12;
            this.txt_exame.Text = "EXAME*";
            this.txt_exame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_periodo
            // 
            this.txt_periodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_periodo.AutoSize = true;
            this.txt_periodo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_periodo.Location = new System.Drawing.Point(559, 152);
            this.txt_periodo.Name = "txt_periodo";
            this.txt_periodo.Size = new System.Drawing.Size(57, 14);
            this.txt_periodo.TabIndex = 15;
            this.txt_periodo.Text = "PERÍODO*";
            this.txt_periodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_descricao_exame
            // 
            this.txt_descricao_exame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_descricao_exame.AutoSize = true;
            this.txt_descricao_exame.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao_exame.Location = new System.Drawing.Point(547, 193);
            this.txt_descricao_exame.Name = "txt_descricao_exame";
            this.txt_descricao_exame.Size = new System.Drawing.Size(69, 28);
            this.txt_descricao_exame.TabIndex = 16;
            this.txt_descricao_exame.Text = "DESCRIÇÃO\r\nDO EXAME";
            this.txt_descricao_exame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_exame
            // 
            this.pnl_exame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_exame.BackColor = System.Drawing.Color.White;
            this.pnl_exame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_exame.Controls.Add(this.textbox_exame);
            this.pnl_exame.Location = new System.Drawing.Point(622, 37);
            this.pnl_exame.Name = "pnl_exame";
            this.pnl_exame.Size = new System.Drawing.Size(197, 21);
            this.pnl_exame.TabIndex = 6;
            // 
            // textbox_exame
            // 
            this.textbox_exame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_exame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_exame.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textbox_exame.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_exame.Location = new System.Drawing.Point(3, 3);
            this.textbox_exame.Name = "textbox_exame";
            this.textbox_exame.Size = new System.Drawing.Size(189, 13);
            this.textbox_exame.TabIndex = 0;
            // 
            // combobox_tipo
            // 
            this.combobox_tipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combobox_tipo.Font = new System.Drawing.Font("Arial", 8.25F);
            this.combobox_tipo.ForeColor = System.Drawing.Color.Black;
            this.combobox_tipo.FormattingEnabled = true;
            this.combobox_tipo.Items.AddRange(new object[] {
            "Admissional",
            "Demissional",
            "Periódico",
            "Mudança de Função"});
            this.combobox_tipo.Location = new System.Drawing.Point(622, 74);
            this.combobox_tipo.Name = "combobox_tipo";
            this.combobox_tipo.Size = new System.Drawing.Size(120, 22);
            this.combobox_tipo.TabIndex = 7;
            this.combobox_tipo.Text = "[Selecione]";
            // 
            // dtp_realizacao
            // 
            this.dtp_realizacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_realizacao.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dtp_realizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_realizacao.Location = new System.Drawing.Point(622, 111);
            this.dtp_realizacao.MaxDate = new System.DateTime(3019, 1, 1, 0, 0, 0, 0);
            this.dtp_realizacao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtp_realizacao.Name = "dtp_realizacao";
            this.dtp_realizacao.Size = new System.Drawing.Size(109, 20);
            this.dtp_realizacao.TabIndex = 8;
            // 
            // pnl_descricao_exame
            // 
            this.pnl_descricao_exame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_descricao_exame.BackColor = System.Drawing.Color.White;
            this.pnl_descricao_exame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_descricao_exame.Controls.Add(this.textbox_descricao_exame);
            this.pnl_descricao_exame.Location = new System.Drawing.Point(622, 189);
            this.pnl_descricao_exame.Name = "pnl_descricao_exame";
            this.pnl_descricao_exame.Size = new System.Drawing.Size(243, 100);
            this.pnl_descricao_exame.TabIndex = 10;
            // 
            // textbox_descricao_exame
            // 
            this.textbox_descricao_exame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textbox_descricao_exame.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_descricao_exame.Font = new System.Drawing.Font("Arial", 8.25F);
            this.textbox_descricao_exame.ForeColor = System.Drawing.Color.DimGray;
            this.textbox_descricao_exame.Location = new System.Drawing.Point(3, 3);
            this.textbox_descricao_exame.Multiline = true;
            this.textbox_descricao_exame.Name = "textbox_descricao_exame";
            this.textbox_descricao_exame.Size = new System.Drawing.Size(235, 92);
            this.textbox_descricao_exame.TabIndex = 0;
            // 
            // pnl_cadastro
            // 
            this.pnl_cadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnl_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.pnl_cadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_cadastro.Controls.Add(this.combobox_periodo);
            this.pnl_cadastro.Controls.Add(this.btn_cancelar);
            this.pnl_cadastro.Controls.Add(this.pnl_descricao_exame);
            this.pnl_cadastro.Controls.Add(this.dtp_realizacao);
            this.pnl_cadastro.Controls.Add(this.combobox_tipo);
            this.pnl_cadastro.Controls.Add(this.pnl_exame);
            this.pnl_cadastro.Controls.Add(this.txt_descricao_exame);
            this.pnl_cadastro.Controls.Add(this.txt_periodo);
            this.pnl_cadastro.Controls.Add(this.txt_exame);
            this.pnl_cadastro.Controls.Add(this.txt_tipo);
            this.pnl_cadastro.Controls.Add(this.txt_realizacao);
            this.pnl_cadastro.Controls.Add(this.dtp_nascimento);
            this.pnl_cadastro.Controls.Add(this.pnl_descricao_funcao);
            this.pnl_cadastro.Controls.Add(this.btn_cadastrar);
            this.pnl_cadastro.Controls.Add(this.label1);
            this.pnl_cadastro.Controls.Add(this.pnl_funcao);
            this.pnl_cadastro.Controls.Add(this.txt_nomecompleto);
            this.pnl_cadastro.Controls.Add(this.txt_funcao);
            this.pnl_cadastro.Controls.Add(this.pnl_nomecompleto);
            this.pnl_cadastro.Controls.Add(this.txt_email);
            this.pnl_cadastro.Controls.Add(this.txt_nascimento);
            this.pnl_cadastro.Controls.Add(this.pnl_email);
            this.pnl_cadastro.Controls.Add(this.pnl_telefone);
            this.pnl_cadastro.Controls.Add(this.txt_telefone);
            this.pnl_cadastro.Location = new System.Drawing.Point(32, 86);
            this.pnl_cadastro.Name = "pnl_cadastro";
            this.pnl_cadastro.Size = new System.Drawing.Size(944, 448);
            this.pnl_cadastro.TabIndex = 0;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.Gray;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::Health_Control.Properties.Resources.btn_cancel;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.Location = new System.Drawing.Point(328, 397);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 30);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "  CANCELAR";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // combobox_periodo
            // 
            this.combobox_periodo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combobox_periodo.Font = new System.Drawing.Font("Arial", 8.25F);
            this.combobox_periodo.ForeColor = System.Drawing.Color.Black;
            this.combobox_periodo.FormattingEnabled = true;
            this.combobox_periodo.Items.AddRange(new object[] {
            "06 meses",
            "1 ano",
            "2 anos"});
            this.combobox_periodo.Location = new System.Drawing.Point(622, 147);
            this.combobox_periodo.Name = "combobox_periodo";
            this.combobox_periodo.Size = new System.Drawing.Size(120, 22);
            this.combobox_periodo.TabIndex = 17;
            this.combobox_periodo.Text = "[Selecione]";
            // 
            // tela_cadastro
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.img_icon_cadastro);
            this.Controls.Add(this.txt_cadastro);
            this.Controls.Add(this.pnl_cadastro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Health Control";
            ((System.ComponentModel.ISupportInitialize)(this.img_icon_cadastro)).EndInit();
            this.pnl_telefone.ResumeLayout(false);
            this.pnl_telefone.PerformLayout();
            this.pnl_email.ResumeLayout(false);
            this.pnl_email.PerformLayout();
            this.pnl_nomecompleto.ResumeLayout(false);
            this.pnl_nomecompleto.PerformLayout();
            this.pnl_funcao.ResumeLayout(false);
            this.pnl_funcao.PerformLayout();
            this.pnl_descricao_funcao.ResumeLayout(false);
            this.pnl_descricao_funcao.PerformLayout();
            this.pnl_exame.ResumeLayout(false);
            this.pnl_exame.PerformLayout();
            this.pnl_descricao_exame.ResumeLayout(false);
            this.pnl_descricao_exame.PerformLayout();
            this.pnl_cadastro.ResumeLayout(false);
            this.pnl_cadastro.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_cadastro;
        private System.Windows.Forms.PictureBox img_icon_cadastro;
        private System.Windows.Forms.Label txt_telefone;
        private System.Windows.Forms.Panel pnl_telefone;
        private System.Windows.Forms.Panel pnl_email;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.Label txt_nascimento;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Panel pnl_nomecompleto;
        private System.Windows.Forms.TextBox textbox_nomecompleto;
        private System.Windows.Forms.Label txt_funcao;
        private System.Windows.Forms.Label txt_nomecompleto;
        private System.Windows.Forms.Panel pnl_funcao;
        private System.Windows.Forms.TextBox textbox_funcao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Panel pnl_descricao_funcao;
        private System.Windows.Forms.TextBox textbox_descricao_funcao;
        private System.Windows.Forms.DateTimePicker dtp_nascimento;
        private System.Windows.Forms.Label txt_realizacao;
        private System.Windows.Forms.Label txt_tipo;
        private System.Windows.Forms.Label txt_exame;
        private System.Windows.Forms.Label txt_periodo;
        private System.Windows.Forms.Label txt_descricao_exame;
        private System.Windows.Forms.Panel pnl_exame;
        private System.Windows.Forms.TextBox textbox_exame;
        private System.Windows.Forms.ComboBox combobox_tipo;
        private System.Windows.Forms.DateTimePicker dtp_realizacao;
        private System.Windows.Forms.Panel pnl_descricao_exame;
        private System.Windows.Forms.TextBox textbox_descricao_exame;
        private System.Windows.Forms.Panel pnl_cadastro;
        private System.Windows.Forms.MaskedTextBox maskedtextbox_telefone;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox combobox_periodo;
    }
}