namespace Hospital
{
    partial class FormHospital
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHospital));
            this.labtitle = new System.Windows.Forms.Label();
            this.butAltaMedico = new System.Windows.Forms.Button();
            this.butAltaPaciente = new System.Windows.Forms.Button();
            this.butAltaPersonalAdministrativo = new System.Windows.Forms.Button();
            this.butListarMedicos = new System.Windows.Forms.Button();
            this.butListarPacientesMedico = new System.Windows.Forms.Button();
            this.butEliminarPaciente = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.butTotalPersonasHospital = new System.Windows.Forms.Button();
            this.labNuevasAltas = new System.Windows.Forms.Label();
            this.labListas = new System.Windows.Forms.Label();
            this.labEliminar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labtitle
            // 
            resources.ApplyResources(this.labtitle, "labtitle");
            this.labtitle.Name = "labtitle";
            // 
            // butAltaMedico
            // 
            this.butAltaMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.butAltaMedico, "butAltaMedico");
            this.butAltaMedico.Name = "butAltaMedico";
            this.butAltaMedico.UseVisualStyleBackColor = false;
            this.butAltaMedico.Click += new System.EventHandler(this.butAltaMedico_Click);
            // 
            // butAltaPaciente
            // 
            this.butAltaPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.butAltaPaciente, "butAltaPaciente");
            this.butAltaPaciente.Name = "butAltaPaciente";
            this.butAltaPaciente.UseVisualStyleBackColor = false;
            this.butAltaPaciente.Click += new System.EventHandler(this.butAltaPaciente_Click);
            // 
            // butAltaPersonalAdministrativo
            // 
            this.butAltaPersonalAdministrativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.butAltaPersonalAdministrativo, "butAltaPersonalAdministrativo");
            this.butAltaPersonalAdministrativo.Name = "butAltaPersonalAdministrativo";
            this.butAltaPersonalAdministrativo.UseVisualStyleBackColor = false;
            this.butAltaPersonalAdministrativo.Click += new System.EventHandler(this.butAltaPersonalAdministrativo_Click);
            // 
            // butListarMedicos
            // 
            this.butListarMedicos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.butListarMedicos, "butListarMedicos");
            this.butListarMedicos.Name = "butListarMedicos";
            this.butListarMedicos.UseVisualStyleBackColor = false;
            this.butListarMedicos.Click += new System.EventHandler(this.butListarMedicos_Click);
            // 
            // butListarPacientesMedico
            // 
            this.butListarPacientesMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.butListarPacientesMedico, "butListarPacientesMedico");
            this.butListarPacientesMedico.Name = "butListarPacientesMedico";
            this.butListarPacientesMedico.UseVisualStyleBackColor = false;
            this.butListarPacientesMedico.Click += new System.EventHandler(this.butListarPacientesMedico_Click);
            // 
            // butEliminarPaciente
            // 
            this.butEliminarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.butEliminarPaciente, "butEliminarPaciente");
            this.butEliminarPaciente.Name = "butEliminarPaciente";
            this.butEliminarPaciente.UseVisualStyleBackColor = false;
            // 
            // butSalir
            // 
            this.butSalir.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.butSalir, "butSalir");
            this.butSalir.Name = "butSalir";
            this.butSalir.UseVisualStyleBackColor = false;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // butTotalPersonasHospital
            // 
            this.butTotalPersonasHospital.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            resources.ApplyResources(this.butTotalPersonasHospital, "butTotalPersonasHospital");
            this.butTotalPersonasHospital.Name = "butTotalPersonasHospital";
            this.butTotalPersonasHospital.UseVisualStyleBackColor = false;
            this.butTotalPersonasHospital.Click += new System.EventHandler(this.butTotalPersonasHospital_Click);
            // 
            // labNuevasAltas
            // 
            resources.ApplyResources(this.labNuevasAltas, "labNuevasAltas");
            this.labNuevasAltas.Name = "labNuevasAltas";
            // 
            // labListas
            // 
            resources.ApplyResources(this.labListas, "labListas");
            this.labListas.Name = "labListas";
            // 
            // labEliminar
            // 
            resources.ApplyResources(this.labEliminar, "labEliminar");
            this.labEliminar.Name = "labEliminar";
            // 
            // Hospital
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.labEliminar);
            this.Controls.Add(this.labListas);
            this.Controls.Add(this.labNuevasAltas);
            this.Controls.Add(this.butTotalPersonasHospital);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butEliminarPaciente);
            this.Controls.Add(this.butListarPacientesMedico);
            this.Controls.Add(this.butListarMedicos);
            this.Controls.Add(this.butAltaPersonalAdministrativo);
            this.Controls.Add(this.butAltaPaciente);
            this.Controls.Add(this.butAltaMedico);
            this.Controls.Add(this.labtitle);
            this.DoubleBuffered = true;
            this.Name = "Hospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labtitle;
        private System.Windows.Forms.Button butAltaMedico;
        private System.Windows.Forms.Button butAltaPaciente;
        private System.Windows.Forms.Button butAltaPersonalAdministrativo;
        private System.Windows.Forms.Button butListarMedicos;
        private System.Windows.Forms.Button butListarPacientesMedico;
        private System.Windows.Forms.Button butEliminarPaciente;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.Button butTotalPersonasHospital;
        private System.Windows.Forms.Label labNuevasAltas;
        private System.Windows.Forms.Label labListas;
        private System.Windows.Forms.Label labEliminar;
    }
}

