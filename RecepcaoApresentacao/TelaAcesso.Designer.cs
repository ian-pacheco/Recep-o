namespace RecepcaoApresentacao {
    partial class TelaAcesso {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaAcesso));
            this.BtnEntrar = new System.Windows.Forms.Button();
            this.TxtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPrimeiroAcesso = new System.Windows.Forms.Button();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnEntrar
            // 
            this.BtnEntrar.Location = new System.Drawing.Point(47, 264);
            this.BtnEntrar.Name = "BtnEntrar";
            this.BtnEntrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnEntrar.Size = new System.Drawing.Size(120, 23);
            this.BtnEntrar.TabIndex = 3;
            this.BtnEntrar.Text = "Entrar";
            this.BtnEntrar.UseVisualStyleBackColor = true;
            this.BtnEntrar.Click += new System.EventHandler(this.BtnEntrar_Click);
            // 
            // TxtSenha
            // 
            this.TxtSenha.Location = new System.Drawing.Point(96, 223);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(214, 20);
            this.TxtSenha.TabIndex = 2;
            this.TxtSenha.TextChanged += new System.EventHandler(this.TxtSenha_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Login:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Senha:";
            // 
            // BtnPrimeiroAcesso
            // 
            this.BtnPrimeiroAcesso.Location = new System.Drawing.Point(189, 264);
            this.BtnPrimeiroAcesso.Name = "BtnPrimeiroAcesso";
            this.BtnPrimeiroAcesso.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.BtnPrimeiroAcesso.Size = new System.Drawing.Size(120, 23);
            this.BtnPrimeiroAcesso.TabIndex = 4;
            this.BtnPrimeiroAcesso.Text = "Primeiro Acesso";
            this.BtnPrimeiroAcesso.UseVisualStyleBackColor = true;
            this.BtnPrimeiroAcesso.Click += new System.EventHandler(this.BtnPrimeiroAcesso_Click);
            // 
            // TxtLogin
            // 
            this.TxtLogin.Location = new System.Drawing.Point(96, 190);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(214, 20);
            this.TxtLogin.TabIndex = 1;
            this.TxtLogin.TextChanged += new System.EventHandler(this.TxtLogin_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 19);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TelaAcesso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 341);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.BtnPrimeiroAcesso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.BtnEntrar);
            this.Name = "TelaAcesso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.TelaAcesso_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnEntrar;
        private System.Windows.Forms.TextBox TxtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPrimeiroAcesso;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}