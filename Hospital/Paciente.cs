using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Paciente : Persona
    {
            private int numeroHistoriaClinica;
            private Medico medicoAsignado;

            public int NumeroHistoriaClinica { get => numeroHistoriaClinica; set => numeroHistoriaClinica = value; }
            public Medico MedicoAsignado { get => medicoAsignado; set => medicoAsignado = value; }

            public Paciente(int numeroHistoriaClinica, string nombre, string apellidos, int dni) : base(nombre, apellidos, dni)
            {
                this.NumeroHistoriaClinica = numeroHistoriaClinica;
            }
    }
}
