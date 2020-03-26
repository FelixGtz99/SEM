using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM.items
{
   public class Materia
    {
        String nombre;
        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public String NOMBRE
        {
            get { return nombre; }
            set { nombre= value; }
        }

        public Materia(int id, String nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public override String ToString()
        {
            return nombre;
        }

    }
}
