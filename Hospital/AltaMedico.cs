using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Hospital
{
    public partial class AltaMedico : Form
    {
        public Hospital hospital;
        public AltaMedico(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butGuardar_Click(object sender, EventArgs e)
        {
            txtNumColegiado.Text = string.Empty;
            int numColegiado = int.Parse(txtNumColegiado.Text);
            txtDNI.Text = string.Empty;
            int dniMedico = int.Parse(txtDNI.Text);
            
            hospital.AltaMedico(numColegiado, txtNombre.Text, txtApellido.Text, dniMedico);
        }

    }
}
