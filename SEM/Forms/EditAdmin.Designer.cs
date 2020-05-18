namespace SEM.Forms
{
    partial class EditAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAdmin));
            this.changePassPanel = new System.Windows.Forms.Panel();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelConfirmar = new System.Windows.Forms.Label();
            this.txtCPass = new System.Windows.Forms.TextBox();
            this.helpContraseña = new System.Windows.Forms.Label();
            this.lineConfirmar = new System.Windows.Forms.Label();
            this.txtNewContra = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.helpConfirm = new System.Windows.Forms.Label();
            this.helpCorreo = new System.Windows.Forms.Label();
            this.helpName = new System.Windows.Forms.Label();
            this.btnChangeNombre = new System.Windows.Forms.Button();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnChangeCorreo = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.changeEmailPanel = new System.Windows.Forms.Panel();
            this.labelOldCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.namePanel = new System.Windows.Forms.Panel();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.labelEstudiante = new System.Windows.Forms.Label();
            this.btnRA = new ePOSOne.btnProduct.Button_WOC();
            this.label5 = new System.Windows.Forms.Label();
            this.labelCarrera = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new ePOSOne.btnProduct.Button_WOC();
            this.btnGuardar = new ePOSOne.btnProduct.Button_WOC();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.changePassPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.changeEmailPanel.SuspendLayout();
            this.namePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // changePassPanel
            // 
            this.changePassPanel.Controls.Add(this.labelContraseña);
            this.changePassPanel.Controls.Add(this.labelConfirmar);
            this.changePassPanel.Controls.Add(this.txtCPass);
            this.changePassPanel.Controls.Add(this.helpContraseña);
            this.changePassPanel.Controls.Add(this.lineConfirmar);
            this.changePassPanel.Controls.Add(this.txtNewContra);
            this.changePassPanel.Controls.Add(this.label18);
            this.changePassPanel.Location = new System.Drawing.Point(623, 258);
            this.changePassPanel.Name = "changePassPanel";
            this.changePassPanel.Size = new System.Drawing.Size(480, 210);
            this.changePassPanel.TabIndex = 64;
            this.changePassPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.changePassPanel_Paint);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Arial", 12F);
            this.labelContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelContraseña.Location = new System.Drawing.Point(44, 15);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(137, 18);
            this.labelContraseña.TabIndex = 27;
            this.labelContraseña.Text = "Nueva Contraseña";
            // 
            // labelConfirmar
            // 
            this.labelConfirmar.AutoSize = true;
            this.labelConfirmar.Font = new System.Drawing.Font("Arial", 12F);
            this.labelConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelConfirmar.Location = new System.Drawing.Point(44, 122);
            this.labelConfirmar.Name = "labelConfirmar";
            this.labelConfirmar.Size = new System.Drawing.Size(162, 18);
            this.labelConfirmar.TabIndex = 33;
            this.labelConfirmar.Text = "Confirmar Contraseña";
            // 
            // txtCPass
            // 
            this.txtCPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtCPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCPass.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtCPass.Location = new System.Drawing.Point(48, 170);
            this.txtCPass.Name = "txtCPass";
            this.txtCPass.PasswordChar = '*';
            this.txtCPass.Size = new System.Drawing.Size(387, 19);
            this.txtCPass.TabIndex = 34;
            // 
            // helpContraseña
            // 
            this.helpContraseña.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpContraseña.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpContraseña.ForeColor = System.Drawing.Color.White;
            this.helpContraseña.Location = new System.Drawing.Point(12, 69);
            this.helpContraseña.Name = "helpContraseña";
            this.helpContraseña.Size = new System.Drawing.Size(25, 25);
            this.helpContraseña.TabIndex = 30;
            this.helpContraseña.Text = "?";
            this.helpContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.helpContraseña, "Por seguridad, su contraseña no puede tener menos de 9 caracteres, entre los cual" +
        "es debe incluirse al menos una mayúscula, una minúscula y dos números.");
            // 
            // lineConfirmar
            // 
            this.lineConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.lineConfirmar.Location = new System.Drawing.Point(45, 198);
            this.lineConfirmar.Name = "lineConfirmar";
            this.lineConfirmar.Size = new System.Drawing.Size(392, 3);
            this.lineConfirmar.TabIndex = 35;
            // 
            // txtNewContra
            // 
            this.txtNewContra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtNewContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewContra.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNewContra.ForeColor = System.Drawing.Color.DimGray;
            this.txtNewContra.Location = new System.Drawing.Point(48, 63);
            this.txtNewContra.Name = "txtNewContra";
            this.txtNewContra.PasswordChar = '*';
            this.txtNewContra.Size = new System.Drawing.Size(387, 19);
            this.txtNewContra.TabIndex = 31;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label18.Location = new System.Drawing.Point(48, 89);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(392, 3);
            this.label18.TabIndex = 55;
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
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 15000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Ayuda";
            // 
            // helpConfirm
            // 
            this.helpConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpConfirm.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpConfirm.ForeColor = System.Drawing.Color.White;
            this.helpConfirm.Location = new System.Drawing.Point(579, 663);
            this.helpConfirm.Name = "helpConfirm";
            this.helpConfirm.Size = new System.Drawing.Size(25, 25);
            this.helpConfirm.TabIndex = 71;
            this.helpConfirm.Text = "?";
            this.toolTip1.SetToolTip(this.helpConfirm, "Introduce tu contraseña para asegurarnos de que eres tú.");
            // 
            // helpCorreo
            // 
            this.helpCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpCorreo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpCorreo.ForeColor = System.Drawing.Color.White;
            this.helpCorreo.Location = new System.Drawing.Point(12, 69);
            this.helpCorreo.Name = "helpCorreo";
            this.helpCorreo.Size = new System.Drawing.Size(25, 25);
            this.helpCorreo.TabIndex = 30;
            this.helpCorreo.Text = "?";
            this.helpCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.helpCorreo, "Introduzca un nuevo correo, asegúrese de que sea correcto.");
            // 
            // helpName
            // 
            this.helpName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.helpName.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.helpName.ForeColor = System.Drawing.Color.White;
            this.helpName.Location = new System.Drawing.Point(12, 69);
            this.helpName.Name = "helpName";
            this.helpName.Size = new System.Drawing.Size(25, 25);
            this.helpName.TabIndex = 30;
            this.helpName.Text = "?";
            this.helpName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.helpName, "Por seguridad, su contraseña no puede tener menos de 9 caracteres, entre los cual" +
        "es debe incluirse al menos una mayúscula, una minúscula y dos números.");
            this.helpName.Click += new System.EventHandler(this.Label6_Click);
            // 
            // btnChangeNombre
            // 
            this.btnChangeNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnChangeNombre.FlatAppearance.BorderSize = 0;
            this.btnChangeNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnChangeNombre.Location = new System.Drawing.Point(0, 221);
            this.btnChangeNombre.Name = "btnChangeNombre";
            this.btnChangeNombre.Size = new System.Drawing.Size(182, 40);
            this.btnChangeNombre.TabIndex = 74;
            this.btnChangeNombre.Text = "Cambiar Nombre";
            this.btnChangeNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeNombre.UseVisualStyleBackColor = false;
            this.btnChangeNombre.Click += new System.EventHandler(this.btnChangeNombre_Click);
            // 
            // btnChangePass
            // 
            this.btnChangePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnChangePass.FlatAppearance.BorderSize = 0;
            this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePass.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnChangePass.Location = new System.Drawing.Point(0, 295);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(182, 40);
            this.btnChangePass.TabIndex = 75;
            this.btnChangePass.Text = "Cambiar Contraseña";
            this.btnChangePass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangePass.UseVisualStyleBackColor = false;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // btnChangeCorreo
            // 
            this.btnChangeCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.btnChangeCorreo.FlatAppearance.BorderSize = 0;
            this.btnChangeCorreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeCorreo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btnChangeCorreo.Location = new System.Drawing.Point(0, 256);
            this.btnChangeCorreo.Name = "btnChangeCorreo";
            this.btnChangeCorreo.Size = new System.Drawing.Size(182, 40);
            this.btnChangeCorreo.TabIndex = 74;
            this.btnChangeCorreo.Text = "Cambiar Correo";
            this.btnChangeCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeCorreo.UseVisualStyleBackColor = false;
            this.btnChangeCorreo.Click += new System.EventHandler(this.BtnChangeCarrera_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label11.Location = new System.Drawing.Point(619, 604);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(527, 18);
            this.label11.TabIndex = 68;
            this.label11.Text = "Para guardar cualquier cambio es necesario introducir tu contraseña actual";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPass.Font = new System.Drawing.Font("Arial", 12F);
            this.txtPass.ForeColor = System.Drawing.Color.DimGray;
            this.txtPass.Location = new System.Drawing.Point(623, 662);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(322, 19);
            this.txtPass.TabIndex = 69;
            this.txtPass.TextChanged += new System.EventHandler(this.TxtPass_TextChanged_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(573, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(585, 56);
            this.label9.TabIndex = 25;
            this.label9.Text = "Configuración de cuenta";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.panel4.Controls.Add(this.btnChangePass);
            this.panel4.Controls.Add(this.btnChangeCorreo);
            this.panel4.Controls.Add(this.btnChangeNombre);
            this.panel4.Location = new System.Drawing.Point(367, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(181, 727);
            this.panel4.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label12.Location = new System.Drawing.Point(615, 690);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(327, 3);
            this.label12.TabIndex = 70;
            // 
            // changeEmailPanel
            // 
            this.changeEmailPanel.Controls.Add(this.labelOldCorreo);
            this.changeEmailPanel.Controls.Add(this.label1);
            this.changeEmailPanel.Controls.Add(this.labelCorreo);
            this.changeEmailPanel.Controls.Add(this.txtCorreo);
            this.changeEmailPanel.Controls.Add(this.helpCorreo);
            this.changeEmailPanel.Controls.Add(this.label4);
            this.changeEmailPanel.Location = new System.Drawing.Point(554, 410);
            this.changeEmailPanel.Name = "changeEmailPanel";
            this.changeEmailPanel.Size = new System.Drawing.Size(480, 210);
            this.changeEmailPanel.TabIndex = 65;
            this.changeEmailPanel.Visible = false;
            // 
            // labelOldCorreo
            // 
            this.labelOldCorreo.AutoSize = true;
            this.labelOldCorreo.Font = new System.Drawing.Font("Arial", 12F);
            this.labelOldCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelOldCorreo.Location = new System.Drawing.Point(45, 76);
            this.labelOldCorreo.Name = "labelOldCorreo";
            this.labelOldCorreo.Size = new System.Drawing.Size(89, 18);
            this.labelOldCorreo.TabIndex = 36;
            this.labelOldCorreo.Text = "placeholder";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label1.Location = new System.Drawing.Point(44, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Correo Actual:";
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.Font = new System.Drawing.Font("Arial", 12F);
            this.labelCorreo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelCorreo.Location = new System.Drawing.Point(44, 122);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(105, 18);
            this.labelCorreo.TabIndex = 33;
            this.labelCorreo.Text = "Nuevo Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCorreo.Font = new System.Drawing.Font("Arial", 12F);
            this.txtCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.txtCorreo.Location = new System.Drawing.Point(48, 170);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(387, 19);
            this.txtCorreo.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label4.Location = new System.Drawing.Point(45, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(392, 3);
            this.label4.TabIndex = 35;
            // 
            // namePanel
            // 
            this.namePanel.Controls.Add(this.txtApellido);
            this.namePanel.Controls.Add(this.labelNombre);
            this.namePanel.Controls.Add(this.labelApellido);
            this.namePanel.Controls.Add(this.helpName);
            this.namePanel.Controls.Add(this.label10);
            this.namePanel.Controls.Add(this.txtNombre);
            this.namePanel.Controls.Add(this.label13);
            this.namePanel.Location = new System.Drawing.Point(856, 212);
            this.namePanel.Name = "namePanel";
            this.namePanel.Size = new System.Drawing.Size(480, 210);
            this.namePanel.TabIndex = 65;
            this.namePanel.Visible = false;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellido.Font = new System.Drawing.Font("Arial", 12F);
            this.txtApellido.ForeColor = System.Drawing.Color.DimGray;
            this.txtApellido.Location = new System.Drawing.Point(47, 168);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(387, 19);
            this.txtApellido.TabIndex = 56;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.labelNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelNombre.Location = new System.Drawing.Point(44, 15);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(64, 18);
            this.labelNombre.TabIndex = 27;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido
            // 
            this.labelApellido.AutoSize = true;
            this.labelApellido.Font = new System.Drawing.Font("Arial", 12F);
            this.labelApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelApellido.Location = new System.Drawing.Point(44, 122);
            this.labelApellido.Name = "labelApellido";
            this.labelApellido.Size = new System.Drawing.Size(65, 18);
            this.labelApellido.TabIndex = 33;
            this.labelApellido.Text = "Apellido";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label10.Location = new System.Drawing.Point(45, 198);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(392, 3);
            this.label10.TabIndex = 35;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Font = new System.Drawing.Font("Arial", 12F);
            this.txtNombre.ForeColor = System.Drawing.Color.DimGray;
            this.txtNombre.Location = new System.Drawing.Point(48, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(387, 19);
            this.txtNombre.TabIndex = 31;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.label13.Location = new System.Drawing.Point(48, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(392, 3);
            this.label13.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelEstudiante);
            this.panel1.Controls.Add(this.btnRA);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelCarrera);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(364, 727);
            this.panel1.TabIndex = 73;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(70)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(44, 346);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Administrador";
            // 
            // labelEstudiante
            // 
            this.labelEstudiante.AutoSize = true;
            this.labelEstudiante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstudiante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.labelEstudiante.Location = new System.Drawing.Point(44, 321);
            this.labelEstudiante.Name = "labelEstudiante";
            this.labelEstudiante.Size = new System.Drawing.Size(76, 16);
            this.labelEstudiante.TabIndex = 6;
            this.labelEstudiante.Text = "Placeholder";
            // 
            // btnRA
            // 
            this.btnRA.BorderColor = System.Drawing.Color.Transparent;
            this.btnRA.ButtonColor = System.Drawing.Color.White;
            this.btnRA.FlatAppearance.BorderSize = 0;
            this.btnRA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnRA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRA.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRA.Image = global::SEM.Properties.Resources.backarrow;
            this.btnRA.Location = new System.Drawing.Point(28, 471);
            this.btnRA.Name = "btnRA";
            this.btnRA.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnRA.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnRA.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnRA.Size = new System.Drawing.Size(298, 60);
            this.btnRA.TabIndex = 20;
            this.btnRA.Text = "Volver";
            this.btnRA.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.btnRA.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRA.UseVisualStyleBackColor = true;
            this.btnRA.Click += new System.EventHandler(this.BtnRA_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(361, -2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(3, 729);
            this.label5.TabIndex = 34;
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCarrera
            // 
            this.labelCarrera.AutoSize = true;
            this.labelCarrera.Font = new System.Drawing.Font("Arial", 10F);
            this.labelCarrera.ForeColor = System.Drawing.Color.Black;
            this.labelCarrera.Location = new System.Drawing.Point(44, 283);
            this.labelCarrera.Name = "labelCarrera";
            this.labelCarrera.Size = new System.Drawing.Size(54, 16);
            this.labelCarrera.TabIndex = 18;
            this.labelCarrera.Text = "carrera";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(54, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
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
            this.btnCerrar.Location = new System.Drawing.Point(28, 537);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnCerrar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            this.btnCerrar.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.btnCerrar.Size = new System.Drawing.Size(298, 60);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.Text = "Cerrar Sesión";
            this.btnCerrar.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
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
            this.btnGuardar.Location = new System.Drawing.Point(1022, 644);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(0);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Transparent;
            this.btnGuardar.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(227)))));
            this.btnGuardar.OnHoverTextColor = System.Drawing.Color.Gainsboro;
            this.btnGuardar.Size = new System.Drawing.Size(298, 60);
            this.btnGuardar.TabIndex = 72;
            this.btnGuardar.Text = "Guardar Cambios";
            this.btnGuardar.TextColor = System.Drawing.Color.Silver;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
            // EditAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(222)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.namePanel);
            this.Controls.Add(this.changeEmailPanel);
            this.Controls.Add(this.changePassPanel);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.helpConfirm);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditAdmin";
            this.Text = "SEM - Cuenta";
            this.Load += new System.EventHandler(this.EditAdmin_Load);
            this.changePassPanel.ResumeLayout(false);
            this.changePassPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.changeEmailPanel.ResumeLayout(false);
            this.changeEmailPanel.PerformLayout();
            this.namePanel.ResumeLayout(false);
            this.namePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label helpContraseña;
        private System.Windows.Forms.TextBox txtNewContra;
        private System.Windows.Forms.Label labelConfirmar;
        private System.Windows.Forms.TextBox txtCPass;
        private System.Windows.Forms.Label lineConfirmar;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel changePassPanel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnChangeCorreo;
        private ePOSOne.btnProduct.Button_WOC btnGuardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Label helpConfirm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnChangeNombre;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel changeEmailPanel;
        private System.Windows.Forms.Label labelOldCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label helpCorreo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel namePanel;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido;
        private System.Windows.Forms.Label helpName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelEstudiante;
        private ePOSOne.btnProduct.Button_WOC btnRA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCarrera;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ePOSOne.btnProduct.Button_WOC btnCerrar;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}