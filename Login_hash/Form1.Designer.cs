namespace Login_hash
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Login = new System.Windows.Forms.TabPage();
            this.bntLogin = new System.Windows.Forms.Button();
            this.txtSenhaLogin = new System.Windows.Forms.TextBox();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.Registro = new System.Windows.Forms.TabPage();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.txbConfirmar = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblConfirmar = new System.Windows.Forms.Label();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.txbSenhaRegistro = new System.Windows.Forms.TextBox();
            this.txbUsuarioRegistro = new System.Windows.Forms.TextBox();
            this.lblSenhaRegistro = new System.Windows.Forms.Label();
            this.lblUsuarioRegistro = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Registro.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Login);
            this.tabControl1.Controls.Add(this.Registro);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(919, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // Login
            // 
            this.Login.Controls.Add(this.bntLogin);
            this.Login.Controls.Add(this.txtSenhaLogin);
            this.Login.Controls.Add(this.txtUsuarioLogin);
            this.Login.Controls.Add(this.lblSenha);
            this.Login.Controls.Add(this.lblUsuario);
            this.Login.Location = new System.Drawing.Point(4, 22);
            this.Login.Name = "Login";
            this.Login.Padding = new System.Windows.Forms.Padding(3);
            this.Login.Size = new System.Drawing.Size(911, 460);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // bntLogin
            // 
            this.bntLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntLogin.Location = new System.Drawing.Point(362, 298);
            this.bntLogin.Name = "bntLogin";
            this.bntLogin.Size = new System.Drawing.Size(84, 54);
            this.bntLogin.TabIndex = 4;
            this.bntLogin.Text = "Login";
            this.bntLogin.UseVisualStyleBackColor = true;
            this.bntLogin.Click += new System.EventHandler(this.bntLogin_Click);
            // 
            // txtSenhaLogin
            // 
            this.txtSenhaLogin.Location = new System.Drawing.Point(271, 260);
            this.txtSenhaLogin.Name = "txtSenhaLogin";
            this.txtSenhaLogin.PasswordChar = '*';
            this.txtSenhaLogin.Size = new System.Drawing.Size(284, 20);
            this.txtSenhaLogin.TabIndex = 3;
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(271, 207);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(284, 20);
            this.txtUsuarioLogin.TabIndex = 2;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(187, 260);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(187, 207);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário";
            // 
            // Registro
            // 
            this.Registro.Controls.Add(this.txbEmail);
            this.Registro.Controls.Add(this.txbConfirmar);
            this.Registro.Controls.Add(this.lblEmail);
            this.Registro.Controls.Add(this.lblConfirmar);
            this.Registro.Controls.Add(this.btnRegistro);
            this.Registro.Controls.Add(this.txbSenhaRegistro);
            this.Registro.Controls.Add(this.txbUsuarioRegistro);
            this.Registro.Controls.Add(this.lblSenhaRegistro);
            this.Registro.Controls.Add(this.lblUsuarioRegistro);
            this.Registro.Location = new System.Drawing.Point(4, 22);
            this.Registro.Name = "Registro";
            this.Registro.Padding = new System.Windows.Forms.Padding(3);
            this.Registro.Size = new System.Drawing.Size(911, 460);
            this.Registro.TabIndex = 1;
            this.Registro.Text = "Registro";
            this.Registro.UseVisualStyleBackColor = true;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(355, 274);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(284, 20);
            this.txbEmail.TabIndex = 13;
            // 
            // txbConfirmar
            // 
            this.txbConfirmar.Location = new System.Drawing.Point(355, 239);
            this.txbConfirmar.Name = "txbConfirmar";
            this.txbConfirmar.PasswordChar = '*';
            this.txbConfirmar.Size = new System.Drawing.Size(284, 20);
            this.txbConfirmar.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(271, 272);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(48, 20);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblConfirmar
            // 
            this.lblConfirmar.AutoSize = true;
            this.lblConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmar.Location = new System.Drawing.Point(271, 239);
            this.lblConfirmar.Name = "lblConfirmar";
            this.lblConfirmar.Size = new System.Drawing.Size(78, 20);
            this.lblConfirmar.TabIndex = 10;
            this.lblConfirmar.Text = "Confirmar";
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(434, 311);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(84, 54);
            this.btnRegistro.TabIndex = 9;
            this.btnRegistro.Text = "Registro";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // txbSenhaRegistro
            // 
            this.txbSenhaRegistro.Location = new System.Drawing.Point(355, 201);
            this.txbSenhaRegistro.Name = "txbSenhaRegistro";
            this.txbSenhaRegistro.PasswordChar = '*';
            this.txbSenhaRegistro.Size = new System.Drawing.Size(284, 20);
            this.txbSenhaRegistro.TabIndex = 8;
            // 
            // txbUsuarioRegistro
            // 
            this.txbUsuarioRegistro.Location = new System.Drawing.Point(355, 169);
            this.txbUsuarioRegistro.Name = "txbUsuarioRegistro";
            this.txbUsuarioRegistro.Size = new System.Drawing.Size(284, 20);
            this.txbUsuarioRegistro.TabIndex = 7;
            // 
            // lblSenhaRegistro
            // 
            this.lblSenhaRegistro.AutoSize = true;
            this.lblSenhaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaRegistro.Location = new System.Drawing.Point(271, 201);
            this.lblSenhaRegistro.Name = "lblSenhaRegistro";
            this.lblSenhaRegistro.Size = new System.Drawing.Size(56, 20);
            this.lblSenhaRegistro.TabIndex = 6;
            this.lblSenhaRegistro.Text = "Senha";
            // 
            // lblUsuarioRegistro
            // 
            this.lblUsuarioRegistro.AutoSize = true;
            this.lblUsuarioRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioRegistro.Location = new System.Drawing.Point(271, 167);
            this.lblUsuarioRegistro.Name = "lblUsuarioRegistro";
            this.lblUsuarioRegistro.Size = new System.Drawing.Size(64, 20);
            this.lblUsuarioRegistro.TabIndex = 5;
            this.lblUsuarioRegistro.Text = "Usuário";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 609);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Registro.ResumeLayout(false);
            this.Registro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Login;
        private System.Windows.Forms.TabPage Registro;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button bntLogin;
        private System.Windows.Forms.TextBox txtSenhaLogin;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.TextBox txbSenhaRegistro;
        private System.Windows.Forms.TextBox txbUsuarioRegistro;
        private System.Windows.Forms.Label lblSenhaRegistro;
        private System.Windows.Forms.Label lblUsuarioRegistro;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbConfirmar;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblConfirmar;
    }
}

