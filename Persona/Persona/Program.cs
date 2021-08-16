using Persona.Entidades;
using Persona.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsPersona clspersona = new ClsPersona();
            NClsPersona nclspersona = new NClsPersona();

            clspersona.Nombre = "Martín";
            clspersona.Apellido = "Tejada";
            clspersona.Edad = 20;
            clspersona.Estado = "Soltero";
            clspersona.Nacionalidad = "Salvadoreña";

            Console.WriteLine(nclspersona.Hablar(clspersona));
            Console.ReadLine();




        }
    }
}
