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

        private void butAltaMedico_Click(object sender, EventArgs e)
        {
            AltaMedico altaMedico = new AltaMedico();
            altaMedico.ShowDialog();
        }

        private void butAltaPaciente_Click(object sender, EventArgs e)
        {
            AltaPaciente altaPaciente = new AltaPaciente();
            altaPaciente.ShowDialog();
        }

        private void butAltaPersonalAdministrativo_Click(object sender, EventArgs e)
        {
            AltaPersAdmi altaPersonalAdministrativo = new AltaPersAdmi();
            altaPersonalAdministrativo.ShowDialog();
        }

        private void butListarMedicos_Click(object sender, EventArgs e)
        {
            ListarMedicos listarMedicos = new ListarMedicos();
            listarMedicos.ShowDialog();
        }

        private void butListarPacientesMedico_Click(object sender, EventArgs e)
        {
            ListarPacientesMedico listarPacientesMedico = new ListarPacientesMedico();
            listarPacientesMedico.ShowDialog();
        }

        private void butTotalPersonasHospital_Click(object sender, EventArgs e)
        {
            TotalPersonasHospital totalPersonasHospital = new TotalPersonasHospital();  
            totalPersonasHospital.ShowDialog();
        }

        private void butEliminarPaciente_Click(object sender, EventArgs e)
        {
            EliminarPaciente eliminarPaciente = new EliminarPaciente();
            eliminarPaciente.ShowDialog();
        }
        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
