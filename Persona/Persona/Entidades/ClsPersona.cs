using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona.Entidades
{
    class ClsPersona
    {
        private String nombre;
        private String apellido;
        private int edad;
        private String sexo;
        private int altura;
        private String nacionalidad;
        private String estado;
        private String dui;
        private int peso;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public int Altura { get => altura; set => altura = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Dui { get => dui; set => dui = value; }
        public int Peso { get => peso; set => peso = value; }
    }
}
