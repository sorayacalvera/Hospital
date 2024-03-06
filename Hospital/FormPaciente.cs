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
    public partial class FormPaciente : Form
    {
        Hospital hospital;
        public FormPaciente(Hospital hospital)
        {
            InitializeComponent();
            this.hospital = hospital;
        }

        private void butSalirPaciente_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void butGuardarPaciente_Click(object sender, EventArgs e)
        {
        }
    }
}
