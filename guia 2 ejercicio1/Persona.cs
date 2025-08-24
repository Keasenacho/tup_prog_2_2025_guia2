using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Guia2
{
    public class Persona
    {

        int Dni { get; set; }
        string Nombre { get; set; }


        public Persona(int dni, string nombre)
        {

            this.Dni = dni;
            this.Nombre = nombre;
        }
        public string Describir()
        {
            return $"{Dni} - {Nombre}";
        }
    }

}
