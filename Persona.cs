using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaDeProgramacion
{
    class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Cedula { get; set; }
        public string EstadoCivil { get; set; }
        public Persona(string Nombre, string Apellido, int Cedula, string EstadoCivil)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;   
            this.EstadoCivil = EstadoCivil; 
            this.Cedula = Cedula; 
        }
        public void CambioEstado()
        {
            string estadonuevo = "", respuesta = "";
            do
            {
                Console.WriteLine("Desea cambiar su estado Civil");
                Console.WriteLine("si");
                Console.WriteLine("no");
                respuesta = Console.ReadLine();
            }while(respuesta!="si" && respuesta!="no");   
            if (respuesta=="si")
            {
                do
                {
                    Console.WriteLine("Ingrese el nuevo estado civil");
                    estadonuevo = Console.ReadLine();
                } while (estadonuevo != null && estadonuevo != "viudo" && estadonuevo != "soltero" && estadonuevo!="casado");
                EstadoCivil = estadonuevo;
            }
        }


    }
}
