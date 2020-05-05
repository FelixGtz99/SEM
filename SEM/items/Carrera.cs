using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM.items
{
    class Carrera
    {
        int id, id_escuela;
        String nombre;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int ID_ESCUELA
        {
            get { return id_escuela; }
            set { id_escuela = value; }
        }
        public String NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public Carrera(int id, String nombre,int id_escuela)
        {
            this.id = id;
            this.id_escuela = id_escuela;
            this.nombre = nombre;
        }

        public override String ToString()
        {
            return nombre ;
        }

    }
}
