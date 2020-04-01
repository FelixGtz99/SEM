namespace SEM
{
    partial class Login
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtEmail.Location = new System.Drawing.Point(286, 55);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 32);
            this.txtEmail.TabIndex = 0;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtPass.Location = new System.Drawing.Point(286, 134);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(244, 32);
            this.txtPass.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(204, 252);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(130, 46);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(100, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.White;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(384, 252);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(130, 46);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "Regresar";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnReturn);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.label2);
            this.panel.Controls.Add(this.btnLogin);
            this.panel.Controls.Add(this.txtPass);
            this.panel.Controls.Add(this.txtEmail);
            this.panel.Location = new System.Drawing.Point(202, 95);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(688, 357);
            this.panel.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1024, 648);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Login";
            this.Text = "SEM";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Panel panel;
    }
}