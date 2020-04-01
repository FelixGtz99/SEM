namespace SEM.Forms
{
    partial class EditAccount
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
            this.panelOpciones = new System.Windows.Forms.Panel();
            this.btnContra = new System.Windows.Forms.Button();
            this.btnCarrera = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panelCarrera = new System.Windows.Forms.Panel();
            this.panelContra = new System.Windows.Forms.Panel();
            this.panelBorrar = new System.Windows.Forms.Panel();
            this.button10 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCarrera = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnComfirPass = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraBorrar = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtNewContra = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.panelOpciones.SuspendLayout();
            this.panelCarrera.SuspendLayout();
            this.panelContra.SuspendLayout();
            this.panelBorrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelOpciones
            // 
            this.panelOpciones.Controls.Add(this.btnBorrar);
            this.panelOpciones.Controls.Add(this.btnCarrera);
            this.panelOpciones.Controls.Add(this.btnContra);
            this.panelOpciones.Location = new System.Drawing.Point(116, 72);
            this.panelOpciones.Name = "panelOpciones";
            this.panelOpciones.Size = new System.Drawing.Size(372, 336);
            this.panelOpciones.TabIndex = 0;
            this.panelOpciones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelOpciones_Paint);
            // 
            // btnContra
            // 
            this.btnContra.BackColor = System.Drawing.Color.White;
            this.btnContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnContra.Location = new System.Drawing.Point(63, 132);
            this.btnContra.Name = "btnContra";
            this.btnContra.Size = new System.Drawing.Size(243, 46);
            this.btnContra.TabIndex = 0;
            this.btnContra.Text = "Cambiar  Contraseña";
            this.btnContra.UseVisualStyleBackColor = false;
            this.btnContra.Click += new System.EventHandler(this.btnContra_Click);
            // 
            // btnCarrera
            // 
            this.btnCarrera.BackColor = System.Drawing.Color.White;
            this.btnCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCarrera.Location = new System.Drawing.Point(63, 61);
            this.btnCarrera.Name = "btnCarrera";
            this.btnCarrera.Size = new System.Drawing.Size(243, 46);
            this.btnCarrera.TabIndex = 1;
            this.btnCarrera.Text = "Cambiar  Carrera";
            this.btnCarrera.UseVisualStyleBackColor = false;
            this.btnCarrera.Click += new System.EventHandler(this.btnCarrera_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.White;
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBorrar.Location = new System.Drawing.Point(63, 212);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(243, 46);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar Cuenta";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // panelCarrera
            // 
            this.panelCarrera.Controls.Add(this.btnComfirPass);
            this.panelCarrera.Controls.Add(this.label2);
            this.panelCarrera.Controls.Add(this.comboBox1);
            this.panelCarrera.Controls.Add(this.lbCarrera);
            this.panelCarrera.Controls.Add(this.label1);
            this.panelCarrera.Location = new System.Drawing.Point(576, 72);
            this.panelCarrera.Name = "panelCarrera";
            this.panelCarrera.Size = new System.Drawing.Size(372, 336);
            this.panelCarrera.TabIndex = 3;
            // 
            // panelContra
            // 
            this.panelContra.Controls.Add(this.button4);
            this.panelContra.Controls.Add(this.txtNewContra);
            this.panelContra.Controls.Add(this.txtContra);
            this.panelContra.Controls.Add(this.label6);
            this.panelContra.Controls.Add(this.label5);
            this.panelContra.Location = new System.Drawing.Point(116, 455);
            this.panelContra.Name = "panelContra";
            this.panelContra.Size = new System.Drawing.Size(372, 336);
            this.panelContra.TabIndex = 3;
            // 
            // panelBorrar
            // 
            this.panelBorrar.Controls.Add(this.txtContraBorrar);
            this.panelBorrar.Controls.Add(this.label3);
            this.panelBorrar.Controls.Add(this.button10);
            this.panelBorrar.Location = new System.Drawing.Point(576, 455);
            this.panelBorrar.Name = "panelBorrar";
            this.panelBorrar.Size = new System.Drawing.Size(372, 336);
            this.panelBorrar.TabIndex = 3;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button10.Location = new System.Drawing.Point(63, 212);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(243, 46);
            this.button10.TabIndex = 2;
            this.button10.Text = "Confirmar";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(20, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrera Actual:";
            // 
            // lbCarrera
            // 
            this.lbCarrera.AutoSize = true;
            this.lbCarrera.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbCarrera.ForeColor = System.Drawing.Color.White;
            this.lbCarrera.Location = new System.Drawing.Point(20, 100);
            this.lbCarrera.Name = "lbCarrera";
            this.lbCarrera.Size = new System.Drawing.Size(99, 26);
            this.lbCarrera.TabIndex = 1;
            this.lbCarrera.Text = "{Carrera}";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 195);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(281, 33);
            this.comboBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nueva Carrera:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(85, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Contraseña Actual:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(83, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 26);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nueva Contraseña:";
            // 
            // btnComfirPass
            // 
            this.btnComfirPass.BackColor = System.Drawing.Color.White;
            this.btnComfirPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnComfirPass.Location = new System.Drawing.Point(63, 258);
            this.btnComfirPass.Name = "btnComfirPass";
            this.btnComfirPass.Size = new System.Drawing.Size(243, 46);
            this.btnComfirPass.TabIndex = 4;
            this.btnComfirPass.Text = "Confirmar ";
            this.btnComfirPass.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(373, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Escriba su contraseña para confirmar";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtContraBorrar
            // 
            this.txtContraBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtContraBorrar.Location = new System.Drawing.Point(83, 116);
            this.txtContraBorrar.Name = "txtContraBorrar";
            this.txtContraBorrar.PasswordChar = '*';
            this.txtContraBorrar.Size = new System.Drawing.Size(207, 32);
            this.txtContraBorrar.TabIndex = 7;
            this.txtContraBorrar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtContra
            // 
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtContra.Location = new System.Drawing.Point(88, 87);
            this.txtContra.Name = "txtContra";
            this.txtContra.PasswordChar = '*';
            this.txtContra.Size = new System.Drawing.Size(207, 32);
            this.txtContra.TabIndex = 8;
            // 
            // txtNewContra
            // 
            this.txtNewContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtNewContra.Location = new System.Drawing.Point(88, 182);
            this.txtNewContra.Name = "txtNewContra";
            this.txtNewContra.PasswordChar = '*';
            this.txtNewContra.Size = new System.Drawing.Size(207, 32);
            this.txtNewContra.TabIndex = 9;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button4.Location = new System.Drawing.Point(73, 241);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(243, 46);
            this.button4.TabIndex = 8;
            this.button4.Text = "Confirmar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.White;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRegresar.Location = new System.Drawing.Point(429, 20);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(243, 46);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // EditAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1061, 745);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.panelBorrar);
            this.Controls.Add(this.panelContra);
            this.Controls.Add(this.panelCarrera);
            this.Controls.Add(this.panelOpciones);
            this.Name = "EditAccount";
            this.Text = "EditAccount";
            this.panelOpciones.ResumeLayout(false);
            this.panelCarrera.ResumeLayout(false);
            this.panelCarrera.PerformLayout();
            this.panelContra.ResumeLayout(false);
            this.panelContra.PerformLayout();
            this.panelBorrar.ResumeLayout(false);
            this.panelBorrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelOpciones;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCarrera;
        private System.Windows.Forms.Button btnContra;
        private System.Windows.Forms.Panel panelCarrera;
        private System.Windows.Forms.Label lbCarrera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelContra;
        private System.Windows.Forms.Panel panelBorrar;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnComfirPass;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtNewContra;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtContraBorrar;
        private System.Windows.Forms.Button btnRegresar;
    }
}