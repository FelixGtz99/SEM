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
            this.btnBuscar = new System.Windows.Forms.Button();
            this.data = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.cbEleccion = new System.Windows.Forms.ComboBox();
            this.panel = new System.Windows.Forms.Panel();
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelCuenta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUniversidad = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRA = new System.Windows.Forms.Button();
            this.btnRegistrarD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.panel.SuspendLayout();
            this.panelCuenta.SuspendLayout();
            this.panelUniversidad.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(519, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(191, 46);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // data
            // 
            this.data.AllowUserToAddRows = false;
            this.data.AllowUserToDeleteRows = false;
            this.data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.data.Location = new System.Drawing.Point(134, 176);
            this.data.Name = "data";
            this.data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data.Size = new System.Drawing.Size(466, 387);
            this.data.TabIndex = 1;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBuscar.Location = new System.Drawing.Point(6, 97);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(469, 32);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbEleccion
            // 
            this.cbEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbEleccion.FormattingEnabled = true;
            this.cbEleccion.Items.AddRange(new object[] {
            "Docente",
            "Materia"});
            this.cbEleccion.Location = new System.Drawing.Point(134, 32);
            this.cbEleccion.Name = "cbEleccion";
            this.cbEleccion.Size = new System.Drawing.Size(191, 33);
            this.cbEleccion.TabIndex = 3;
            this.cbEleccion.SelectedIndexChanged += new System.EventHandler(this.cbEleccion_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.label4);
            this.panel.Controls.Add(this.label3);
            this.panel.Controls.Add(this.btnRegistrarD);
            this.panel.Controls.Add(this.btnEvaluar);
            this.panel.Controls.Add(this.btnVer);
            this.panel.Controls.Add(this.txtBuscar);
            this.panel.Controls.Add(this.btnBuscar);
            this.panel.Controls.Add(this.cbEleccion);
            this.panel.Controls.Add(this.data);
            this.panel.Location = new System.Drawing.Point(303, 96);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(941, 576);
            this.panel.TabIndex = 4;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.BackColor = System.Drawing.Color.White;
            this.btnEvaluar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaluar.ForeColor = System.Drawing.Color.Black;
            this.btnEvaluar.Location = new System.Drawing.Point(672, 322);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(191, 46);
            this.btnEvaluar.TabIndex = 5;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = false;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // btnVer
            // 
            this.btnVer.BackColor = System.Drawing.Color.White;
            this.btnVer.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVer.ForeColor = System.Drawing.Color.Black;
            this.btnVer.Location = new System.Drawing.Point(672, 242);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(191, 46);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = false;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(34, 590);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(191, 46);
            this.btnCerrar.TabIndex = 4;
            this.btnCerrar.Text = "Cerrar Sesion";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.White;
            this.btnEditar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(34, 528);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(191, 46);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar Cuenta";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // panelCuenta
            // 
            this.panelCuenta.Controls.Add(this.label1);
            this.panelCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.panelCuenta.ForeColor = System.Drawing.Color.White;
            this.panelCuenta.Location = new System.Drawing.Point(105, 12);
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
            // panelUniversidad
            // 
            this.panelUniversidad.Controls.Add(this.label2);
            this.panelUniversidad.Location = new System.Drawing.Point(188, 665);
            this.panelUniversidad.Name = "panelUniversidad";
            this.panelUniversidad.Size = new System.Drawing.Size(766, 322);
            this.panelUniversidad.TabIndex = 7;
            this.panelUniversidad.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(136, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(453, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = "Universidad de sonora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "D:\\Programacion\\escudo.png";
            this.pictureBox1.Location = new System.Drawing.Point(12, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 236);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnRA
            // 
            this.btnRA.BackColor = System.Drawing.Color.White;
            this.btnRA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRA.ForeColor = System.Drawing.Color.Black;
            this.btnRA.Location = new System.Drawing.Point(34, 449);
            this.btnRA.Name = "btnRA";
            this.btnRA.Size = new System.Drawing.Size(191, 62);
            this.btnRA.TabIndex = 5;
            this.btnRA.Text = "Actividad Reciente";
            this.btnRA.UseVisualStyleBackColor = false;
            this.btnRA.Click += new System.EventHandler(this.btnRA_Click);
            // 
            // btnRegistrarD
            // 
            this.btnRegistrarD.BackColor = System.Drawing.Color.White;
            this.btnRegistrarD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarD.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrarD.Location = new System.Drawing.Point(672, 426);
            this.btnRegistrarD.Name = "btnRegistrarD";
            this.btnRegistrarD.Size = new System.Drawing.Size(191, 62);
            this.btnRegistrarD.TabIndex = 8;
            this.btnRegistrarD.Text = "Registrar Docente";
            this.btnRegistrarD.UseVisualStyleBackColor = false;
            this.btnRegistrarD.Click += new System.EventHandler(this.btnRegistrarD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Búsqueda";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(158, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tipo de Búsqueda";
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1350, 747);
            this.Controls.Add(this.btnRA);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panelUniversidad);
            this.Controls.Add(this.panelCuenta);
            this.Controls.Add(this.panel);
            this.Name = "Searcher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Searcher";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Searcher_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.panelCuenta.ResumeLayout(false);
            this.panelCuenta.PerformLayout();
            this.panelUniversidad.ResumeLayout(false);
            this.panelUniversidad.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ComboBox cbEleccion;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Panel panelCuenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelUniversidad;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnRA;
        private System.Windows.Forms.Button btnRegistrarD;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}