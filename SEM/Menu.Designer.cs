namespace SEM
{
    partial class Menu
    {
        
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCuenta = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRA = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCuenta
            // 
            this.btnCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCuenta.Location = new System.Drawing.Point(256, 101);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(237, 54);
            this.btnCuenta.TabIndex = 0;
            this.btnCuenta.Text = "Cuenta";
            this.btnCuenta.UseVisualStyleBackColor = true;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBuscar.Location = new System.Drawing.Point(256, 341);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(237, 54);
            this.btnBuscar.TabIndex = 1;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRegister.Location = new System.Drawing.Point(256, 161);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(237, 54);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Registrar Docente";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnRA
            // 
            this.btnRA.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnRA.Location = new System.Drawing.Point(256, 221);
            this.btnRA.Name = "btnRA";
            this.btnRA.Size = new System.Drawing.Size(237, 54);
            this.btnRA.TabIndex = 3;
            this.btnRA.Text = "Actividad Reciente";
            this.btnRA.UseVisualStyleBackColor = true;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEvaluar.Location = new System.Drawing.Point(256, 281);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(237, 54);
            this.btnEvaluar.TabIndex = 4;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.button4_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1133, 776);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.btnRA);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnCuenta);
            this.Name = "Menu";
            this.Text = "SEM";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCuenta;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRA;
        private System.Windows.Forms.Button btnEvaluar;
    }
}

