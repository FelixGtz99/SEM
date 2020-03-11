using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace SEM
{
    public partial class Login : Form
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        public Login()
        {
            InitializeComponent();
            iniciarConexion();
        }

        public void iniciarConexion() {
            try
            {
                conexion.ConnectionString = "Username = AdminDB; Password=1234; Host = localhost; Port = 5432; Database = SEM";
                conexion.Open();
                MessageBox.Show("Conexion correcta");
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);

            }
        }

        public void consultar() {
           
            String sql = "Select * From usuarios Where correo=@c and contraseña=@p";
            NpgsqlCommand command = new NpgsqlCommand(sql, conexion);
            command.Parameters.AddWithValue("c", txtEmail.Text);
            command.Parameters.AddWithValue("p", txtPass.Text);
            NpgsqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                MessageBox.Show("Ingresaste correctamente");

            }
            else {
                MessageBox.Show("No existe");
            }
          
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            consultar();
        }
    }
}
