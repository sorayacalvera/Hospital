using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    public class Persona
    {
        //Atributos comunes
        private string nombre;
        private string apellidos;
        private int dni;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public int Dni { get => dni; set => dni = value; }

        public Persona(string nombre, string apellidos, int dni)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.dni = dni;
        }
    }
}
