using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeProgramacion
{
    class PersonalServicio : Persona
    {
        public string Sección { get; set; }
        public PersonalServicio(string Nombre, string Apellido, int Cedula, string EstadoCivil,string Sección): base (Nombre,Apellido,Cedula,EstadoCivil)
        {
            this.Sección = Sección;
        }
        public void Mostrar()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("    Personal del trabajo");
            Console.WriteLine("Seccion Asignada: " + Sección);
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
            Console.WriteLine("Opciones alternas:");
            Console.WriteLine("Si desea hacer un traslado de sección de un empleado digite 0");
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
                    Cambiar();
                    break;
                case "1":
                    CambioEstado();
                    break;
                case "2":
                    Console.WriteLine("....");
                    break;

            }

        }
        public void Cambiar()
        {
            String nuevotraslado;
            Console.WriteLine("Ingrese el nuevo traslado de seccion");
            nuevotraslado = Console.ReadLine();
            Sección = nuevotraslado;
        }
    }
}
