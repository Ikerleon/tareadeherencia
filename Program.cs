using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados oempleados = new Empleados("Juan","Palma",1356841250,"casado",2000,"A050");
            oempleados.Mostrar();
            Estudiantes oestudiantes = new Estudiantes("Roberto","Cobeña",1354789632,"soltero","B");
            oestudiantes.Mostrar();
            Profesores oprofesores = new Profesores("Luis","Mario",1354896354,"viudo","matematicas");
            oprofesores.Mostrar();
            PersonalServicio opersonal = new PersonalServicio("Jordan","Moran",1352478962,"casado","biblioteca");
            opersonal.Mostrar();
        }
    }
}
