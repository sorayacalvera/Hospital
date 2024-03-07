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
            this.butMedico = new System.Windows.Forms.Button();
            this.butPaciente = new System.Windows.Forms.Button();
            this.butPersonalAdministrativo = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.labTotalPersonasHospital = new System.Windows.Forms.Label();
            this.listBoxPersonasDelHospital = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // labtitle
            // 
            resources.ApplyResources(this.labtitle, "labtitle");
            this.labtitle.Name = "labtitle";
            // 
            // butMedico
            // 
            this.butMedico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.butMedico, "butMedico");
            this.butMedico.Name = "butMedico";
            this.butMedico.UseVisualStyleBackColor = false;
            this.butMedico.Click += new System.EventHandler(this.butMedico_Click_1);
            // 
            // butPaciente
            // 
            this.butPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.butPaciente, "butPaciente");
            this.butPaciente.Name = "butPaciente";
            this.butPaciente.UseVisualStyleBackColor = false;
            this.butPaciente.Click += new System.EventHandler(this.butPaciente_Click_1);
            // 
            // butPersonalAdministrativo
            // 
            this.butPersonalAdministrativo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.butPersonalAdministrativo, "butPersonalAdministrativo");
            this.butPersonalAdministrativo.Name = "butPersonalAdministrativo";
            this.butPersonalAdministrativo.UseVisualStyleBackColor = false;
            this.butPersonalAdministrativo.Click += new System.EventHandler(this.butPersonalAdministrativo_Click);
            // 
            // butSalir
            // 
            this.butSalir.BackColor = System.Drawing.Color.Yellow;
            resources.ApplyResources(this.butSalir, "butSalir");
            this.butSalir.Name = "butSalir";
            this.butSalir.UseVisualStyleBackColor = false;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // labTotalPersonasHospital
            // 
            resources.ApplyResources(this.labTotalPersonasHospital, "labTotalPersonasHospital");
            this.labTotalPersonasHospital.Name = "labTotalPersonasHospital";
            // 
            // listBoxPersonasDelHospital
            // 
            this.listBoxPersonasDelHospital.FormattingEnabled = true;
            resources.ApplyResources(this.listBoxPersonasDelHospital, "listBoxPersonasDelHospital");
            this.listBoxPersonasDelHospital.Name = "listBoxPersonasDelHospital";
            // 
            // FormHospital
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.listBoxPersonasDelHospital);
            this.Controls.Add(this.labTotalPersonasHospital);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butPersonalAdministrativo);
            this.Controls.Add(this.butPaciente);
            this.Controls.Add(this.butMedico);
            this.Controls.Add(this.labtitle);
            this.DoubleBuffered = true;
            this.Name = "FormHospital";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labtitle;
        private System.Windows.Forms.Button butMedico;
        private System.Windows.Forms.Button butPaciente;
        private System.Windows.Forms.Button butPersonalAdministrativo;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.Label labTotalPersonasHospital;
        private System.Windows.Forms.ListBox listBoxPersonasDelHospital;
    }
}

