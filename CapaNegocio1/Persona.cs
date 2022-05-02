﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio1
{
    public class Persona
    {
        // atributos
        private string codigo;
        private string apellidos;
        private string nombres;
        private DateTime fechaNac;
        private string lugarNac;
        private string domicilio;
        private string correo;
        
        // propiedades
        public string Codigo { get => codigo; set => codigo = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public string LugarNac { get => lugarNac; set => lugarNac = value; }
        public string Domicilio { get => domicilio; set => domicilio = value; }
        public string Correo { get => correo; set => correo = value; }

        // Metodos
        public string Existir()
        {
            return "El metodo existir no ha sido implementado";
        }
        public string Asistir()
        {
            return "El metodo asistir no ha sido implementado";
        }
        
    }
}
