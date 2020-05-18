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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.panelAnonimo = new System.Windows.Forms.Panel();
            this.cbCarrera = new System.Windows.Forms.ComboBox();
            this.cbEscuela = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panelogin = new System.Windows.Forms.Panel();
            this.errorPass = new System.Windows.Forms.Label();
            this.errorEmail = new System.Windows.Forms.Label();
            this.line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAnonimo = new ePOSOne.btnProduct.Button_WOC();
            this.btnRegistrar = new ePOSOne.btnProduct.Button_WOC();
            this.btnLogin1 = new ePOSOne.btnProduct.Button_WOC();
            this.panel.SuspendLayout();
            this.panelAnonimo.SuspendLayout();
            this.panelogin.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.DimGray;
            this.txtEmail.Location = new System.Drawing.Point(40, 59);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(389, 25);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "ejemplo@escuela.com";
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyDown);
            // 
            // txtPass
            // 
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(40, 195);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(389, 25);
            this.txtPass.TabIndex = 2;
            this.txtPass.Text = "placeholder";
            this.txtPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(36, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Correo Electrónico";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(39, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.panelAnonimo);
            this.panel.Controls.Add(this.panelogin);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.btnAnonimo);
            this.panel.Controls.Add(this.btnRegistrar);
            this.panel.Controls.Add(this.btnLogin1);
            this.panel.Location = new System.Drawing.Point(682, 49);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(685, 718);
            this.panel.TabIndex = 3;
            // 
            // panelAnonimo
            // 
            this.panelAnonimo.Controls.Add(this.cbCarrera);
            this.panelAnonimo.Controls.Add(this.cbEscuela);
            this.panelAnonimo.Controls.Add(this.label9);
            this.panelAnonimo.Controls.Add(this.label10);
            this.panelAnonimo.Location = new System.Drawing.Point(124, 150);
            this.panelAnonimo.Name = "panelAnonimo";
            this.panelAnonimo.Size = new System.Drawing.Size(466, 281);
            this.panelAnonimo.TabIndex = 16;
            this.panelAnonimo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAnonimo_Paint);
            // 
            // cbCarrera
            // 
            this.cbCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCarrera.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCarrera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.cbCarrera.FormattingEnabled = true;
            this.cbCarrera.Location = new System.Drawing.Point(47, 201);
            this.cbCarrera.Name = "cbCarrera";
            this.cbCarrera.Size = new System.Drawing.Size(395, 26);
            this.cbCarrera.TabIndex = 6;
            this.cbCarrera.SelectedIndexChanged += new System.EventHandler(this.cbCarrera_SelectedIndexChanged);
            // 
            // cbEscuela
            // 
            this.cbEscuela.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEscuela.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEscuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.cbEscuela.FormattingEnabled = true;
            this.cbEscuela.Location = new System.Drawing.Point(47, 64);
            this.cbEscuela.Name = "cbEscuela";
            this.cbEscuela.Size = new System.Drawing.Size(395, 26);
            this.cbEscuela.TabIndex = 5;
            this.cbEscuela.SelectedIndexChanged += new System.EventHandler(this.cbEscuela_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(43, 157);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = "Carrera";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(36, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "Escuela";
            // 
            // panelogin
            // 
            this.panelogin.Controls.Add(this.errorPass);
            this.panelogin.Controls.Add(this.label1);
            this.panelogin.Controls.Add(this.errorEmail);
            this.panelogin.Controls.Add(this.txtEmail);
            this.panelogin.Controls.Add(this.line1);
            this.panelogin.Controls.Add(this.label2);
            this.panelogin.Controls.Add(this.line2);
            this.panelogin.Controls.Add(this.txtPass);
            this.panelogin.Location = new System.Drawing.Point(121, 150);
            this.panelogin.Name = "panelogin";
            this.panelogin.Size = new System.Drawing.Size(466, 281);
            this.panelogin.TabIndex = 0;
            // 
            // errorPass
            // 
            this.errorPass.AutoSize = true;
            this.errorPass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(70)))));
            this.errorPass.Location = new System.Drawing.Point(40, 244);
            this.errorPass.Name = "errorPass";
            this.errorPass.Size = new System.Drawing.Size(91, 18);
            this.errorPass.TabIndex = 14;
            this.errorPass.Text = "Placeholder";
            this.errorPass.Visible = false;
            // 
            // errorEmail
            // 
            this.errorEmail.AutoSize = true;
            this.errorEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(70)))));
            this.errorEmail.Location = new System.Drawing.Point(40, 110);
            this.errorEmail.Name = "errorEmail";
            this.errorEmail.Size = new System.Drawing.Size(91, 18);
            this.errorEmail.TabIndex = 13;
            this.errorEmail.Text = "Placeholder";
            this.errorEmail.Visible = false;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.White;
            this.line1.Location = new System.Drawing.Point(37, 87);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(392, 3);
            this.line1.TabIndex = 6;
            // 
            // line2
            // 
            this.line2.BackColor = System.Drawing.Color.White;
            this.line2.Location = new System.Drawing.Point(41, 223);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(392, 3);
            this.line2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 566);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "¿Aún no tienes una cuenta?";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(2, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 726);
            this.panel1.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 554);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(422, 36);
            this.label7.TabIndex = 3;
            this.label7.Text = "» ¡Prepárate para tus clases!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(38, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(582, 36);
            this.label6.TabIndex = 2;
            this.label6.Text = "» ¡Descubre qué opinan los estudiantes!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 414);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(376, 36);
            this.label5.TabIndex = 1;
            this.label5.Text = "» ¡Evalúa a tus maestros!";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1368, 41);
            this.panel2.TabIndex = 8;
            // 
            // btnMin
            // 
            this.btnMin.BackColor = System.Drawing.Color.Black;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(1129, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(55, 35);
            this.btnMin.TabIndex = 4;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "_";
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.BtnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1191, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEM.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(107, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(442, 176);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnAnonimo
            // 
            this.btnAnonimo.BorderColor = System.Drawing.Color.Transparent;
            this.btnAnonimo.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnAnonimo.FlatAppearance.BorderSize = 0;
            this.btnAnonimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAnonimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAnonimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnonimo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnonimo.Location = new System.Drawing.Point(357, 606);
            this.btnAnonimo.Name = "btnAnonimo";
            this.btnAnonimo.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAnonimo.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnAnonimo.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnAnonimo.Size = new System.Drawing.Size(311, 60);
            this.btnAnonimo.TabIndex = 6;
            this.btnAnonimo.Text = "Ingreso Anónimo";
            this.btnAnonimo.TextColor = System.Drawing.Color.White;
            this.btnAnonimo.UseVisualStyleBackColor = true;
            this.btnAnonimo.Click += new System.EventHandler(this.BtnAnonimo_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(22, 606);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnRegistrar.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnRegistrar.Size = new System.Drawing.Size(311, 60);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.TextColor = System.Drawing.Color.White;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btnLogin1
            // 
            this.btnLogin1.BorderColor = System.Drawing.Color.Transparent;
            this.btnLogin1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnLogin1.FlatAppearance.BorderSize = 0;
            this.btnLogin1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLogin1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin1.Location = new System.Drawing.Point(154, 455);
            this.btnLogin1.Name = "btnLogin1";
            this.btnLogin1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnLogin1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnLogin1.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnLogin1.Size = new System.Drawing.Size(390, 60);
            this.btnLogin1.TabIndex = 4;
            this.btnLogin1.Text = "Ingresar";
            this.btnLogin1.TextColor = System.Drawing.Color.White;
            this.btnLogin1.UseVisualStyleBackColor = true;
            this.btnLogin1.Click += new System.EventHandler(this.BtnLogin1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEM";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelAnonimo.ResumeLayout(false);
            this.panelAnonimo.PerformLayout();
            this.panelogin.ResumeLayout(false);
            this.panelogin.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ePOSOne.btnProduct.Button_WOC btnLogin1;
        private ePOSOne.btnProduct.Button_WOC btnAnonimo;
        private ePOSOne.btnProduct.Button_WOC btnRegistrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label errorPass;
        private System.Windows.Forms.Label errorEmail;
        private System.Windows.Forms.Panel panelogin;
        private System.Windows.Forms.Panel panelAnonimo;
        private System.Windows.Forms.ComboBox cbCarrera;
        private System.Windows.Forms.ComboBox cbEscuela;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}