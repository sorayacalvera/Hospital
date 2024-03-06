using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
        public class Hospital
        {
            List<Medico> medicos = new List<Medico>();
            List<Administrativo> administrativos = new List<Administrativo>();
            List<Paciente> pacientes = new List<Paciente>();

            public List<Medico> Medicos
            {
                get => medicos; set => medicos = value;
            }
            public List<Administrativo> Administrativos
            {
                get => administrativos; set => administrativos = value;
            }
            public List<Paciente> Pacientes
            {
                get => pacientes; set => pacientes = value;
            }

            public Hospital()
            {
                Medico medico = new Medico(1235, "Pepito", "Sanchez", 1235886);
                Medicos.Add(medico);

                Administrativo administrativo = new Administrativo(1111, "Lola", "Martinez", 2222);
                Administrativos.Add(administrativo);

                Paciente paciente = new Paciente(1452, "Maria", "Jimenez", 14785);
                Pacientes.Add(paciente);

                paciente.MedicoAsignado = medico;

            }
            public void AltaMedico(int numCol, string nomMedic, string apelliMedic, int dniMedic)
            {

                Medico medico1 = new Medico(numCol, nomMedic, apelliMedic, dniMedic);
                Medicos.Add(medico1);

            }

            public void AltaAdministrativo(int numeroTrabajador, string nombre,
                string apellidos, int dni)
            {
                Administrativo administrativo1 = new Administrativo(numeroTrabajador, nombre, apellidos, dni);
                Administrativos.Add(administrativo1);
            }

            public void AltaPaciente(int numeroHistoriaClinica, string nombre,
                string apellidos, int dni)
            {
                Paciente paciente1 = new Paciente(numeroHistoriaClinica, nombre, apellidos, dni);
                Pacientes.Add(paciente1);
                paciente1.MedicoAsignado = EscogerMedico();//Llamar al metodo!!!!!
                paciente1.MedicoAsignado.AsignarPaciente(paciente1);
            }

            public Medico EscogerMedico()
            {
                Console.WriteLine("Que medico quieres?");
                for (int i = 0; i < Medicos.Count; i++)
                {
                    Console.WriteLine((i + 1) + " - " + medicos[i]);
                }
                Console.WriteLine("Cual quiere?");
                int num = int.Parse(Console.ReadLine());
                Medico medico = medicos[num - 1];

                return medico;
            }

            public void ListarMedicos()
            {
                for (int i = 0; i < Medicos.Count; i++)
                {
                    Console.WriteLine((i + 1) + " - " + medicos[i]); //ponemos +1 para mostrar por pantalla desde el 1
                }
            }

            public void ListarPacientesMedico()
            {
                Console.WriteLine("De que medico quieres ver sus pacientes?:");
                ListarMedicos();
                int num = int.Parse(Console.ReadLine());
                Medico medico = medicos[num - 1]; //se resta 1 porque en el for hemos puesto +1 para mostrar en pantalla desde el num 1
                Console.WriteLine("Estos son los pacientes del medico:");
                foreach (Paciente p in medico.pacientesAsignados)
                //for(int i = 0; i < medico.pacientesAsignados.Count; i++ )
                {
                    Console.WriteLine(p);
                }
            }

            public void EliminarPaciente()
            {
                for (int i = 0; i < Pacientes.Count; i++)
                {
                    Console.WriteLine((i + 1) + " - " + pacientes[i]);
                }
                Console.WriteLine("Que paciente quiere eliminar?");
                Paciente eliminarPaciente = Pacientes[int.Parse(Console.ReadLine())];
                Pacientes.Remove(eliminarPaciente);
                eliminarPaciente.MedicoAsignado.pacientesAsignados.Remove(eliminarPaciente);
                Console.WriteLine("Lista de pacientes actualizada");
                for (int i = 0; i < Pacientes.Count; i++)
                {
                    Console.WriteLine((i + 1) + " - " + pacientes[i]);
                }
            }

            public void TotalHospital()
            {
                int totalHospital = Medicos.Count + Administrativos.Count + Pacientes.Count;
                Console.WriteLine("La gente total que hay en el hospital es de: " + totalHospital);
            }
        }
}

