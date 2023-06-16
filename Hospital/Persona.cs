﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Persona
    {
        private int dni;
        private string nombre;
        private int edad;
        private string sexo;
        private int telefono;
        private string email;
        private string vehiculo;
        private string direccion;

        public Persona()
        {
        }

        public Persona(int dni, string nombre, int edad, string sexo, int telefono, string email, string vehiculo, string direccion)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.telefono = telefono;
            this.email = email;
            this.vehiculo = vehiculo;
            this.direccion = direccion;
        }
    }
}