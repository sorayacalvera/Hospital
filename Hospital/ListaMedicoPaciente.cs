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
    public partial class ListaMedicoPaciente : Form
    {
        Hospital hospital;
        public ListaMedicoPaciente()
        {
            InitializeComponent();
        }


        private void comboBoxListarMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListaMedicoPaciente_Load(object sender, EventArgs e)
        {
            foreach (var medico in hospital.Medicos)
            {
                comboBoxListarMedicos.Items.Add(medico);
            }
        }
    }
}
