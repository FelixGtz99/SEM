namespace SEM.Forms
{
    partial class EditTeacher
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.defButton = new ePOSOne.btnProduct.Button_WOC();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.listMaterias = new System.Windows.Forms.ListBox();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.btnAgregar = new ePOSOne.btnProduct.Button_WOC();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(288, 44);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(199, 37);
            this.titleLabel.TabIndex = 30;
            this.titleLabel.Text = "Placeholder";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // defButton
            // 
            this.defButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.defButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.defButton.FlatAppearance.BorderSize = 0;
            this.defButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.defButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.defButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defButton.Location = new System.Drawing.Point(255, 369);
            this.defButton.Name = "defButton";
            this.defButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.defButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.defButton.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.defButton.Size = new System.Drawing.Size(298, 60);
            this.defButton.TabIndex = 29;
            this.defButton.Text = "Cerrar";
            this.defButton.TextColor = System.Drawing.Color.White;
            this.defButton.UseVisualStyleBackColor = true;
            this.defButton.Click += new System.EventHandler(this.defButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 41);
            this.panel2.TabIndex = 28;
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
            this.btnClose.Location = new System.Drawing.Point(745, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // listMaterias
            // 
            this.listMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.listMaterias.FormattingEnabled = true;
            this.listMaterias.ItemHeight = 25;
            this.listMaterias.Location = new System.Drawing.Point(78, 160);
            this.listMaterias.Name = "listMaterias";
            this.listMaterias.Size = new System.Drawing.Size(344, 179);
            this.listMaterias.TabIndex = 31;
            // 
            // cbMaterias
            // 
            this.cbMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(480, 160);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(267, 33);
            this.cbMaterias.TabIndex = 32;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(200)))), ((int)(((byte)(255)))));
            this.btnAgregar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(598, 216);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAgregar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.Size = new System.Drawing.Size(102, 28);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // EditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.listMaterias);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.defButton);
            this.Controls.Add(this.panel2);
            this.Name = "EditTeacher";
            this.Text = "EditTeacher";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private ePOSOne.btnProduct.Button_WOC defButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listMaterias;
        private System.Windows.Forms.ComboBox cbMaterias;
        private ePOSOne.btnProduct.Button_WOC btnAgregar;
    }
}