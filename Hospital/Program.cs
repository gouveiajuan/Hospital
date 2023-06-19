using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Vamos a crear una base de datos del Hospital de Barcelona");
            Menu();

        }

        public static void Menu()
        {
            Hospital h = new Hospital();
            Console.WriteLine("\nCreemos la base de datos del hospital");
            
            /*      Prueba para añadir medicos y pacientes al programa
             
            Medico m1 = new Medico(123, "Urologo", 123456, "Jose", 45, "No binario", 623548965,
            "josejosejose@gmail.com", "Ferrari", "Arco del Triunfo, Barcelona");
            Medico m2 = new Medico(456, "Traumatologo", 488582, "Maria", 69, "Mujer", 645892542,
            "mariamaria@gmail.com", "Ferrari", "La Barceloneta, Barcelona");

            Paciente p1 = new Paciente(231, "Bronquitis", 58456, "Juan", 32, "Hombre", 64458911,
            "juanjuan@gmail.com", "Citroen", "El Raval, Barcelona", 123);
            Paciente p2 = new Paciente(333, "Sida", 58456, "Alex", 17, "Hombre", 64465811,
                "aleeeex@gmail.com", "N/A", "Zona Franca, Barcelona", 123);

              h.AgregarPacienteAuto(p1);
            h.AgregarPacienteAuto(p2);

            h.AgregarMedicoAuto(m1);
            h.AgregarMedicoAuto(m2); */

            bool i = false;

            while (!i)
            {
                Console.WriteLine("\n       Ingresa (0) para AGREGAR un medico"
                                + "\n       Ingresa (1) para AGREGAR un paciente"
                                + "\n       Ingresa (2) para ELIMINAR un medico"
                                + "\n       Ingresa (3) para ELIMINAR un paciente"
                                + "\n       Ingresa (4) para Mostrar lista de Medicos"
                                + "\n       Ingresa (5) para Mostrar lista de Pacientes"
                                + "\n       Ingresa (6) para Mostrar lista de Pacientes que tiene un medico"
                                + "\n       Ingresa (7) para Mostrar todo lo que tiene el Hospital"
                                + "\n       Ingresa (8) para salir\n");

                bool a = false;
                int opcion = int.Parse(Console.ReadLine());
                while (!a)
                {
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Vamos a agregar un Medico");
                            h.AgregarMedicoManual();
                            a = true;
                            break;
                        case 1:
                            Console.WriteLine("Vamos a agregar un Paciente");
                            h.AgregarPacienteManual();
                            a = true;
                            break;
                        case 2:
                            Console.WriteLine("Vamos a eliminar un Medico"
                                + "\nIngresa el numero de colegiado ");
                            int j = int.Parse(Console.ReadLine());
                            h.EliminarMedicoManual(j);
                            a = true;
                            break;
                        case 3:
                            Console.WriteLine("Vamos a eliminar un Paciente"
                                + "\nIngresa el numero de paciente ");
                            int k = int.Parse(Console.ReadLine());
                            h.EliminarPacienteManual(k);
                            a = true;
                            break;
                        case 4:
                            h.MostrarMedicos();
                            a = true;
                            break;
                        case 5:
                            h.MostrarPacientes();
                            a = true;
                            break;
                        case 6:
                            h.MedicoPaciente();
                            a = true;
                            break;
                        case 7:
                            h.MostrarMedicos();
                            h.MostrarPacientes();
                            a= true;
                            break;
                        case 8:
                            i = true;
                            break;
                        default:
                            break;

                    }
                }
            }
        }
    }
}
