using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Medico : Persona
        {
            private int numeroColegiado;
            public List<Paciente> pacientesAsignados = new List<Paciente>();

            public int NumeroColegiado { get => numeroColegiado; set => numeroColegiado = value; }

            public Medico(int numeroColegiado, string nombre, string apellidos, int dni) : base(nombre, apellidos, dni)
            {
                this.NumeroColegiado = numeroColegiado;
            }

            public void AsignarPaciente(Paciente p)
            {
                pacientesAsignados.Add(p);
            }
        }
}
