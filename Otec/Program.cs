using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OtecLibrary;

namespace Otec
{
    class Program
    {
        static void Main(string[] args)
        {
            administrador admin = new administrador(1, "Admin");
            sede LosAngeles = new sede(1,"LosAngeles",admin);
            cordinador cordinador1 = new cordinador(1, "Cordinador");
            asignatura a1 = new asignatura(1, "Matematica");
            asignatura a2 = new asignatura(2, "Lenguaje");
            asignatura a3 = new asignatura(3, "Ingles");
            List<asignatura> la1 = new List<asignatura>();
            la1.Add(a1);
            la1.Add(a2);
            la1.Add(a3);
            curso curso1 = new curso(1,"Administracion", la1, cordinador1, LosAngeles);
            Console.WriteLine(curso1.datosCurso());
            Console.ReadKey();

        }
    }
}
