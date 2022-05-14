using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeProgramacion
{
    class Estudiantes : Persona
    {
        public string CursoMatri { get; set; }
        public Estudiantes(string Nombre, string Apellido, int Cedula, string EstadoCivil,string CursoMatri): base (Nombre,Apellido,Cedula,EstadoCivil)
        {
            this.CursoMatri = CursoMatri;
        }
        public void Mostrar()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("    Matriculacion de Estudiantes");
            Console.WriteLine("Curso Asignado: " + CursoMatri);
            Console.WriteLine("Nombre: " + Nombre + " - Apellido: " + Apellido);
            Console.WriteLine("Numero de Identificacion: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            opcion();
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------");
        }
        public void opcion()
        {
            String opciones;
            Console.WriteLine("             Opciones alternas:");
            Console.WriteLine("Si desea cambiar el curso digite 0");
            Console.WriteLine("Si desea cambiar el Estado Civil digite 1");
            Console.WriteLine("Si desea salir digite 2 ");
            opciones = Console.ReadLine();
            Cambio(opciones);
        }
        public void Cambio(String cambios)
        {

            switch (cambios.ToString())
            {
                case "0":
                    CursoNuevo();
                    break;
                case "1":
                    CambioEstado();
                    break;
                case "2":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void CursoNuevo()
        {
            String nuevocurso;
            Console.WriteLine("Ingrese el nuevo Curso");
            nuevocurso = Console.ReadLine();
            CursoMatri = nuevocurso;
        }
    }
}
