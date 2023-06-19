using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Paciente : Persona
    {

        private int numPaciente;
        public int NumPaciente { get { return numPaciente; } }
        private string enfermedades;

        public Paciente(int numPaciente, string enfermedades, int dni, string nombre,
        int edad, string sexo, int telefono, string email, string vehiculo, string direccion)
        : base(dni, nombre, edad, sexo, telefono, email, vehiculo, direccion)
        {
            this.numPaciente = numPaciente;
            this.enfermedades = enfermedades;
        }

        public override string ToString()
        {
            return base.ToString() + "Enfermedades: " + enfermedades +"|" + " Nº Paciente: " + numPaciente;
        }

    }
}
