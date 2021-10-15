using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class cordinador
    {
        private int id;
        private string nombre;

        public cordinador()
        {

        }

        public cordinador(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

    }
}
