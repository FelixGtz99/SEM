namespace SEM.Forms
{
    partial class SemBox
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.messageText = new System.Windows.Forms.TextBox();
            this.defButton = new ePOSOne.btnProduct.Button_WOC();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 41);
            this.panel2.TabIndex = 23;
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
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(205, 99);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(199, 37);
            this.titleLabel.TabIndex = 27;
            this.titleLabel.Text = "Placeholder";
            // 
            // messageText
            // 
            this.messageText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.messageText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.messageText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageText.ForeColor = System.Drawing.Color.White;
            this.messageText.Location = new System.Drawing.Point(154, 189);
            this.messageText.Multiline = true;
            this.messageText.Name = "messageText";
            this.messageText.Size = new System.Drawing.Size(509, 164);
            this.messageText.TabIndex = 28;
            this.messageText.Text = "Placeholder";
            this.messageText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // defButton
            // 
            this.defButton.BorderColor = System.Drawing.Color.Transparent;
            this.defButton.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.defButton.FlatAppearance.BorderSize = 0;
            this.defButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.defButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.defButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defButton.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defButton.Location = new System.Drawing.Point(269, 370);
            this.defButton.Name = "defButton";
            this.defButton.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.defButton.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.defButton.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.defButton.Size = new System.Drawing.Size(298, 60);
            this.defButton.TabIndex = 26;
            this.defButton.Text = "Cerrar";
            this.defButton.TextColor = System.Drawing.Color.White;
            this.defButton.UseVisualStyleBackColor = true;
            this.defButton.Click += new System.EventHandler(this.DefButton_Click);
            this.defButton.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DefButton_KeyDown);
            // 
            // SemBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.messageText);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.defButton);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SemBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SemBox";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private ePOSOne.btnProduct.Button_WOC defButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox messageText;
    }
}