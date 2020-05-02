namespace SEM.Forms
{
    partial class Searcher
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
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbEleccion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelCuenta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRegistrarD = new System.Windows.Forms.Button();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.searchBack1 = new System.Windows.Forms.Label();
            this.searchBack2 = new System.Windows.Forms.Label();
            this.searchBack3 = new System.Windows.Forms.Label();
            this.btnBuscar = new ePOSOne.btnProduct.Button_WOC();
            this.btnRA = new ePOSOne.btnProduct.Button_WOC();
            this.btnEditar = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new ePOSOne.btnProduct.Button_WOC();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelCuenta.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(432, 158);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(469, 25);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbEleccion
            // 
            this.cbEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEleccion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEleccion.FormattingEnabled = true;
            this.cbEleccion.Items.AddRange(new object[] {
            "Docente",
            "Materia"});
            this.cbEleccion.Location = new System.Drawing.Point(616, 226);
            this.cbEleccion.Name = "cbEleccion";
            this.cbEleccion.Size = new System.Drawing.Size(191, 32);
            this.cbEleccion.TabIndex = 3;
            this.cbEleccion.SelectedIndexChanged += new System.EventHandler(this.cbEleccion_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(409, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Búsqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 56);
            this.label3.TabIndex = 7;
            this.label3.Text = "Búsqueda";
            // 
            // panelCuenta
            // 
            this.panelCuenta.Controls.Add(this.label1);
            this.panelCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panelCuenta.ForeColor = System.Drawing.Color.White;
            this.panelCuenta.Location = new System.Drawing.Point(326, 165);
            this.panelCuenta.Name = "panelCuenta";
            this.panelCuenta.Size = new System.Drawing.Size(763, 65);
            this.panelCuenta.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
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
            this.panel2.TabIndex = 22;
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
            this.btnMin.Location = new System.Drawing.Point(1247, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(55, 35);
            this.btnMin.TabIndex = 0;
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
            this.btnClose.Location = new System.Drawing.Point(1308, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel1.Controls.Add(this.btnRA);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.labelCarrera);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.panelCuenta);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 727);
            this.panel1.TabIndex = 26;
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarrera.ForeColor = System.Drawing.Color.White;
            this.labelCarrera.Location = new System.Drawing.Point(44, 283);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(272, 18);
            this.labelCarrera.TabIndex = 18;
            this.labelCarrera.Text = "Ingeniería en Sistemas de Información";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(40, 673);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(277, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "sistema evaluador de maestros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift Light", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(94, 600);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 81);
            this.label7.TabIndex = 1;
            this.label7.Text = "sem";
            // 
            // btnRegistrarD
            // 
            this.btnRegistrarD.BackColor = System.Drawing.Color.White;
            this.btnRegistrarD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarD.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarD.Location = new System.Drawing.Point(1149, 605);
            this.btnRegistrarD.Name = "btnRegistrarD";
            this.btnRegistrarD.Size = new System.Drawing.Size(191, 62);
            this.btnRegistrarD.TabIndex = 30;
            this.btnRegistrarD.Text = "Registrar Docente";
            this.btnRegistrarD.UseVisualStyleBackColor = false;
            this.btnRegistrarD.Click += new System.EventHandler(this.btnRegistrarD_Click);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.BackColor = System.Drawing.Color.White;
            this.btnEvaluar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluar.ForeColor = System.Drawing.Color.Black;
            this.btnEvaluar.Location = new System.Drawing.Point(1149, 404);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(191, 46);
            this.btnEvaluar.TabIndex = 29;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Black;
            this.btnVer.Location = new System.Drawing.Point(1149, 296);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(191, 46);
            this.btnVer.TabIndex = 28;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.data.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.data.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.EnableHeadersVisualStyles = false;
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.data.Location = new System.Drawing.Point(381, 277);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.RowHeadersVisible = false;
            this.data.RowTemplate.DividerHeight = 10;
            this.data.RowTemplate.Height = 45;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(741, 479);
            this.data.TabIndex = 27;
            // 
            // searchBack1
            // 
            this.searchBack1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.searchBack1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBack1.Location = new System.Drawing.Point(409, 148);
            this.searchBack1.Name = "searchBack1";
            this.searchBack1.Size = new System.Drawing.Size(46, 46);
            this.searchBack1.TabIndex = 31;
            this.searchBack1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBack2
            // 
            this.searchBack2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.searchBack2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBack2.Location = new System.Drawing.Point(432, 148);
            this.searchBack2.Name = "searchBack2";
            this.searchBack2.Size = new System.Drawing.Size(469, 46);
            this.searchBack2.TabIndex = 32;
            this.searchBack2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBack3
            // 
            this.searchBack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.searchBack3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.searchBack3.Location = new System.Drawing.Point(878, 148);
            this.searchBack3.Name = "searchBack3";
            this.searchBack3.Size = new System.Drawing.Size(46, 46);
            this.searchBack3.TabIndex = 33;
            this.searchBack3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BorderColor = System.Drawing.Color.Transparent;
            this.btnBuscar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Image = global::SEM.Properties.Resources.search_tool_symbol;
            this.btnBuscar.Location = new System.Drawing.Point(964, 141);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnBuscar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnBuscar.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnBuscar.Size = new System.Drawing.Size(60, 60);
            this.btnBuscar.TabIndex = 19;
            this.btnBuscar.TextColor = System.Drawing.Color.White;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRA
            // 
            this.btnRA.BorderColor = System.Drawing.Color.Transparent;
            this.btnRA.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnRA.FlatAppearance.BorderSize = 0;
            this.btnRA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRA.Image = global::SEM.Properties.Resources.button;
            this.btnRA.Location = new System.Drawing.Point(28, 471);
            this.btnRA.Name = "btnRA";
            this.btnRA.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRA.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnRA.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRA.Size = new System.Drawing.Size(298, 60);
            this.btnRA.TabIndex = 20;
            this.btnRA.Text = "Actividad Reciente";
            this.btnRA.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnRA.UseVisualStyleBackColor = true;
            this.btnRA.Click += new System.EventHandler(this.btnRA_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BorderColor = System.Drawing.Color.Transparent;
            this.btnEditar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Image = global::SEM.Properties.Resources.user_close_up;
            this.btnEditar.Location = new System.Drawing.Point(28, 405);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEditar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnEditar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnEditar.Size = new System.Drawing.Size(298, 60);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.Text = "Editar Cuenta";
            this.btnEditar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(54, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BorderColor = System.Drawing.Color.Transparent;
            this.btnCerrar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Image = global::SEM.Properties.Resources.signs;
            this.btnCerrar.Location = new System.Drawing.Point(28, 537);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCerrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnCerrar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCerrar.Size = new System.Drawing.Size(298, 60);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(361, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 675);
            this.label2.TabIndex = 34;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(361, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1004, 3);
            this.label5.TabIndex = 35;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnRegistrarD);
            this.Controls.Add(this.btnEvaluar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbEleccion);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.searchBack2);
            this.Controls.Add(this.searchBack3);
            this.Controls.Add(this.searchBack1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Searcher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searcher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Searcher_Load);
            this.panelCuenta.ResumeLayout(false);
            this.panelCuenta.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbEleccion;
        private System.Windows.Forms.Panel panelCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC btnCerrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRegistrarD;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label searchBack1;
        private System.Windows.Forms.Label searchBack2;
        private System.Windows.Forms.Label searchBack3;
        private ePOSOne.btnProduct.Button_WOC btnBuscar;
        private ePOSOne.btnProduct.Button_WOC btnEditar;
        private ePOSOne.btnProduct.Button_WOC btnRA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}