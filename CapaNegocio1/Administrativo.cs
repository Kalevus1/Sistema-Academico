using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio1
{
    public class Administrativo : Persona
    {
        private string cargo;
        private string puesto;
        private string especialidad;
        private string sueldo;

        public string Cargo { get => cargo; set => cargo = value; }
        public string Puesto { get => puesto; set => puesto = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Sueldo { get => sueldo; set => sueldo = value; }

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