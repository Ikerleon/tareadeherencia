using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeProgramacion
{
    class Profesores : Persona
    {
        public string Departamento { get; set; }
        public Profesores(string Nombre, string Apellido, int Cedula, string EstadoCivil,string Departamento): base(Nombre, Apellido,Cedula,EstadoCivil)
        {
            this.Departamento = Departamento;
        }
        public void Mostrar()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("    Personal de Profesores");
            Console.WriteLine("Departamento Asignada: " + Departamento);
            Console.WriteLine("Nombre: " + Nombre + " - Apellido: " + Apellido);
            Console.WriteLine("Numero de Identificacion: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            opcion();
            Console.WriteLine("--------------------------------------------");
        }
        public void opcion()
        {
            String opciones;
            Console.WriteLine("Opciones alternas:");
            Console.WriteLine("Si desea cambiar el departamento digite 0");
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
                    CambioDepartamento();
                    break;
                case "1":
                    CambioEstado();
                    break;
                case "3":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void CambioDepartamento()
        {
            String nuevodepartamento;
            Console.WriteLine("Ingrese el nuevo departamento");
            nuevodepartamento = Console.ReadLine();
            Departamento = nuevodepartamento;
        }
    }
}
