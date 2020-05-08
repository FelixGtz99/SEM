namespace SEM.Forms
{
    partial class AdminPanel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_WOC2 = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC3 = new ePOSOne.btnProduct.Button_WOC();
            this.btnCerrar = new ePOSOne.btnProduct.Button_WOC();
            this.notifications = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnConfig = new ePOSOne.btnProduct.Button_WOC();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCarrera = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaterias = new System.Windows.Forms.ComboBox();
            this.line1 = new System.Windows.Forms.Label();
            this.txtMaterias = new System.Windows.Forms.TextBox();
            this.cbMaestros = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.helpMaterias = new System.Windows.Forms.Label();
            this.helpMaestros = new System.Windows.Forms.Label();
            this.lbEscuela = new System.Windows.Forms.Label();
            this.btnEditar = new ePOSOne.btnProduct.Button_WOC();
            this.btnAñadir = new ePOSOne.btnProduct.Button_WOC();
            this.button_WOC1 = new ePOSOne.btnProduct.Button_WOC();
            this.btnQuitar = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.btnMin);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1366, 41);
            this.panel2.TabIndex = 9;
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Black;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.ForeColor = System.Drawing.Color.White;
            this.btnMin.Location = new System.Drawing.Point(1250, 3);
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
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Lucida Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(1311, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.button_WOC2);
            this.panel1.Controls.Add(this.button_WOC3);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.notifications);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnConfig);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lbNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 727);
            this.panel1.TabIndex = 10;
            // 
            // button_WOC2
            // 
            this.button_WOC2.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.button_WOC2.FlatAppearance.BorderSize = 0;
            this.button_WOC2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC2.Image = global::SEM.Properties.Resources.people;
            this.button_WOC2.Location = new System.Drawing.Point(201, 547);
            this.button_WOC2.Name = "button_WOC2";
            this.button_WOC2.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC2.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.button_WOC2.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.button_WOC2.Size = new System.Drawing.Size(60, 60);
            this.button_WOC2.TabIndex = 57;
            this.button_WOC2.TextColor = System.Drawing.Color.White;
            this.button_WOC2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_WOC2.UseVisualStyleBackColor = true;
            // 
            // button_WOC3
            // 
            this.button_WOC3.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(70)))));
            this.button_WOC3.FlatAppearance.BorderSize = 0;
            this.button_WOC3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC3.Image = global::SEM.Properties.Resources.delete;
            this.button_WOC3.Location = new System.Drawing.Point(100, 545);
            this.button_WOC3.Name = "button_WOC3";
            this.button_WOC3.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC3.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(5)))), ((int)(((byte)(57)))));
            this.button_WOC3.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.button_WOC3.Size = new System.Drawing.Size(60, 60);
            this.button_WOC3.TabIndex = 56;
            this.button_WOC3.TextColor = System.Drawing.Color.White;
            this.button_WOC3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_WOC3.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCerrar.ButtonColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::SEM.Properties.Resources.signs;
            this.btnCerrar.Location = new System.Drawing.Point(46, 187);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCerrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnCerrar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCerrar.Size = new System.Drawing.Size(259, 60);
            this.btnCerrar.TabIndex = 55;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // notifications
            // 
            this.notifications.AllowUserToAddRows = false;
            this.notifications.AllowUserToDeleteRows = false;
            this.notifications.AllowUserToResizeColumns = false;
            this.notifications.AllowUserToResizeRows = false;
            this.notifications.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.notifications.BackgroundColor = System.Drawing.Color.White;
            this.notifications.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.notifications.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notifications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.notifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.notifications.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notifications.DefaultCellStyle = dataGridViewCellStyle2;
            this.notifications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.notifications.EnableHeadersVisualStyles = false;
            this.notifications.GridColor = System.Drawing.Color.White;
            this.notifications.Location = new System.Drawing.Point(46, 308);
            this.notifications.MultiSelect = false;
            this.notifications.Name = "notifications";
            this.notifications.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.notifications.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.notifications.RowHeadersWidth = 15;
            this.notifications.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.notifications.RowTemplate.DividerHeight = 10;
            this.notifications.RowTemplate.Height = 90;
            this.notifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.notifications.Size = new System.Drawing.Size(305, 233);
            this.notifications.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(42, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Notificaciones";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(44, 681);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "sistema evaluador de maestros";
            // 
            // btnConfig
            // 
            this.btnConfig.BorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.ButtonColor = System.Drawing.Color.White;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.Image = global::SEM.Properties.Resources.user_close_up;
            this.btnConfig.Location = new System.Drawing.Point(46, 121);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnConfig.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnConfig.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnConfig.Size = new System.Drawing.Size(259, 60);
            this.btnConfig.TabIndex = 50;
            this.btnConfig.Text = "Editar Cuenta";
            this.btnConfig.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(98, 608);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 81);
            this.label7.TabIndex = 15;
            this.label7.Text = "sem";
            // 
            // lbNombre
            // 
            this.lbNombre.BackColor = System.Drawing.Color.White;
            this.lbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbNombre.Location = new System.Drawing.Point(46, 78);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(285, 54);
            this.lbNombre.TabIndex = 12;
            this.lbNombre.Text = "Dr. José Luis Ochoa Hernández";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(41, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(290, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "MODO ADMINISTRADOR";
            // 
            // lbCarrera
            // 
            this.lbCarrera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.lbCarrera.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbCarrera.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarrera.ForeColor = System.Drawing.Color.Black;
            this.lbCarrera.Location = new System.Drawing.Point(601, 104);
            this.lbCarrera.Name = "lbCarrera";
            this.lbCarrera.Size = new System.Drawing.Size(675, 141);
            this.lbCarrera.TabIndex = 11;
            this.lbCarrera.Text = "Ingeniería en Sistemas de Información";
            this.lbCarrera.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label3.Location = new System.Drawing.Point(484, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 13;
            this.label3.Text = "Materias";
            // 
            // cbMaterias
            // 
            this.cbMaterias.Font = new System.Drawing.Font("Arial", 12F);
            this.cbMaterias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbMaterias.FormattingEnabled = true;
            this.cbMaterias.Location = new System.Drawing.Point(488, 368);
            this.cbMaterias.Name = "cbMaterias";
            this.cbMaterias.Size = new System.Drawing.Size(510, 26);
            this.cbMaterias.TabIndex = 14;
            this.cbMaterias.SelectedIndexChanged += new System.EventHandler(this.cbMaterias_SelectedIndexChanged);
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.Black;
            this.line1.Location = new System.Drawing.Point(485, 455);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(513, 3);
            this.line1.TabIndex = 16;
            // 
            // txtMaterias
            // 
            this.txtMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtMaterias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMaterias.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterias.ForeColor = System.Drawing.Color.DimGray;
            this.txtMaterias.Location = new System.Drawing.Point(488, 427);
            this.txtMaterias.Name = "txtMaterias";
            this.txtMaterias.Size = new System.Drawing.Size(510, 25);
            this.txtMaterias.TabIndex = 15;
            // 
            // cbMaestros
            // 
            this.cbMaestros.Font = new System.Drawing.Font("Arial", 12F);
            this.cbMaestros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.cbMaestros.FormattingEnabled = true;
            this.cbMaestros.Location = new System.Drawing.Point(488, 569);
            this.cbMaestros.Name = "cbMaestros";
            this.cbMaestros.Size = new System.Drawing.Size(510, 26);
            this.cbMaestros.TabIndex = 48;
            this.cbMaestros.SelectedIndexChanged += new System.EventHandler(this.cbMaestros_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.label4.Location = new System.Drawing.Point(484, 510);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 24);
            this.label4.TabIndex = 47;
            this.label4.Text = "Maestros";
            // 
            // helpMaterias
            // 
            this.helpMaterias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpMaterias.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpMaterias.ForeColor = System.Drawing.Color.White;
            this.helpMaterias.Location = new System.Drawing.Point(436, 309);
            this.helpMaterias.Name = "helpMaterias";
            this.helpMaterias.Size = new System.Drawing.Size(25, 25);
            this.helpMaterias.TabIndex = 51;
            this.helpMaterias.Text = "?";
            this.helpMaterias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // helpMaestros
            // 
            this.helpMaestros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpMaestros.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpMaestros.ForeColor = System.Drawing.Color.White;
            this.helpMaestros.Location = new System.Drawing.Point(436, 509);
            this.helpMaestros.Name = "helpMaestros";
            this.helpMaestros.Size = new System.Drawing.Size(25, 25);
            this.helpMaestros.TabIndex = 52;
            this.helpMaestros.Text = "?";
            this.helpMaestros.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEscuela
            // 
            this.lbEscuela.AutoSize = true;
            this.lbEscuela.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEscuela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbEscuela.Location = new System.Drawing.Point(602, 80);
            this.lbEscuela.Name = "lbEscuela";
            this.lbEscuela.Size = new System.Drawing.Size(223, 24);
            this.lbEscuela.TabIndex = 53;
            this.lbEscuela.Text = "Universidad de Sonora";
            // 
            // btnEditar
            // 
            this.btnEditar.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::SEM.Properties.Resources.edit;
            this.btnEditar.Location = new System.Drawing.Point(1017, 559);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEditar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnEditar.Size = new System.Drawing.Size(259, 60);
            this.btnEditar.TabIndex = 49;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextColor = System.Drawing.Color.White;
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BorderColor = System.Drawing.Color.Transparent;
            this.btnAñadir.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.Image = global::SEM.Properties.Resources.plus;
            this.btnAñadir.Location = new System.Drawing.Point(1017, 415);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnAñadir.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnAñadir.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnAñadir.Size = new System.Drawing.Size(259, 60);
            this.btnAñadir.TabIndex = 45;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.TextColor = System.Drawing.Color.White;
            this.btnAñadir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // button_WOC1
            // 
            this.button_WOC1.BorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.button_WOC1.FlatAppearance.BorderSize = 0;
            this.button_WOC1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_WOC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_WOC1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_WOC1.Image = global::SEM.Properties.Resources.edit;
            this.button_WOC1.Location = new System.Drawing.Point(1077, 349);
            this.button_WOC1.Name = "button_WOC1";
            this.button_WOC1.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.button_WOC1.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.button_WOC1.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.button_WOC1.Size = new System.Drawing.Size(60, 60);
            this.button_WOC1.TabIndex = 54;
            this.button_WOC1.TextColor = System.Drawing.Color.White;
            this.button_WOC1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button_WOC1.UseVisualStyleBackColor = true;
            // 
            // btnQuitar
            // 
            this.btnQuitar.BorderColor = System.Drawing.Color.Transparent;
            this.btnQuitar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(70)))));
            this.btnQuitar.FlatAppearance.BorderSize = 0;
            this.btnQuitar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitar.Image = global::SEM.Properties.Resources.delete;
            this.btnQuitar.Location = new System.Drawing.Point(1171, 349);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnQuitar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(5)))), ((int)(((byte)(57)))));
            this.btnQuitar.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnQuitar.Size = new System.Drawing.Size(60, 60);
            this.btnQuitar.TabIndex = 46;
            this.btnQuitar.TextColor = System.Drawing.Color.White;
            this.btnQuitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(404, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.button_WOC1);
            this.Controls.Add(this.lbEscuela);
            this.Controls.Add(this.helpMaestros);
            this.Controls.Add(this.helpMaterias);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.cbMaestros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.txtMaterias);
            this.Controls.Add(this.cbMaterias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbCarrera);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminPanel";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.notifications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox lbCarrera;
        private System.Windows.Forms.RichTextBox lbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaterias;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.TextBox txtMaterias;
        private ePOSOne.btnProduct.Button_WOC btnAñadir;
        private ePOSOne.btnProduct.Button_WOC btnQuitar;
        private System.Windows.Forms.ComboBox cbMaestros;
        private System.Windows.Forms.Label label4;
        private ePOSOne.btnProduct.Button_WOC btnEditar;
        private ePOSOne.btnProduct.Button_WOC btnConfig;
        private System.Windows.Forms.Label helpMaterias;
        private System.Windows.Forms.Label helpMaestros;
        private System.Windows.Forms.Label lbEscuela;
        private System.Windows.Forms.DataGridView notifications;
        private ePOSOne.btnProduct.Button_WOC btnCerrar;
        private ePOSOne.btnProduct.Button_WOC button_WOC1;
        private ePOSOne.btnProduct.Button_WOC button_WOC2;
        private ePOSOne.btnProduct.Button_WOC button_WOC3;
    }
}