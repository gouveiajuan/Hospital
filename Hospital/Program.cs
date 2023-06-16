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
            Hospital H = new Hospital();
            Console.WriteLine("Vamos a crear una base de datos del Hospital de Barcelona");

            Medico m1 = new Medico(123, "Urologo", 123456, "Jose", 45, "No binario", 623548965,
                "josejosejose@gmail.com", "Ferrari", "Arco del Triunfo, Barcelona");
            Medico m2 = new Medico(456, "Traumatologo", 488582, "Maria", 69, "Mujer", 645892542,
                "mariamaria@gmail.com", "Ferrari", "La Barceloneta, Barcelona");

            H.AgregarMedicoAuto(m1);
            H.AgregarMedicoAuto(m2);
            //H.EliminarMedicoAuto(m1);

            Paciente p1 = new Paciente(231, "Bronquitis", 58456, "Juan", 32, "Hombre", 64458911,
                "juanjuan@gmail.com", "Citroen", "El Raval, Barcelona");
            Paciente p2 = new Paciente(333, "Sida", 58456, "Alex", 17, "Hombre", 64465811,
                "aleeeex@gmail.com", "N/A", "Zona Franca, Barcelona");

            H.AgregarPacienteAuto(p1);
            H.AgregarPacienteAuto(p2);
            //H.EliminarPacienteAuto(p1);

            Console.WriteLine("\nCreemos la base de datos del hospital");

            bool i = false;

            while (!i)
            {
                Console.WriteLine("\n       Ingresa (0) para AGREGAR un medico"
                                + "\n       Ingresa (1) para AGREGAR un paciente"
                                + "\n       Ingresa (2) para ELIMINAR un medico"
                                + "\n       Ingresa (3) para ELIMINAR un paciente"
                                + "\n       Ingresa (4) para salir\n");

                bool a = false;
                int opcion = int.Parse(Console.ReadLine());
                while (!a)
                {
                    switch (opcion)
                    {
                        case 0:
                            Console.WriteLine("Vamos a agregar un Medico");
                            H.AgregarMedicoManual();
                            a = true;
                            break;
                        case 1:
                            Console.WriteLine("Vamos a agregar un Paciente");
                            H.AgregarPacienteManual();
                            a = true;
                            break;
                        case 2:
                            Console.WriteLine("Vamos a eliminar un Medico"
                                + "Ingresa el numero de colegiado ");
                            int j = int.Parse(Console.ReadLine());
                            H.EliminarMedicoManual(j);
                            a = true;
                            break;
                        case 3:
                            Console.WriteLine("Vamos a eliminar un Paciente"
                                + "Ingresa el numero de paciente ");
                            int k = int.Parse(Console.ReadLine());
                            H.EliminarPacienteManual(k);
                            a = true;
                            break;
                        case 4:
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
