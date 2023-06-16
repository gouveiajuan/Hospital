using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Medico : Persona
    {
        private int numColegiado;
        public int NumColegiado { get {return numColegiado;} }
        private string especialidad;

        public Medico(int numColegiado, string especialidad, int dni, string nombre,
            int edad, string sexo, int telefono, string email, string vehiculo, string direccion)
            : base(dni, nombre, edad, sexo, telefono, email, vehiculo, direccion)
        {
            this.numColegiado = numColegiado;
            this.especialidad = especialidad;
        }
    }
}
