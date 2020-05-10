using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM.items
{
    class Escuela
    {
        int id;
        String nombre; String correo; String logo;

        public Escuela(int id, string nombre, string correo, string logo)
        {
            this.logo = logo;
            this.id = id;
            this.nombre = nombre;
            this.correo = correo;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Logo { get => logo; set => logo = value; }

        public override String ToString()
        {
            return nombre;
        }
    }

}
