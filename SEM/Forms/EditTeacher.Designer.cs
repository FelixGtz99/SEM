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
            this.components = new System.ComponentModel.Container();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.listMaterias = new System.Windows.Forms.ListBox();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.titleBox = new System.Windows.Forms.RichTextBox();
            this.btnAgregar = new ePOSOne.btnProduct.Button_WOC();
            this.defButton = new ePOSOne.btnProduct.Button_WOC();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.helpAdd = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
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
            this.panel2.Size = new System.Drawing.Size(526, 41);
            this.panel2.TabIndex = 28;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(487, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // listMaterias
            // 
            this.listMaterias.Font = new System.Drawing.Font("Arial", 16F);
            this.listMaterias.ForeColor = System.Drawing.Color.DimGray;
            this.listMaterias.FormattingEnabled = true;
            this.listMaterias.ItemHeight = 24;
            this.listMaterias.Location = new System.Drawing.Point(28, 375);
            this.listMaterias.Name = "listMaterias";
            this.listMaterias.Size = new System.Drawing.Size(468, 172);
            this.listMaterias.TabIndex = 31;
            // 
            // cbMaterias
            // 
            this.cbMaterias.Font = new System.Drawing.Font("Arial", 16F);
            this.cbMaterias.ForeColor = System.Drawing.Color.DimGray;
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(28, 239);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(468, 32);
            this.cbMaterias.TabIndex = 32;
            // 
            // titleBox
            // 
            this.titleBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.titleBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleBox.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.titleBox.ForeColor = System.Drawing.Color.White;
            this.titleBox.Location = new System.Drawing.Point(70, 74);
            this.titleBox.Name = "titleBox";
            this.titleBox.ReadOnly = true;
            this.titleBox.Size = new System.Drawing.Size(344, 103);
            this.titleBox.TabIndex = 34;
            this.titleBox.Text = "Placeholder";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BorderColor = System.Drawing.Color.Transparent;
            this.btnAgregar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(200, 277);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAgregar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnAgregar.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.Size = new System.Drawing.Size(136, 46);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextColor = System.Drawing.Color.White;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
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
            this.defButton.Location = new System.Drawing.Point(116, 600);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Materias del maestro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(113, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Materias disponibles";
            // 
            // helpAdd
            // 
            this.helpAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpAdd.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpAdd.ForeColor = System.Drawing.Color.White;
            this.helpAdd.Location = new System.Drawing.Point(53, 207);
            this.helpAdd.Name = "helpAdd";
            this.helpAdd.Size = new System.Drawing.Size(25, 25);
            this.helpAdd.TabIndex = 37;
            this.helpAdd.Text = "?";
            this.helpAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.helpAdd, "Puedes añadirle todas las materias que quieras a un mismo docente, trata de ser h" +
        "onesto.");
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ayuda";
            // 
            // EditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(526, 720);
            this.Controls.Add(this.helpAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleBox);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.listMaterias);
            this.Controls.Add(this.defButton);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditTeacher";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ePOSOne.btnProduct.Button_WOC defButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listMaterias;
        private System.Windows.Forms.ComboBox cbMaterias;
        private ePOSOne.btnProduct.Button_WOC btnAgregar;
        private System.Windows.Forms.RichTextBox titleBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label helpAdd;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}