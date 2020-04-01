namespace SEM
{
    partial class AccountMenu
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
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnAnonimo = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.White;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(56, 107);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(184, 54);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.White;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(310, 107);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(167, 54);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnAnonimo
            // 
            this.btnAnonimo.BackColor = System.Drawing.Color.White;
            this.btnAnonimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnAnonimo.ForeColor = System.Drawing.Color.Black;
            this.btnAnonimo.Location = new System.Drawing.Point(551, 107);
            this.btnAnonimo.Name = "btnAnonimo";
            this.btnAnonimo.Size = new System.Drawing.Size(191, 54);
            this.btnAnonimo.TabIndex = 2;
            this.btnAnonimo.Text = "Anonimo";
            this.btnAnonimo.UseVisualStyleBackColor = false;
            this.btnAnonimo.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnRegistrar);
            this.panel.Controls.Add(this.btnAnonimo);
            this.panel.Controls.Add(this.btnIngresar);
            this.panel.Location = new System.Drawing.Point(137, 12);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(784, 286);
            this.panel.TabIndex = 3;
            // 
            // AccountMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1053, 721);
            this.Controls.Add(this.panel);
            this.Name = "AccountMenu";
            this.Text = "AccountMenu";
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnAnonimo;
        private System.Windows.Forms.Panel panel;
    }
}