using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaNegocio1
{
    public class Ingresante : Alumno
    {
        private string metodoingreso;
        private DateTime fechaing;
        private string puesto;

        public string Metodoingreso { get => metodoingreso; set => metodoingreso = value; }
        public DateTime Fechaing { get => fechaing; set => fechaing = value; }
        public string Puesto { get => puesto; set => puesto = value; }

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