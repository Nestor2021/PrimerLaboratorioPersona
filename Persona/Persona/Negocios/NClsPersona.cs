using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Negocio
{
    class NClsPersona
    {
        public String Hablar(ClsPersona persona)
        {
            return "La persona " + persona.Nombre + " esta hablando";        
  
        }

        public String Reir(ClsPersona persona)
        {
            return  persona.Nombre + " se esta riendo";
        }

        public String Caminar(ClsPersona persona)
        {
            return persona.Nombre + " esta caminando por el parque";
        }

        public String Observar(ClsPersona persona)
        {
            return persona.Nombre + " esta observando el partido";
        }

        public String Cantar(ClsPersona persona)
        {
            return persona.Nombre + " esta cantando en el escenario";
        }

        public String Saltar(ClsPersona persona)
        {
            return persona.Nombre + " esta jugando en el saltacuerda";
        }
    }
}
