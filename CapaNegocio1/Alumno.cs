using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio1
{
    public class Alumno : Persona
    {
        private bool seguro;
        private string escuela;
        private string carrera;

        public bool Seguro { get => seguro; set => seguro = value; }
        public string Escuela { get => escuela; set => escuela = value; }
        public string Carrera { get => carrera; set => carrera = value; }

        public string Estudiar()
        {
            return "El metodo estudiar no ha sido implementado";      
        }
    }
}
