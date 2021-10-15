using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class sede
    {
        private int id;
        private string nombre;
        private administrador administrador;

        public sede()
        {

        }

        public sede(int id, string nombre, administrador a)
        {
            this.id = id;
            this.nombre = nombre;
            this.administrador = a;
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

        public administrador Administrador { get => administrador; set => administrador = value; }
    }
}
