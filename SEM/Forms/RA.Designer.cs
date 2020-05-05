namespace SEM.Forms
{
    partial class RA
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnLike = new System.Windows.Forms.Button();
            this.btnDislike = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegresar = new ePOSOne.btnProduct.Button_WOC();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEditar = new ePOSOne.btnProduct.Button_WOC();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new ePOSOne.btnProduct.Button_WOC();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVer = new ePOSOne.btnProduct.Button_WOC();
            this.helpRecent = new System.Windows.Forms.Label();
            this.helpData = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.data = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLike
            // 
            this.btnLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnLike.Location = new System.Drawing.Point(1111, 589);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(157, 49);
            this.btnLike.TabIndex = 2;
            this.btnLike.Text = "Me gusta";
            this.btnLike.UseVisualStyleBackColor = true;
            this.btnLike.Visible = false;
            this.btnLike.Click += new System.EventHandler(this.btnLike_Click);
            // 
            // btnDislike
            // 
            this.btnDislike.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnDislike.Location = new System.Drawing.Point(1111, 666);
            this.btnDislike.Name = "btnDislike";
            this.btnDislike.Size = new System.Drawing.Size(157, 56);
            this.btnDislike.TabIndex = 3;
            this.btnDislike.Text = "No me gusta";
            this.btnDislike.UseVisualStyleBackColor = true;
            this.btnDislike.Visible = false;
            this.btnDislike.Click += new System.EventHandler(this.btnDislike_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(452, 56);
            this.label3.TabIndex = 8;
            this.label3.Text = "Actividad Reciente";
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
            this.panel2.TabIndex = 23;
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
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.labelCarrera);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 727);
            this.panel1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.label6.Location = new System.Drawing.Point(44, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Estudiante";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(44, 321);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Placeholder";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BorderColor = System.Drawing.Color.Transparent;
            this.btnRegresar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Image = global::SEM.Properties.Resources.search;
            this.btnRegresar.Location = new System.Drawing.Point(28, 471);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRegresar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnRegresar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnRegresar.Size = new System.Drawing.Size(298, 60);
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.Text = "Búsqueda";
            this.btnRegresar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(361, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 729);
            this.label2.TabIndex = 34;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btnEditar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Font = new System.Drawing.Font("Arial", 10F);
            this.labelCarrera.ForeColor = System.Drawing.Color.White;
            this.labelCarrera.Location = new System.Drawing.Point(44, 283);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(249, 16);
            this.labelCarrera.TabIndex = 18;
            this.labelCarrera.Text = "Ingeniería en Sistemas de Información";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(54, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(250, 250);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.toolTip2.SetToolTip(this.pictureBox2, "Universidad de Sonora");
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
            this.btnCerrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnCerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
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
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(361, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1004, 3);
            this.label5.TabIndex = 36;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.label4.Location = new System.Drawing.Point(492, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(514, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Aquí encontrarás los 20 movimientos más recientes hechos en tu carrera.";
            // 
            // btnVer
            // 
            this.btnVer.BorderColor = System.Drawing.Color.Transparent;
            this.btnVer.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnVer.FlatAppearance.BorderSize = 0;
            this.btnVer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVer.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.Image = global::SEM.Properties.Resources.people;
            this.btnVer.Location = new System.Drawing.Point(1082, 300);
            this.btnVer.Name = "btnVer";
            this.btnVer.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnVer.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnVer.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnVer.Size = new System.Drawing.Size(259, 60);
            this.btnVer.TabIndex = 39;
            this.btnVer.Text = "Ver";
            this.btnVer.TextColor = System.Drawing.Color.White;
            this.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.BtnVer_Click);
            // 
            // helpRecent
            // 
            this.helpRecent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpRecent.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpRecent.ForeColor = System.Drawing.Color.White;
            this.helpRecent.Location = new System.Drawing.Point(404, 163);
            this.helpRecent.Name = "helpRecent";
            this.helpRecent.Size = new System.Drawing.Size(25, 25);
            this.helpRecent.TabIndex = 42;
            this.helpRecent.Text = "?";
            this.helpRecent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.helpRecent, "Encontrarás actividades como registro de maestros, ediciones por parte del admini" +
        "strador, evaluaciones hechas y materias asociadas a un maestro.");
            // 
            // helpData
            // 
            this.helpData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpData.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpData.ForeColor = System.Drawing.Color.White;
            this.helpData.Location = new System.Drawing.Point(404, 292);
            this.helpData.Name = "helpData";
            this.helpData.Size = new System.Drawing.Size(25, 25);
            this.helpData.TabIndex = 43;
            this.helpData.Text = "?";
            this.helpData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.helpData, "Si das click en Ver tras seleccionar una actividad referente a un maestro, te lle" +
        "vará a su perfil");
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
            // toolTip2
            // 
            this.toolTip2.AutoPopDelay = 15000;
            this.toolTip2.InitialDelay = 500;
            this.toolTip2.ReshowDelay = 100;
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AllowUserToResizeColumns = false;
            this.data.AllowUserToResizeRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.DefaultCellStyle = dataGridViewCellStyle2;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.EnableHeadersVisualStyles = false;
            this.data.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.data.Location = new System.Drawing.Point(382, 327);
            this.data.MultiSelect = false;
            this.data.Name = "data";
            this.data.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.data.RowHeadersWidth = 15;
            this.data.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data.RowTemplate.DividerHeight = 10;
            this.data.RowTemplate.Height = 90;
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(694, 432);
            this.data.TabIndex = 38;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // RA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.helpData);
            this.Controls.Add(this.helpRecent);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.data);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDislike);
            this.Controls.Add(this.btnLike);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnDislike;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private ePOSOne.btnProduct.Button_WOC btnRegresar;
        private System.Windows.Forms.Label label2;
        private ePOSOne.btnProduct.Button_WOC btnEditar;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.PictureBox pictureBox2;
        private ePOSOne.btnProduct.Button_WOC btnCerrar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private ePOSOne.btnProduct.Button_WOC btnVer;
        private System.Windows.Forms.Label helpRecent;
        private System.Windows.Forms.Label helpData;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.DataGridView data;
    }
}