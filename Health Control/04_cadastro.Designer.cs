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
            this.txt_nomecompleto = new System.Windows.Forms.Label();
            this.pnl_nomecompleto = new System.Windows.Forms.Panel();
            this.textbox_nomecompleto = new System.Windows.Forms.TextBox();
            this.pnl_divisor = new System.Windows.Forms.Panel();
            this.txt_email = new System.Windows.Forms.Label();
            this.pnl_email = new System.Windows.Forms.Panel();
            this.textbox_email = new System.Windows.Forms.TextBox();
            this.pnl_telefone = new System.Windows.Forms.Panel();
            this.textbox_telefone = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.Label();
            this.pnl_nascimento = new System.Windows.Forms.Panel();
            this.textbox_nascimento = new System.Windows.Forms.TextBox();
            this.txt_nascimento = new System.Windows.Forms.Label();
            this.pnl_funcao = new System.Windows.Forms.Panel();
            this.textbox_funcao = new System.Windows.Forms.TextBox();
            this.txt_funcao = new System.Windows.Forms.Label();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.img_icon_cadastro = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_nomecompleto.SuspendLayout();
            this.pnl_email.SuspendLayout();
            this.pnl_telefone.SuspendLayout();
            this.pnl_nascimento.SuspendLayout();
            this.pnl_funcao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon_cadastro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_cadastro
            // 
            this.txt_cadastro.AutoSize = true;
            this.txt_cadastro.BackColor = System.Drawing.Color.Transparent;
            this.txt_cadastro.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cadastro.Location = new System.Drawing.Point(290, 30);
            this.txt_cadastro.Name = "txt_cadastro";
            this.txt_cadastro.Size = new System.Drawing.Size(388, 33);
            this.txt_cadastro.TabIndex = 21;
            this.txt_cadastro.Text = "CADASTRO DE COLABORADOR";
            // 
            // txt_nomecompleto
            // 
            this.txt_nomecompleto.AutoSize = true;
            this.txt_nomecompleto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomecompleto.Location = new System.Drawing.Point(49, 90);
            this.txt_nomecompleto.Name = "txt_nomecompleto";
            this.txt_nomecompleto.Size = new System.Drawing.Size(123, 16);
            this.txt_nomecompleto.TabIndex = 5;
            this.txt_nomecompleto.Text = "NOME COMPLETO";
            this.txt_nomecompleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.txt_nomecompleto.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnl_nomecompleto
            // 
            this.pnl_nomecompleto.BackColor = System.Drawing.Color.White;
            this.pnl_nomecompleto.Controls.Add(this.textbox_nomecompleto);
            this.pnl_nomecompleto.Location = new System.Drawing.Point(52, 109);
            this.pnl_nomecompleto.Name = "pnl_nomecompleto";
            this.pnl_nomecompleto.Size = new System.Drawing.Size(401, 32);
            this.pnl_nomecompleto.TabIndex = 15;
            this.pnl_nomecompleto.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // textbox_nomecompleto
            // 
            this.textbox_nomecompleto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_nomecompleto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_nomecompleto.ForeColor = System.Drawing.Color.Gray;
            this.textbox_nomecompleto.Location = new System.Drawing.Point(12, 7);
            this.textbox_nomecompleto.Name = "textbox_nomecompleto";
            this.textbox_nomecompleto.Size = new System.Drawing.Size(378, 18);
            this.textbox_nomecompleto.TabIndex = 14;
            // 
            // pnl_divisor
            // 
            this.pnl_divisor.BackColor = System.Drawing.Color.Transparent;
            this.pnl_divisor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_divisor.Location = new System.Drawing.Point(500, 90);
            this.pnl_divisor.Name = "pnl_divisor";
            this.pnl_divisor.Size = new System.Drawing.Size(10, 407);
            this.pnl_divisor.TabIndex = 25;
            // 
            // txt_email
            // 
            this.txt_email.AutoSize = true;
            this.txt_email.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(49, 158);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(52, 16);
            this.txt_email.TabIndex = 29;
            this.txt_email.Text = "E-MAIL";
            this.txt_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_email
            // 
            this.pnl_email.BackColor = System.Drawing.Color.White;
            this.pnl_email.Controls.Add(this.textbox_email);
            this.pnl_email.Location = new System.Drawing.Point(52, 177);
            this.pnl_email.Name = "pnl_email";
            this.pnl_email.Size = new System.Drawing.Size(401, 32);
            this.pnl_email.TabIndex = 16;
            // 
            // textbox_email
            // 
            this.textbox_email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_email.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_email.ForeColor = System.Drawing.Color.Gray;
            this.textbox_email.Location = new System.Drawing.Point(10, 7);
            this.textbox_email.Name = "textbox_email";
            this.textbox_email.Size = new System.Drawing.Size(380, 18);
            this.textbox_email.TabIndex = 14;
            // 
            // pnl_telefone
            // 
            this.pnl_telefone.BackColor = System.Drawing.Color.White;
            this.pnl_telefone.Controls.Add(this.textbox_telefone);
            this.pnl_telefone.Location = new System.Drawing.Point(52, 246);
            this.pnl_telefone.Name = "pnl_telefone";
            this.pnl_telefone.Size = new System.Drawing.Size(197, 32);
            this.pnl_telefone.TabIndex = 30;
            // 
            // textbox_telefone
            // 
            this.textbox_telefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_telefone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_telefone.ForeColor = System.Drawing.Color.Gray;
            this.textbox_telefone.Location = new System.Drawing.Point(9, 7);
            this.textbox_telefone.Name = "textbox_telefone";
            this.textbox_telefone.Size = new System.Drawing.Size(179, 18);
            this.textbox_telefone.TabIndex = 14;
            // 
            // txt_telefone
            // 
            this.txt_telefone.AutoSize = true;
            this.txt_telefone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(49, 227);
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(75, 16);
            this.txt_telefone.TabIndex = 31;
            this.txt_telefone.Text = "TELEFONE";
            this.txt_telefone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_nascimento
            // 
            this.pnl_nascimento.BackColor = System.Drawing.Color.White;
            this.pnl_nascimento.Controls.Add(this.textbox_nascimento);
            this.pnl_nascimento.Location = new System.Drawing.Point(52, 316);
            this.pnl_nascimento.Name = "pnl_nascimento";
            this.pnl_nascimento.Size = new System.Drawing.Size(152, 32);
            this.pnl_nascimento.TabIndex = 32;
            // 
            // textbox_nascimento
            // 
            this.textbox_nascimento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_nascimento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_nascimento.ForeColor = System.Drawing.Color.Gray;
            this.textbox_nascimento.Location = new System.Drawing.Point(9, 7);
            this.textbox_nascimento.Name = "textbox_nascimento";
            this.textbox_nascimento.Size = new System.Drawing.Size(134, 18);
            this.textbox_nascimento.TabIndex = 14;
            // 
            // txt_nascimento
            // 
            this.txt_nascimento.AutoSize = true;
            this.txt_nascimento.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nascimento.Location = new System.Drawing.Point(49, 297);
            this.txt_nascimento.Name = "txt_nascimento";
            this.txt_nascimento.Size = new System.Drawing.Size(152, 16);
            this.txt_nascimento.TabIndex = 33;
            this.txt_nascimento.Text = "DATA DE NASCIMENTO";
            this.txt_nascimento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnl_funcao
            // 
            this.pnl_funcao.BackColor = System.Drawing.Color.White;
            this.pnl_funcao.Controls.Add(this.textbox_funcao);
            this.pnl_funcao.Location = new System.Drawing.Point(52, 385);
            this.pnl_funcao.Name = "pnl_funcao";
            this.pnl_funcao.Size = new System.Drawing.Size(152, 32);
            this.pnl_funcao.TabIndex = 34;
            // 
            // textbox_funcao
            // 
            this.textbox_funcao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_funcao.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_funcao.ForeColor = System.Drawing.Color.Gray;
            this.textbox_funcao.Location = new System.Drawing.Point(9, 7);
            this.textbox_funcao.Name = "textbox_funcao";
            this.textbox_funcao.Size = new System.Drawing.Size(134, 18);
            this.textbox_funcao.TabIndex = 14;
            // 
            // txt_funcao
            // 
            this.txt_funcao.AutoSize = true;
            this.txt_funcao.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_funcao.Location = new System.Drawing.Point(49, 366);
            this.txt_funcao.Name = "txt_funcao";
            this.txt_funcao.Size = new System.Drawing.Size(62, 16);
            this.txt_funcao.TabIndex = 35;
            this.txt_funcao.Text = "FUNÇÃO";
            this.txt_funcao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.BackColor = System.Drawing.Color.Green;
            this.btn_cadastrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastrar.ForeColor = System.Drawing.Color.White;
            this.btn_cadastrar.Image = global::Health_Control.Properties.Resources.btn_novo_cadastro;
            this.btn_cadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cadastrar.Location = new System.Drawing.Point(508, 513);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(141, 30);
            this.btn_cadastrar.TabIndex = 36;
            this.btn_cadastrar.Text = "CADASTRAR";
            this.btn_cadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastrar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Gray;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::Health_Control.Properties.Resources.btn_novo_cadastro;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.Location = new System.Drawing.Point(360, 513);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 30);
            this.btn_cancelar.TabIndex = 15;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // img_icon_cadastro
            // 
            this.img_icon_cadastro.Image = global::Health_Control.Properties.Resources.icon_cadastro;
            this.img_icon_cadastro.Location = new System.Drawing.Point(690, 26);
            this.img_icon_cadastro.Name = "img_icon_cadastro";
            this.img_icon_cadastro.Size = new System.Drawing.Size(44, 42);
            this.img_icon_cadastro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_icon_cadastro.TabIndex = 28;
            this.img_icon_cadastro.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "DESCRIÇÃO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Gray;
            this.textBox1.Location = new System.Drawing.Point(5, 7);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 84);
            this.textBox1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(210, 385);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(243, 100);
            this.panel1.TabIndex = 35;
            // 
            // tela_cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.pnl_funcao);
            this.Controls.Add(this.txt_funcao);
            this.Controls.Add(this.pnl_nascimento);
            this.Controls.Add(this.txt_nascimento);
            this.Controls.Add(this.pnl_telefone);
            this.Controls.Add(this.txt_telefone);
            this.Controls.Add(this.pnl_email);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.img_icon_cadastro);
            this.Controls.Add(this.txt_cadastro);
            this.Controls.Add(this.pnl_divisor);
            this.Controls.Add(this.pnl_nomecompleto);
            this.Controls.Add(this.txt_nomecompleto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "tela_cadastro";
            this.Text = "Health Control";
            this.pnl_nomecompleto.ResumeLayout(false);
            this.pnl_nomecompleto.PerformLayout();
            this.pnl_email.ResumeLayout(false);
            this.pnl_email.PerformLayout();
            this.pnl_telefone.ResumeLayout(false);
            this.pnl_telefone.PerformLayout();
            this.pnl_nascimento.ResumeLayout(false);
            this.pnl_nascimento.PerformLayout();
            this.pnl_funcao.ResumeLayout(false);
            this.pnl_funcao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_icon_cadastro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label txt_cadastro;
        private System.Windows.Forms.Label txt_nomecompleto;
        private System.Windows.Forms.Panel pnl_nomecompleto;
        private System.Windows.Forms.TextBox textbox_nomecompleto;
        private System.Windows.Forms.Panel pnl_divisor;
        private System.Windows.Forms.PictureBox img_icon_cadastro;
        private System.Windows.Forms.Label txt_email;
        private System.Windows.Forms.Panel pnl_email;
        private System.Windows.Forms.TextBox textbox_email;
        private System.Windows.Forms.Panel pnl_telefone;
        private System.Windows.Forms.TextBox textbox_telefone;
        private System.Windows.Forms.Label txt_telefone;
        private System.Windows.Forms.Panel pnl_nascimento;
        private System.Windows.Forms.TextBox textbox_nascimento;
        private System.Windows.Forms.Label txt_nascimento;
        private System.Windows.Forms.Panel pnl_funcao;
        private System.Windows.Forms.TextBox textbox_funcao;
        private System.Windows.Forms.Label txt_funcao;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_cadastrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
    }
}