using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio1
{
    public class Docente : Persona
    {
        private string cursos;
        private string afp;
        private string profesion;

        public string Cursos { get => cursos; set => cursos = value; }
        public string Afp { get => afp; set => afp = value; }
        public string Profesion { get => profesion; set => profesion = value; }

        public string Actualizar()
        {
            throw new System.NotImplementedException();
        }

        public string Agregar()
        {
            throw new System.NotImplementedException();
        }

        public string Buscar()
        {
            throw new System.NotImplementedException();
        }

        public string Eliminar()
        {
            throw new System.NotImplementedException();
        }
    }
}