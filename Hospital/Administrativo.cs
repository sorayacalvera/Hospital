using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Administrativo : Persona
    {
        private int numeroTrabajador;

        public int NumeroTrabajador { get => numeroTrabajador; set => numeroTrabajador = value; }

        public Administrativo(int numeroTrabajador, string nombre, string apellidos, int dni) : base(nombre, apellidos, dni)
        {
            this.numeroTrabajador = numeroTrabajador;
        }
    }
}

