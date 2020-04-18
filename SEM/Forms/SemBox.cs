using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEM.Forms
{
    public partial class SemBox : Form
    {
        private string tipo;
        private string titulo;
        private string mensaje;
        private string textoBoton;
        public SemBox(string type, string title, string message, string btntext)
        {
            InitializeComponent();
            this.tipo = type;
            this.titulo = title;
            this.mensaje = message;
            this.textoBoton = btntext;
            switch (tipo)
            {
                case "short":
                    this.Width = 400;
                    this.Height = 240;
                    titleLabel.Text = titulo;
                    defButton.Text = textoBoton;
                    defButton.ButtonColor = Color.FromArgb(13, 70, 255);
                    messageText.Visible = false;
                    //Datos de los componentes
                    titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, this.Height * 2 / 6);
                    messageText.Location = new Point(this.Width / 2 - messageText.Width / 2, this.Height * 3 / 6);
                    defButton.Location = new Point(this.Width / 2 - defButton.Width / 2, this.Height * 4 / 6);
                    break;
                case "long":
                    this.Width = 800;
                    this.Height = 480;
                    titleLabel.Text = titulo;
                    messageText.Text = "";
                    messageText.AppendText(mensaje);
                    defButton.Text = textoBoton;
                    defButton.ButtonColor = Color.FromArgb(13, 70, 255);
                    messageText.Visible = true;
                    //Datos de los componentes
                    titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, this.Height * 1 / 6);
                    messageText.Location = new Point(this.Width / 2 - messageText.Width / 2, this.Height * 2 / 6);
                    defButton.Location = new Point(this.Width / 2 - defButton.Width / 2, this.Height * 5 / 6);
                    break;
                case "shorterror":
                    this.Width = 400;
                    this.Height = 240;
                    titleLabel.Text = titulo;
                    defButton.Text = textoBoton;
                    defButton.ButtonColor = Color.FromArgb(255, 13, 70);
                    defButton.OnHoverButtonColor = Color.FromArgb(227, 5, 57);
                    messageText.Visible = false;
                    //Datos de los componentes
                    titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, this.Height * 2 / 6);
                    messageText.Location = new Point(this.Width / 2 - messageText.Width / 2, this.Height * 3 / 6);
                    defButton.Location = new Point(this.Width / 2 - defButton.Width / 2, this.Height * 4 / 6);
                    break;
                case "longerror":
                    this.Width = 800;
                    this.Height = 480;
                    titleLabel.Text = titulo;
                    messageText.Text = "";
                    messageText.AppendText(mensaje);
                    defButton.Text = textoBoton;
                    defButton.ButtonColor = Color.FromArgb(255,13,70);
                    defButton.OnHoverButtonColor = Color.FromArgb(227, 5, 57);
                    messageText.Visible = true;
                    //Datos de los componentes
                    titleLabel.Location = new Point(this.Width / 2 - titleLabel.Width / 2, this.Height * 1 / 6);
                    messageText.Location = new Point(this.Width / 2 - messageText.Width / 2, this.Height * 2 / 6);
                    defButton.Location = new Point(this.Width / 2 - defButton.Width / 2, this.Height * 5 / 6);
                    break;
            }
            defButton.Focus();
            //Datos de la barra superior
            this.ActiveControl = panel2;
            btnClose.Height = panel2.Height;
            btnClose.Location = new Point(this.Width - btnClose.Width, 0);
            panel2.Location = new Point(0, 0);
            panel2.Width = this.Width;

            
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DefButton_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                defButton.PerformClick();
            }
        }
    }
}
