using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hospital
{
    public class Hospital
    {
        public List<Medico> listaMedicos = new List<Medico>();
        public List<Paciente> listaPacientes = new List<Paciente>();

        public void AgregarMedicoAuto(Medico m)
        {   /*        
            Medico m1 = new Medico(123, "Urologo", 123456, "Jose", 45, "No binario", 623548965,
            "josejosejose@gmail.com", "Ferrari", "Arco del Triunfo, Barcelona");
            Medico m2 = new Medico(456, "Traumatologo", 488582, "Maria", 69, "Mujer", 645892542,
                "mariamaria@gmail.com", "Ferrari", "La Barceloneta, Barcelona");
            listaMedicos.Add(m1);*/
            listaMedicos.Add(m);
            Console.WriteLine("El medico se ha añadido correctamente");
            Console.ReadKey();
        }

        public void EliminarMedicoAuto(Medico m)
        {

                    Console.WriteLine("Se ha borrado el medico correctamente");
                    listaMedicos.Remove(m);
                    Console.ReadKey();

        }

        public void AgregarPacienteAuto(Paciente p)
        {   
            listaPacientes.Add(p);
            Console.WriteLine("El paciente se ha añadido correctamente");
            Console.ReadKey();
        }

        public void EliminarPacienteAuto(Paciente p)
        {  
                    Console.WriteLine("Se ha borrado el paciente con número: ");
                    listaPacientes.Remove(p);
                    Console.ReadKey();

        }
        public void AgregarMedicoManual()
        {
            Console.Write("Número de colegiado: ");
            int numColegiado1 = int.Parse(Console.ReadLine());

            Console.Write("Especialidad: ");
            string especialidad1 = Console.ReadLine();

            Console.Write("DNI: ");
            int dni1 = int.Parse(Console.ReadLine());

            Console.Write("Nombre: ");
            string nombre1 = Console.ReadLine();

            Console.Write("Edad: ");
            int edad1 = int.Parse(Console.ReadLine());

            Console.Write("Sexo: ");
            string sexo1 = Console.ReadLine();

            Console.Write("Telefono: ");
            int telefono1 = int.Parse(Console.ReadLine());

            Console.Write("Email: ");
            string email1 = Console.ReadLine();

            Console.Write("Vehiculo: ");
            string vehiculo1 = Console.ReadLine();

            Console.Write("Direccion: ");
            string direccion1 = Console.ReadLine();

            Medico medico = new Medico(numColegiado1, especialidad1, dni1, nombre1, edad1,
                            sexo1, telefono1, email1, vehiculo1, direccion1);
            listaMedicos.Add(medico);
            Console.WriteLine("Se ha añadido correctamente");
        }

        public void EliminarMedicoManual(int numColegiado2)
        {
            foreach (Medico m in listaMedicos)
            {
                if (m.NumColegiado == numColegiado2)
                {
                    Console.WriteLine("Se ha borrado el medico con número de colegiado: " + numColegiado2);
                    listaMedicos.Remove(m);
                }
                else Console.WriteLine("Ese número de colegiado no existe");
            }

        }

        public void AgregarPacienteManual(int numPaciente1, string enfermedades1, int dni1, string nombre1,
        int edad1, string sexo1, int telefono1, string email1, string vehiculo1, string direccion1)
        {
            Paciente paciente = new Paciente(numPaciente1, enfermedades1, dni1, nombre1, edad1,
                            sexo1, telefono1, email1, vehiculo1, direccion1);
            listaPacientes.Add(paciente);
            Console.WriteLine("Se ha añadido correctamente");
            Console.ReadKey();
        }

        public void EliminarPacienteManual(int numPaciente1)
        {
            foreach (Paciente p in listaPacientes)
            {
                if (p.NumPaciente == numPaciente1)
                {
                    Console.WriteLine("Se ha borrado el paciente con número de paciente: " + numPaciente1);
                    listaPacientes.Remove(p);
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Ese número de paciente no existe");
                    Console.ReadKey();
                }
            }

        }
    }
}
