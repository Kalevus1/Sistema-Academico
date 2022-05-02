using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio1
{
    public class Regular : Alumno
    {
        private string creditos;
        private string notas;
        private string semestre;
        private string cursos;

        public string Creditos { get => creditos; set => creditos = value; }
        public string Notas { get => notas; set => notas = value; }
        public string Semestre { get => semestre; set => semestre = value; }
        public string Cursos { get => cursos; set => cursos = value; }

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
    }
}