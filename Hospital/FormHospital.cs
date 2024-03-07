using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital
{
    public partial class FormHospital : Form
    {
        Hospital hospital;
        public FormHospital(Hospital hospital)
        {
            this.hospital = hospital;
            InitializeComponent();
        }

        private void butPersonalAdministrativo_Click(object sender, EventArgs e)
        {
            AltaPersAdmi altaPersonalAdministrativo = new AltaPersAdmi(hospital);
            altaPersonalAdministrativo.ShowDialog();
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butPaciente_Click_1(object sender, EventArgs e)
        {
            FormPaciente formPaciente = new FormPaciente(hospital);
            formPaciente.ShowDialog();
        }

        private void butMedico_Click_1(object sender, EventArgs e)
        {
            AltaMedico altaMedico = new AltaMedico(hospital);
            altaMedico.ShowDialog();
        }
    }
}
