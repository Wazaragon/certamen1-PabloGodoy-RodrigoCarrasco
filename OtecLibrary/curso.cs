using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class curso
    {
        private int id;
        private string nombre;
        private List<asignatura> asignaturas;
        private cordinador cordinador;
        private sede sede;

        public curso()
        {

        }
        public curso(int id, string nombre, List<asignatura> la, cordinador c, sede s)
        {
            this.id = id;
            this.nombre = nombre;
            this.asignaturas = la;
            this.cordinador = c;
            this.sede = s;
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

        public cordinador Cordinador { get => cordinador; set => cordinador = value; }
        public List<asignatura> Asignaturas { get => asignaturas; set => asignaturas = value; }
        public sede Sede { get => sede; set => sede = value; }

        public int cantidadAsignaturas(List<asignatura> la)
        {
            int contador = 0;
            foreach (var item in la)
            {
                contador++;
            }
            return contador;
        } 

        public string datosCurso()
        {
            return "Nombre Sede: "+sede.Nombre+"\nNombre Encargado: "+sede.Administrador.Nombre+"\nNombre Curso: "+nombre+"\nCantidad de Asignaturas: "+cantidadAsignaturas(asignaturas)+"\nNombre Cordinador: "+cordinador.Nombre;
        }
    }
}
