namespace SEM
{
    partial class Evaluate
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
            this.cbMaestro = new System.Windows.Forms.ComboBox();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbMaestro
            // 
            this.cbMaestro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbMaestro.FormattingEnabled = true;
            this.cbMaestro.Location = new System.Drawing.Point(243, 74);
            this.cbMaestro.Name = "cbMaestro";
            this.cbMaestro.Size = new System.Drawing.Size(455, 33);
            this.cbMaestro.TabIndex = 0;
            this.cbMaestro.SelectedIndexChanged += new System.EventHandler(this.cbMaestro_SelectedIndexChanged);
            // 
            // cbMateria
            // 
            this.cbMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(243, 194);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(455, 33);
            this.cbMateria.TabIndex = 1;
            // 
            // Evaluate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 728);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.cbMaestro);
            this.Name = "Evaluate";
            this.Text = "Evaluate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMaestro;
        private System.Windows.Forms.ComboBox cbMateria;
    }
}