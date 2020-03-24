using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEM.items
{
    public class Maestro
    {
        int id;
        String nombre, apellido, alias;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public String NOMBRE
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public String APELLIDO
        {
            get { return apellido; }
            set { apellido = value; }
        }
         public String ALIAS
        {
            get { return alias; }
            set { alias = value; }
        }
        public Maestro(int id, String nombre, String apellido, String alias) {
            this.alias = alias;
            this.apellido = apellido;
            this.nombre = nombre;
        }

        public override String ToString() {
            return nombre + " " + apellido;
        }
       
    }
}
