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
            this.btnEvaluate = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panelCuenta = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelUniversidad = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Location = new System.Drawing.Point(529, 142);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(191, 46);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // data
            // 
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(3, 142);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(466, 387);
            this.data.TabIndex = 1;
            this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellClick);
            this.data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_CellContentClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtBuscar.Location = new System.Drawing.Point(0, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(469, 32);
            this.txtBuscar.TabIndex = 2;
            // 
            // cbEleccion
            // 
            this.cbEleccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cbEleccion.FormattingEnabled = true;
            this.cbEleccion.Items.AddRange(new object[] {
            "Docente",
            "Materia"});
            this.cbEleccion.Location = new System.Drawing.Point(529, 12);
            this.cbEleccion.Name = "cbEleccion";
            this.cbEleccion.Size = new System.Drawing.Size(191, 33);
            this.cbEleccion.TabIndex = 3;
            this.cbEleccion.SelectedIndexChanged += new System.EventHandler(this.cbEleccion_SelectedIndexChanged);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.btnEvaluate);
            this.panel.Controls.Add(this.txtBuscar);
            this.panel.Controls.Add(this.btnBuscar);
            this.panel.Controls.Add(this.cbEleccion);
            this.panel.Controls.Add(this.data);
            this.panel.Location = new System.Drawing.Point(171, 83);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(863, 576);
            this.panel.TabIndex = 4;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            // 
            // btnEvaluate
            // 
            this.btnEvaluate.BackColor = System.Drawing.Color.White;
            this.btnEvaluate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEvaluate.ForeColor = System.Drawing.Color.Black;
            this.btnEvaluate.Location = new System.Drawing.Point(529, 227);
            this.btnEvaluate.Name = "btnEvaluate";
            this.btnEvaluate.Size = new System.Drawing.Size(191, 46);
            this.btnEvaluate.TabIndex = 4;
            this.btnEvaluate.Text = "Evaluar";
            this.btnEvaluate.UseVisualStyleBackColor = false;
            this.btnEvaluate.Click += new System.EventHandler(this.btnEvaluate_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.White;
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(532, 3);
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
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnEditar.ForeColor = System.Drawing.Color.Black;
            this.btnEditar.Location = new System.Drawing.Point(326, 3);
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
            this.panelCuenta.Controls.Add(this.btnEditar);
            this.panelCuenta.Controls.Add(this.btnCerrar);
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
            this.panelUniversidad.Controls.Add(this.pictureBox1);
            this.panelUniversidad.Location = new System.Drawing.Point(188, 665);
            this.panelUniversidad.Name = "panelUniversidad";
            this.panelUniversidad.Size = new System.Drawing.Size(766, 322);
            this.panelUniversidad.TabIndex = 7;
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
            this.pictureBox1.Location = new System.Drawing.Point(255, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(236, 223);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Searcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1382, 1015);
            this.Controls.Add(this.panelUniversidad);
            this.Controls.Add(this.panelCuenta);
            this.Controls.Add(this.panel);
            this.Name = "Searcher";
            this.Text = "Searcher";
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
        private System.Windows.Forms.Button btnEvaluate;
    }
}