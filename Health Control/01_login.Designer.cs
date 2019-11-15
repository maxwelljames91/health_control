namespace Health_Control
{
    partial class tela_login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_login));
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.textbox_senha = new System.Windows.Forms.TextBox();
            this.pnl_login = new System.Windows.Forms.Panel();
            this.img_user = new System.Windows.Forms.PictureBox();
            this.pnl_senha = new System.Windows.Forms.Panel();
            this.img_senha = new System.Windows.Forms.PictureBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.cbx_lembrar = new System.Windows.Forms.CheckBox();
            this.img_iconlogin = new System.Windows.Forms.PictureBox();
            this.img_medico = new System.Windows.Forms.PictureBox();
            this.img_healthcontrol = new System.Windows.Forms.PictureBox();
            this.txt_loginacesso = new System.Windows.Forms.Label();
            this.txt_bemvindo = new System.Windows.Forms.Label();
            this.btn_esqueceu = new System.Windows.Forms.Button();
            this.pnl_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).BeginInit();
            this.pnl_senha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_senha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_iconlogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_medico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_healthcontrol)).BeginInit();
            this.SuspendLayout();
            // 
            // textbox_login
            // 
            this.textbox_login.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_login.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_login.ForeColor = System.Drawing.Color.Gray;
            this.textbox_login.Location = new System.Drawing.Point(630, 260);
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.Size = new System.Drawing.Size(252, 25);
            this.textbox_login.TabIndex = 2;
            this.textbox_login.TextChanged += new System.EventHandler(this.text_nome_TextChanged);
            // 
            // textbox_senha
            // 
            this.textbox_senha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_senha.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_senha.ForeColor = System.Drawing.Color.Gray;
            this.textbox_senha.Location = new System.Drawing.Point(50, 10);
            this.textbox_senha.Name = "textbox_senha";
            this.textbox_senha.Size = new System.Drawing.Size(254, 25);
            this.textbox_senha.TabIndex = 3;
            this.textbox_senha.UseSystemPasswordChar = true;
            // 
            // pnl_login
            // 
            this.pnl_login.BackColor = System.Drawing.Color.White;
            this.pnl_login.Controls.Add(this.img_user);
            this.pnl_login.Location = new System.Drawing.Point(578, 249);
            this.pnl_login.Name = "pnl_login";
            this.pnl_login.Size = new System.Drawing.Size(318, 46);
            this.pnl_login.TabIndex = 11;
            // 
            // img_user
            // 
            this.img_user.Image = global::Health_Control.Properties.Resources.icon_user_3;
            this.img_user.Location = new System.Drawing.Point(6, 8);
            this.img_user.Name = "img_user";
            this.img_user.Size = new System.Drawing.Size(35, 28);
            this.img_user.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_user.TabIndex = 16;
            this.img_user.TabStop = false;
            // 
            // pnl_senha
            // 
            this.pnl_senha.BackColor = System.Drawing.Color.White;
            this.pnl_senha.Controls.Add(this.img_senha);
            this.pnl_senha.Controls.Add(this.textbox_senha);
            this.pnl_senha.Location = new System.Drawing.Point(578, 311);
            this.pnl_senha.Name = "pnl_senha";
            this.pnl_senha.Size = new System.Drawing.Size(318, 46);
            this.pnl_senha.TabIndex = 12;
            // 
            // img_senha
            // 
            this.img_senha.Image = global::Health_Control.Properties.Resources.icon_pass_3;
            this.img_senha.Location = new System.Drawing.Point(8, 8);
            this.img_senha.Name = "img_senha";
            this.img_senha.Size = new System.Drawing.Size(31, 28);
            this.img_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_senha.TabIndex = 17;
            this.img_senha.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.Red;
            this.btn_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(578, 372);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(318, 47);
            this.btn_login.TabIndex = 16;
            this.btn_login.Text = "LOGIN";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // cbx_lembrar
            // 
            this.cbx_lembrar.AutoSize = true;
            this.cbx_lembrar.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_lembrar.Location = new System.Drawing.Point(580, 428);
            this.cbx_lembrar.Name = "cbx_lembrar";
            this.cbx_lembrar.Size = new System.Drawing.Size(89, 20);
            this.cbx_lembrar.TabIndex = 16;
            this.cbx_lembrar.Text = "Lembrar-me";
            this.cbx_lembrar.UseVisualStyleBackColor = true;
            // 
            // img_iconlogin
            // 
            this.img_iconlogin.Image = global::Health_Control.Properties.Resources.user_login;
            this.img_iconlogin.Location = new System.Drawing.Point(678, 110);
            this.img_iconlogin.Name = "img_iconlogin";
            this.img_iconlogin.Size = new System.Drawing.Size(99, 79);
            this.img_iconlogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_iconlogin.TabIndex = 19;
            this.img_iconlogin.TabStop = false;
            // 
            // img_medico
            // 
            this.img_medico.BackColor = System.Drawing.Color.Transparent;
            this.img_medico.ErrorImage = global::Health_Control.Properties.Resources.medico_art_low;
            this.img_medico.Image = global::Health_Control.Properties.Resources.medico_art_low;
            this.img_medico.Location = new System.Drawing.Point(133, 190);
            this.img_medico.Name = "img_medico";
            this.img_medico.Size = new System.Drawing.Size(248, 285);
            this.img_medico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_medico.TabIndex = 15;
            this.img_medico.TabStop = false;
            // 
            // img_healthcontrol
            // 
            this.img_healthcontrol.BackColor = System.Drawing.Color.Transparent;
            this.img_healthcontrol.Image = global::Health_Control.Properties.Resources.logo_low;
            this.img_healthcontrol.Location = new System.Drawing.Point(122, 71);
            this.img_healthcontrol.Name = "img_healthcontrol";
            this.img_healthcontrol.Size = new System.Drawing.Size(243, 95);
            this.img_healthcontrol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_healthcontrol.TabIndex = 14;
            this.img_healthcontrol.TabStop = false;
            // 
            // txt_loginacesso
            // 
            this.txt_loginacesso.AutoSize = true;
            this.txt_loginacesso.BackColor = System.Drawing.Color.Transparent;
            this.txt_loginacesso.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loginacesso.Location = new System.Drawing.Point(639, 221);
            this.txt_loginacesso.Name = "txt_loginacesso";
            this.txt_loginacesso.Size = new System.Drawing.Size(195, 16);
            this.txt_loginacesso.TabIndex = 18;
            this.txt_loginacesso.Text = "Por favor, faça o login de acesso";
            // 
            // txt_bemvindo
            // 
            this.txt_bemvindo.AutoSize = true;
            this.txt_bemvindo.BackColor = System.Drawing.Color.Transparent;
            this.txt_bemvindo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bemvindo.Location = new System.Drawing.Point(615, 189);
            this.txt_bemvindo.Name = "txt_bemvindo";
            this.txt_bemvindo.Size = new System.Drawing.Size(243, 32);
            this.txt_bemvindo.TabIndex = 8;
            this.txt_bemvindo.Text = "Seja bem-vindo(a)!";
            this.txt_bemvindo.Click += new System.EventHandler(this.txt_bemvindo_Click);
            // 
            // btn_esqueceu
            // 
            this.btn_esqueceu.BackColor = System.Drawing.Color.Transparent;
            this.btn_esqueceu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_esqueceu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_esqueceu.FlatAppearance.BorderSize = 0;
            this.btn_esqueceu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_esqueceu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_esqueceu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_esqueceu.Font = new System.Drawing.Font("Arial Narrow", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_esqueceu.Location = new System.Drawing.Point(785, 425);
            this.btn_esqueceu.Name = "btn_esqueceu";
            this.btn_esqueceu.Size = new System.Drawing.Size(120, 25);
            this.btn_esqueceu.TabIndex = 20;
            this.btn_esqueceu.Text = "Esqueceu a senha?";
            this.btn_esqueceu.UseVisualStyleBackColor = false;
            // 
            // tela_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1008, 561);
            this.Controls.Add(this.btn_esqueceu);
            this.Controls.Add(this.img_iconlogin);
            this.Controls.Add(this.txt_loginacesso);
            this.Controls.Add(this.img_medico);
            this.Controls.Add(this.cbx_lembrar);
            this.Controls.Add(this.img_healthcontrol);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_bemvindo);
            this.Controls.Add(this.textbox_login);
            this.Controls.Add(this.pnl_login);
            this.Controls.Add(this.pnl_senha);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "tela_login";
            this.Text = "Health Control";
            this.Load += new System.EventHandler(this.tela_login_Load);
            this.pnl_login.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.img_user)).EndInit();
            this.pnl_senha.ResumeLayout(false);
            this.pnl_senha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_senha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_iconlogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_medico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_healthcontrol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.TextBox textbox_senha;
        private System.Windows.Forms.Panel pnl_login;
        private System.Windows.Forms.Panel pnl_senha;
        private System.Windows.Forms.PictureBox img_healthcontrol;
        private System.Windows.Forms.PictureBox img_medico;
        private System.Windows.Forms.PictureBox img_user;
        private System.Windows.Forms.PictureBox img_senha;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox cbx_lembrar;
        private System.Windows.Forms.PictureBox img_iconlogin;
        private System.Windows.Forms.Label txt_loginacesso;
        private System.Windows.Forms.Label txt_bemvindo;
        private System.Windows.Forms.Button btn_esqueceu;
    }
}

