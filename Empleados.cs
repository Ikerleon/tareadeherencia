using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeProgramacion
{
    class Empleados : Persona
    {
        public int AñoIncorporacion { get; set; }
        public string NuDespacho { get; set; }
        public Empleados(string Nombre, string Apellido, int Cedula, string EstadoCivil,int AñoIncorporacion,string NuDespacho): base(Nombre, Apellido,Cedula,EstadoCivil)
        {
            this.AñoIncorporacion = AñoIncorporacion;
            this.NuDespacho = NuDespacho;
        }
        public void Mostrar()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("            Empleados        ");
            Console.WriteLine("Numero de Despacho: " + NuDespacho);
            Console.WriteLine("Año de incorporacion: " + AñoIncorporacion);
            Console.WriteLine("Nombre: " + Nombre + "  Apellido: " + Apellido);
            Console.WriteLine("Numero de Identificacion: " + Cedula);
            Console.WriteLine("Estado Civil: " + EstadoCivil);
            opcion();
            Console.WriteLine("--------------------------------------------");
        }
        public void opcion()
        {
            String opciones;
            Console.WriteLine("Si desea cambiar el despacho ingrese: 0");
            Console.WriteLine("Si desea cambiar el Estado Civil ingrese: 1");
            Console.WriteLine("Si desea salir ingrese: 2");
            opciones= Console.ReadLine();
            Cambio(opciones);
        }
        public void Cambio(String cambios)
        {

            switch (cambios.ToString())
            {
                case "0":
                    cambio_espacho();
                    break;
                case "1":
                    CambioEstado();
                    break;
                case "2":
                    Console.WriteLine("....");
                    break;

            }
        }
            public void cambio_espacho()
            {
                String espacho_new;
                Console.WriteLine("Ingrese el nuevo espacho");
                espacho_new = Console.ReadLine();
                NuDespacho = espacho_new;
            }

    }
}
