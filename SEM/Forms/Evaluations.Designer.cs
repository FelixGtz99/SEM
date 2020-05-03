namespace SEM.Forms
{
    partial class Evaluations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.btnVolver = new ePOSOne.btnProduct.Button_WOC();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.panelEvaluaciones = new System.Windows.Forms.Panel();
            this.materiaLabel = new System.Windows.Forms.Label();
            this.btnMaterias = new ePOSOne.btnProduct.Button_WOC();
            this.dislikeBtn = new ePOSOne.btnProduct.Button_WOC();
            this.likeBtn = new ePOSOne.btnProduct.Button_WOC();
            this.panelMaterias = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnADD = new ePOSOne.btnProduct.Button_WOC();
            this.btnEvaluations = new ePOSOne.btnProduct.Button_WOC();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnEvaluate = new ePOSOne.btnProduct.Button_WOC();
            this.imgMaestro = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelEvaluaciones.SuspendLayout();
            this.panelMaterias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMaestro)).BeginInit();
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
            this.panel2.TabIndex = 24;
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
            this.btnMin.Location = new System.Drawing.Point(1129, 4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(55, 35);
            this.btnMin.TabIndex = 4;
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
            this.btnClose.Location = new System.Drawing.Point(1191, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 35);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.panel1.Controls.Add(this.labelCarrera);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnVolver);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 727);
            this.panel1.TabIndex = 25;
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
            // btnVolver
            // 
            this.btnVolver.BorderColor = System.Drawing.Color.Transparent;
            this.btnVolver.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(28, 510);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnVolver.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnVolver.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnVolver.Size = new System.Drawing.Size(298, 60);
            this.btnVolver.TabIndex = 14;
            this.btnVolver.Text = "Volver";
            this.btnVolver.TextColor = System.Drawing.Color.White;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(39, 650);
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
            this.label7.Location = new System.Drawing.Point(93, 577);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(163, 81);
            this.label7.TabIndex = 1;
            this.label7.Text = "sem";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(659, 101);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 68);
            this.label9.TabIndex = 26;
            this.label9.Text = "Maestro";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(667, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Maestro 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(64, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 24);
            this.label2.TabIndex = 29;
            this.label2.Text = "Evaluaciones de la materia:";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(11, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label6, "Estas son las evaluaciones hechas por otros alumnos, puedes votar positiva o nega" +
        "tivamente por ellas, de acuerdo a como lo consideres");
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.Location = new System.Drawing.Point(68, 110);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(821, 155);
            this.dataGridView1.TabIndex = 45;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(14, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 44;
            this.label4.Text = "?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label4, "Estas son las materias que se han registrado como clases de este maestro. Si cons" +
        "ideras que falta alguna da click en agregar materia.");
            // 
            // panelEvaluaciones
            // 
            this.panelEvaluaciones.Controls.Add(this.materiaLabel);
            this.panelEvaluaciones.Controls.Add(this.btnMaterias);
            this.panelEvaluaciones.Controls.Add(this.label2);
            this.panelEvaluaciones.Controls.Add(this.label6);
            this.panelEvaluaciones.Controls.Add(this.dislikeBtn);
            this.panelEvaluaciones.Controls.Add(this.dataGridView1);
            this.panelEvaluaciones.Controls.Add(this.likeBtn);
            this.panelEvaluaciones.Location = new System.Drawing.Point(407, 308);
            this.panelEvaluaciones.Name = "panelEvaluaciones";
            this.panelEvaluaciones.Size = new System.Drawing.Size(965, 416);
            this.panelEvaluaciones.TabIndex = 50;
            this.panelEvaluaciones.Visible = false;
            // 
            // materiaLabel
            // 
            this.materiaLabel.AutoSize = true;
            this.materiaLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materiaLabel.ForeColor = System.Drawing.Color.White;
            this.materiaLabel.Location = new System.Drawing.Point(518, 12);
            this.materiaLabel.Name = "materiaLabel";
            this.materiaLabel.Size = new System.Drawing.Size(120, 24);
            this.materiaLabel.TabIndex = 49;
            this.materiaLabel.Text = "Placeholder";
            // 
            // btnMaterias
            // 
            this.btnMaterias.BorderColor = System.Drawing.Color.Transparent;
            this.btnMaterias.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnMaterias.FlatAppearance.BorderSize = 0;
            this.btnMaterias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnMaterias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnMaterias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaterias.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaterias.Location = new System.Drawing.Point(399, 342);
            this.btnMaterias.Name = "btnMaterias";
            this.btnMaterias.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnMaterias.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnMaterias.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnMaterias.Size = new System.Drawing.Size(205, 49);
            this.btnMaterias.TabIndex = 48;
            this.btnMaterias.Text = "Ver Materias";
            this.btnMaterias.TextColor = System.Drawing.Color.White;
            this.btnMaterias.UseVisualStyleBackColor = true;
            this.btnMaterias.Click += new System.EventHandler(this.BtnMaterias_Click);
            // 
            // dislikeBtn
            // 
            this.dislikeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.dislikeBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(130)))), ((int)(((byte)(170)))));
            this.dislikeBtn.Enabled = false;
            this.dislikeBtn.FlatAppearance.BorderSize = 0;
            this.dislikeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.dislikeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.dislikeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dislikeBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dislikeBtn.Location = new System.Drawing.Point(568, 271);
            this.dislikeBtn.Name = "dislikeBtn";
            this.dislikeBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.dislikeBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(5)))), ((int)(((byte)(57)))));
            this.dislikeBtn.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.dislikeBtn.Size = new System.Drawing.Size(170, 49);
            this.dislikeBtn.TabIndex = 47;
            this.dislikeBtn.Text = "No me gusta";
            this.dislikeBtn.TextColor = System.Drawing.Color.Silver;
            this.dislikeBtn.UseVisualStyleBackColor = true;
            this.dislikeBtn.Click += new System.EventHandler(this.button_WOC2_Click);
            // 
            // likeBtn
            // 
            this.likeBtn.BorderColor = System.Drawing.Color.Transparent;
            this.likeBtn.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.likeBtn.Enabled = false;
            this.likeBtn.FlatAppearance.BorderSize = 0;
            this.likeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.likeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.likeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.likeBtn.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeBtn.Location = new System.Drawing.Point(264, 271);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.likeBtn.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.likeBtn.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.likeBtn.Size = new System.Drawing.Size(170, 49);
            this.likeBtn.TabIndex = 46;
            this.likeBtn.Text = "Me gusta";
            this.likeBtn.TextColor = System.Drawing.Color.Silver;
            this.likeBtn.UseVisualStyleBackColor = true;
            this.likeBtn.Click += new System.EventHandler(this.button_WOC1_Click);
            // 
            // panelMaterias
            // 
            this.panelMaterias.Controls.Add(this.label3);
            this.panelMaterias.Controls.Add(this.btnADD);
            this.panelMaterias.Controls.Add(this.label4);
            this.panelMaterias.Controls.Add(this.btnEvaluations);
            this.panelMaterias.Controls.Add(this.dataGridView2);
            this.panelMaterias.Controls.Add(this.btnEvaluate);
            this.panelMaterias.Location = new System.Drawing.Point(389, 326);
            this.panelMaterias.Name = "panelMaterias";
            this.panelMaterias.Size = new System.Drawing.Size(965, 425);
            this.panelMaterias.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(66, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "Materias impartidas";
            // 
            // btnADD
            // 
            this.btnADD.BorderColor = System.Drawing.Color.Transparent;
            this.btnADD.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.btnADD.FlatAppearance.BorderSize = 0;
            this.btnADD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnADD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnADD.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.Location = new System.Drawing.Point(710, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnADD.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnADD.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnADD.Size = new System.Drawing.Size(222, 49);
            this.btnADD.TabIndex = 49;
            this.btnADD.Text = "Agregar Materia";
            this.btnADD.TextColor = System.Drawing.Color.White;
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.button_WOC1_Click_1);
            // 
            // btnEvaluations
            // 
            this.btnEvaluations.BorderColor = System.Drawing.Color.Transparent;
            this.btnEvaluations.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEvaluations.Enabled = false;
            this.btnEvaluations.FlatAppearance.BorderSize = 0;
            this.btnEvaluations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEvaluations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEvaluations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluations.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluations.Location = new System.Drawing.Point(549, 349);
            this.btnEvaluations.Name = "btnEvaluations";
            this.btnEvaluations.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEvaluations.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnEvaluations.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnEvaluations.Size = new System.Drawing.Size(205, 49);
            this.btnEvaluations.TabIndex = 47;
            this.btnEvaluations.Text = "Ver evaluaciones";
            this.btnEvaluations.TextColor = System.Drawing.Color.Silver;
            this.btnEvaluations.UseVisualStyleBackColor = true;
            this.btnEvaluations.Click += new System.EventHandler(this.BtnEvaluations_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView2.Location = new System.Drawing.Point(68, 82);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(821, 246);
            this.dataGridView2.TabIndex = 45;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.BorderColor = System.Drawing.Color.Transparent;
            this.btnEvaluate.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnEvaluate.Enabled = false;
            this.btnEvaluate.FlatAppearance.BorderSize = 0;
            this.btnEvaluate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEvaluate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEvaluate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEvaluate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluate.Location = new System.Drawing.Point(260, 349);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnEvaluate.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnEvaluate.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnEvaluate.Size = new System.Drawing.Size(170, 49);
            this.btnEvaluate.TabIndex = 46;
            this.btnEvaluate.Text = "Evaluar";
            this.btnEvaluate.TextColor = System.Drawing.Color.Silver;
            this.btnEvaluate.UseVisualStyleBackColor = true;
            this.btnEvaluate.Click += new System.EventHandler(this.BtnEvaluate_Click);
            // 
            // imgMaestro
            // 
            this.imgMaestro.Image = global::SEM.Properties.Resources._default;
            this.imgMaestro.InitialImage = global::SEM.Properties.Resources._default;
            this.imgMaestro.Location = new System.Drawing.Point(422, 76);
            this.imgMaestro.Name = "imgMaestro";
            this.imgMaestro.Size = new System.Drawing.Size(175, 175);
            this.imgMaestro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgMaestro.TabIndex = 48;
            this.imgMaestro.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // Evaluations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panelEvaluaciones);
            this.Controls.Add(this.panelMaterias);
            this.Controls.Add(this.imgMaestro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Evaluations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluations";
            this.Load += new System.EventHandler(this.Evaluations_Load);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelEvaluaciones.ResumeLayout(false);
            this.panelEvaluaciones.PerformLayout();
            this.panelMaterias.ResumeLayout(false);
            this.panelMaterias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgMaestro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private ePOSOne.btnProduct.Button_WOC btnVolver;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ePOSOne.btnProduct.Button_WOC likeBtn;
        private ePOSOne.btnProduct.Button_WOC dislikeBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox imgMaestro;
        private System.Windows.Forms.Panel panelEvaluaciones;
        private System.Windows.Forms.Panel panelMaterias;
        private System.Windows.Forms.Label label3;
        private ePOSOne.btnProduct.Button_WOC btnADD;
        private System.Windows.Forms.Label label4;
        private ePOSOne.btnProduct.Button_WOC btnEvaluations;
        private System.Windows.Forms.DataGridView dataGridView2;
        private ePOSOne.btnProduct.Button_WOC btnEvaluate;
        private ePOSOne.btnProduct.Button_WOC btnMaterias;
        private System.Windows.Forms.Label materiaLabel;
        private System.Windows.Forms.Label labelCarrera;
    }
}