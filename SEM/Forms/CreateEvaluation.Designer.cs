namespace SEM.Forms
{
    partial class CreateEvaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEvaluation));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbMaestro = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMateria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCalificacion = new System.Windows.Forms.TrackBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.limitWarning = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.escuelaPicture = new System.Windows.Forms.PictureBox();
            this.btnRA = new ePOSOne.btnProduct.Button_WOC();
            this.btnVolver = new ePOSOne.btnProduct.Button_WOC();
            this.btnCerrar = new ePOSOne.btnProduct.Button_WOC();
            this.btnGuardar = new ePOSOne.btnProduct.Button_WOC();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCalificacion)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaPicture)).BeginInit();
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(426, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(411, 56);
            this.label9.TabIndex = 25;
            this.label9.Text = "Evalúa una clase";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.label10.Location = new System.Drawing.Point(449, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(735, 24);
            this.label10.TabIndex = 26;
            this.label10.Text = "Selecciona los datos y evalúa  a discreción. Todos los datos son obligatorios.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.label1.Location = new System.Drawing.Point(449, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 24);
            this.label1.TabIndex = 27;
            this.label1.Text = "Recuerda que las evaluaciones son anónimas, pero siempre manten el respeto.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(449, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Maestro";
            // 
            // cbMaestro
            // 
            this.cbMaestro.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaestro.BackColor = System.Drawing.Color.White;
            this.cbMaestro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMaestro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMaestro.Font = new System.Drawing.Font("Arial", 10F);
            this.cbMaestro.ForeColor = System.Drawing.Color.DimGray;
            this.cbMaestro.FormattingEnabled = true;
            this.cbMaestro.Location = new System.Drawing.Point(453, 331);
            this.cbMaestro.Name = "cbMaestro";
            this.cbMaestro.Size = new System.Drawing.Size(387, 24);
            this.cbMaestro.TabIndex = 42;
            this.cbMaestro.SelectedIndexChanged += new System.EventHandler(this.cbMaestro_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(398, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 43;
            this.label6.Text = "?";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label6, "Los maestros en esta lista fueron registrados previamente por otros alumnos como " +
        "tú.");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(449, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 24);
            this.label2.TabIndex = 44;
            this.label2.Text = "Materia";
            // 
            // cbMateria
            // 
            this.cbMateria.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMateria.BackColor = System.Drawing.Color.White;
            this.cbMateria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMateria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbMateria.Font = new System.Drawing.Font("Arial", 10F);
            this.cbMateria.ForeColor = System.Drawing.Color.DimGray;
            this.cbMateria.FormattingEnabled = true;
            this.cbMateria.Location = new System.Drawing.Point(453, 442);
            this.cbMateria.Name = "cbMateria";
            this.cbMateria.Size = new System.Drawing.Size(387, 24);
            this.cbMateria.TabIndex = 45;
            this.cbMateria.SelectedIndexChanged += new System.EventHandler(this.CbMateria_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(398, 452);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 25);
            this.label3.TabIndex = 46;
            this.label3.Text = "?";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label3, "Las materias de esta lista están acorde a tu plan de estudios.");
            // 
            // txtComentarios
            // 
            this.txtComentarios.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(921, 331);
            this.txtComentarios.MaxLength = 100;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(387, 242);
            this.txtComentarios.TabIndex = 47;
            this.txtComentarios.Text = "";
            this.txtComentarios.TextChanged += new System.EventHandler(this.TxtComentarios_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(917, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(363, 24);
            this.label4.TabIndex = 48;
            this.label4.Text = "¿Qué quieres decir sobre esta clase?";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label11.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(880, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 25);
            this.label11.TabIndex = 49;
            this.label11.Text = "?";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label11, "Tienes un límite de 100 caracteres para tu comentario así que elige bien tus pala" +
        "bras.");
            // 
            // tbCalificacion
            // 
            this.tbCalificacion.Cursor = System.Windows.Forms.Cursors.Default;
            this.tbCalificacion.Location = new System.Drawing.Point(33, 23);
            this.tbCalificacion.Name = "tbCalificacion";
            this.tbCalificacion.Size = new System.Drawing.Size(375, 45);
            this.tbCalificacion.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(449, 505);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(368, 24);
            this.label12.TabIndex = 51;
            this.label12.Text = "¿Qué calificación le das a esta clase?";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label13.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(398, 551);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(25, 25);
            this.label13.TabIndex = 52;
            this.label13.Text = "?";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.label13, "El valor de 0 es para un maestro muy malo, mientras el 10 es para un maestro exce" +
        "lente. Piensa bien.");
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.tbCalificacion);
            this.panel3.Location = new System.Drawing.Point(429, 532);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(411, 100);
            this.panel3.TabIndex = 54;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(27, 74);
            this.panel4.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(411, 26);
            this.dataGridView1.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "0";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "5";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "6";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "7";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "8";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "9";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "10";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
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
            // limitWarning
            // 
            this.limitWarning.AutoSize = true;
            this.limitWarning.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limitWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(13)))), ((int)(((byte)(70)))));
            this.limitWarning.Location = new System.Drawing.Point(918, 584);
            this.limitWarning.Name = "limitWarning";
            this.limitWarning.Size = new System.Drawing.Size(198, 16);
            this.limitWarning.TabIndex = 55;
            this.limitWarning.Text = "Tienes 100 caracteres restantes.";
            this.limitWarning.Visible = false;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label14.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label14.Location = new System.Drawing.Point(361, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(1004, 3);
            this.label14.TabIndex = 86;
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.labelUsuario);
            this.panel5.Controls.Add(this.btnRA);
            this.panel5.Controls.Add(this.label16);
            this.panel5.Controls.Add(this.btnVolver);
            this.panel5.Controls.Add(this.label17);
            this.panel5.Controls.Add(this.escuelaPicture);
            this.panel5.Controls.Add(this.btnCerrar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(364, 727);
            this.panel5.TabIndex = 87;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SEM.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(60, 613);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(221, 88);
            this.pictureBox2.TabIndex = 58;
            this.pictureBox2.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.label15.Location = new System.Drawing.Point(44, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 35;
            this.label15.Text = "Estudiante";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.labelUsuario.Location = new System.Drawing.Point(44, 321);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(76, 16);
            this.labelUsuario.TabIndex = 6;
            this.labelUsuario.Text = "Placeholder";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label16.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label16.Location = new System.Drawing.Point(361, -2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(3, 729);
            this.label16.TabIndex = 34;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 10F);
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(44, 283);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(249, 16);
            this.label17.TabIndex = 18;
            this.label17.Text = "Ingeniería en Sistemas de Información";
            // 
            // escuelaPicture
            // 
            this.escuelaPicture.Location = new System.Drawing.Point(54, 6);
            this.escuelaPicture.Name = "escuelaPicture";
            this.escuelaPicture.Size = new System.Drawing.Size(250, 250);
            this.escuelaPicture.TabIndex = 15;
            this.escuelaPicture.TabStop = false;
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
            this.btnRA.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnRA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRA.UseVisualStyleBackColor = true;
            this.btnRA.Click += new System.EventHandler(this.BtnRA_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.BorderColor = System.Drawing.Color.Transparent;
            this.btnVolver.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Image = global::SEM.Properties.Resources.search;
            this.btnVolver.Location = new System.Drawing.Point(28, 405);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnVolver.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnVolver.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnVolver.Size = new System.Drawing.Size(298, 60);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Búsqueda";
            this.btnVolver.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(174)))), ((int)(((byte)(174)))), ((int)(((byte)(174)))));
            this.btnVolver.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.BorderColor = System.Drawing.Color.Transparent;
            this.btnGuardar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            this.btnGuardar.Enabled = false;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(723, 691);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnGuardar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.Size = new System.Drawing.Size(298, 60);
            this.btnGuardar.TabIndex = 53;
            this.btnGuardar.Text = "Evaluar";
            this.btnGuardar.TextColor = System.Drawing.Color.Silver;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // CreateEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.limitWarning);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComentarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMateria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMaestro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateEvaluation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SEM - Evaluación";
            this.Load += new System.EventHandler(this.CreateEvaluation_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbCalificacion)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.escuelaPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbMaestro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtComentarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TrackBar tbCalificacion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private ePOSOne.btnProduct.Button_WOC btnGuardar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label limitWarning;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelUsuario;
        private ePOSOne.btnProduct.Button_WOC btnRA;
        private System.Windows.Forms.Label label16;
        private ePOSOne.btnProduct.Button_WOC btnVolver;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox escuelaPicture;
        private ePOSOne.btnProduct.Button_WOC btnCerrar;
    }
}