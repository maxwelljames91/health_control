namespace Health_Control
{
    partial class tela_filtragem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tela_filtragem));
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.txt_porexame = new System.Windows.Forms.Label();
            this.txt_pordata = new System.Windows.Forms.Label();
            this.txt_porstatus = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combobox_tipo = new System.Windows.Forms.ComboBox();
            this.txt_ate = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_cancelar.BackColor = System.Drawing.Color.Gray;
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::Health_Control.Properties.Resources.btn_cancel;
            this.btn_cancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.Location = new System.Drawing.Point(149, 293);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(141, 30);
            this.btn_cancelar.TabIndex = 7;
            this.btn_cancelar.Text = "  CANCELAR";
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_filtrar.BackColor = System.Drawing.Color.Green;
            this.btn_filtrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_filtrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_filtrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtrar.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.ForeColor = System.Drawing.Color.White;
            this.btn_filtrar.Image = global::Health_Control.Properties.Resources.btn_ok1;
            this.btn_filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_filtrar.Location = new System.Drawing.Point(296, 293);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(141, 30);
            this.btn_filtrar.TabIndex = 6;
            this.btn_filtrar.Text = "     FILTRAR";
            this.btn_filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_filtrar.UseVisualStyleBackColor = false;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // txt_porexame
            // 
            this.txt_porexame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_porexame.AutoSize = true;
            this.txt_porexame.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.txt_porexame.Location = new System.Drawing.Point(76, 37);
            this.txt_porexame.Name = "txt_porexame";
            this.txt_porexame.Size = new System.Drawing.Size(51, 10);
            this.txt_porexame.TabIndex = 15;
            this.txt_porexame.Text = "POR EXAME";
            this.txt_porexame.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_pordata
            // 
            this.txt_pordata.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_pordata.AutoSize = true;
            this.txt_pordata.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.txt_pordata.Location = new System.Drawing.Point(84, 120);
            this.txt_pordata.Name = "txt_pordata";
            this.txt_pordata.Size = new System.Drawing.Size(43, 10);
            this.txt_pordata.TabIndex = 16;
            this.txt_pordata.Text = "POR DATA";
            this.txt_pordata.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_porstatus
            // 
            this.txt_porstatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_porstatus.AutoSize = true;
            this.txt_porstatus.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold);
            this.txt_porstatus.Location = new System.Drawing.Point(74, 206);
            this.txt_porstatus.Name = "txt_porstatus";
            this.txt_porstatus.Size = new System.Drawing.Size(53, 10);
            this.txt_porstatus.TabIndex = 17;
            this.txt_porstatus.Text = "POR STATUS";
            this.txt_porstatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackgroundImage = global::Health_Control.Properties.Resources.img_green;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Location = new System.Drawing.Point(149, 240);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(71, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "               ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackgroundImage = global::Health_Control.Properties.Resources.img_yellow;
            this.checkBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox2.Location = new System.Drawing.Point(258, 240);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox2.Size = new System.Drawing.Size(71, 19);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "               ";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.checkBox3.AutoSize = true;
            this.checkBox3.BackgroundImage = global::Health_Control.Properties.Resources.img_red;
            this.checkBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.checkBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox3.Location = new System.Drawing.Point(366, 240);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox3.Size = new System.Drawing.Size(71, 19);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "               ";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(149, 156);
            this.dateTimePicker1.MaxDate = new System.DateTime(3019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // combobox_tipo
            // 
            this.combobox_tipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.combobox_tipo.Font = new System.Drawing.Font("Arial", 8.25F);
            this.combobox_tipo.ForeColor = System.Drawing.Color.Black;
            this.combobox_tipo.FormattingEnabled = true;
            this.combobox_tipo.Location = new System.Drawing.Point(149, 71);
            this.combobox_tipo.Name = "combobox_tipo";
            this.combobox_tipo.Size = new System.Drawing.Size(288, 22);
            this.combobox_tipo.TabIndex = 0;
            this.combobox_tipo.Text = "[Selecione]";
            // 
            // txt_ate
            // 
            this.txt_ate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ate.AutoSize = true;
            this.txt_ate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ate.Location = new System.Drawing.Point(279, 159);
            this.txt_ate.Name = "txt_ate";
            this.txt_ate.Size = new System.Drawing.Size(27, 14);
            this.txt_ate.TabIndex = 24;
            this.txt_ate.Text = "ATÉ";
            this.txt_ate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateTimePicker2.Font = new System.Drawing.Font("Arial", 8.25F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(322, 156);
            this.dateTimePicker2.MaxDate = new System.DateTime(3019, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(115, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 14);
            this.label4.TabIndex = 26;
            this.label4.Text = "_____________________________________________________";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(136, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(325, 14);
            this.label5.TabIndex = 27;
            this.label5.Text = "_____________________________________________________";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(136, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(325, 14);
            this.label6.TabIndex = 28;
            this.label6.Text = "_____________________________________________________";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tela_filtragem
            // 
            this.AcceptButton = this.btn_filtrar;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CancelButton = this.btn_cancelar;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.txt_ate);
            this.Controls.Add(this.combobox_tipo);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.txt_porstatus);
            this.Controls.Add(this.txt_pordata);
            this.Controls.Add(this.txt_porexame);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_filtrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "tela_filtragem";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtragem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Label txt_porexame;
        private System.Windows.Forms.Label txt_pordata;
        private System.Windows.Forms.Label txt_porstatus;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combobox_tipo;
        private System.Windows.Forms.Label txt_ate;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}