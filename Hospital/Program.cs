using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hospital
{
    internal static class Program
    {
        public static Hospital hospital = new Hospital();
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormHospital(hospital));
        }  
            static void AltaMedico()
            {

                Console.WriteLine("Ingrese datos medico:");
                Console.WriteLine("Ingrese numero de colegiado:");
                int numColegiado = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nombre:");
                string txtNombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido:");
                string txtApellido = Console.ReadLine();
                Console.WriteLine("Ingrese DNI:");
                int dniMedico = int.Parse(Console.ReadLine());

            Medico medico1 = new Medico(numColegiado, txtNombre, txtApellido, dniMedico);

            }
            static void AltaAdministrativo()
            {
                Console.WriteLine("Ingrese datos del administrativo:");
                Console.WriteLine("Ingrese numero de trabajador:");
                int numeroTrabajador = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido:");
                string apellidos = Console.ReadLine();
                Console.WriteLine("Ingrese DNI:");
                int dni = int.Parse(Console.ReadLine());

                hospital.AltaAdministrativo(numeroTrabajador, nombre, apellidos, dni);
            }
            static void AltaPaciente()
            {
                Console.WriteLine("Ingrese datos del paciente:");
                Console.WriteLine("Ingrese Numero Historia Clinica:");
                int numeroHistoriaClinica = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese apellido:");
                string apellidos = Console.ReadLine();
                Console.WriteLine("Ingrese DNI:");
                int dni = int.Parse(Console.ReadLine());

                hospital.AltaPaciente(numeroHistoriaClinica, nombre, apellidos, dni);
            }
            static void ListarMedicos()
            {
                Console.WriteLine("Lista de medicos");
                hospital.ListarMedicos();
            }
            static void EliminarPaciente()
            {
                Console.WriteLine("Lista de pacientes");
                hospital.EliminarPaciente();
            }

            static void TotalHospital()
            {
                hospital.TotalHospital();
            }

            static void ListarPacientesMedico()
            {
                hospital.ListarPacientesMedico();
            }
        }
}
