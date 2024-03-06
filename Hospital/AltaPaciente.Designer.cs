namespace Hospital
{
    partial class AltaPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaPaciente));
            this.butSalirPaciente = new System.Windows.Forms.Button();
            this.butGuardarPaciente = new System.Windows.Forms.Button();
            this.txtNumColegiado = new System.Windows.Forms.TextBox();
            this.labNumHistoriaClinica = new System.Windows.Forms.Label();
            this.labAltaPaciente = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labDNIPaciente = new System.Windows.Forms.Label();
            this.labApellidoPaciente = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labNombrePaciente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSalirPaciente
            // 
            this.butSalirPaciente.Location = new System.Drawing.Point(870, 662);
            this.butSalirPaciente.Name = "butSalirPaciente";
            this.butSalirPaciente.Size = new System.Drawing.Size(75, 23);
            this.butSalirPaciente.TabIndex = 21;
            this.butSalirPaciente.Tag = "";
            this.butSalirPaciente.Text = "Salir";
            this.butSalirPaciente.UseVisualStyleBackColor = true;
            this.butSalirPaciente.Click += new System.EventHandler(this.butSalirPaciente_Click);
            // 
            // butGuardarPaciente
            // 
            this.butGuardarPaciente.Location = new System.Drawing.Point(452, 403);
            this.butGuardarPaciente.Name = "butGuardarPaciente";
            this.butGuardarPaciente.Size = new System.Drawing.Size(75, 23);
            this.butGuardarPaciente.TabIndex = 20;
            this.butGuardarPaciente.Tag = "";
            this.butGuardarPaciente.Text = "Guardar";
            this.butGuardarPaciente.UseVisualStyleBackColor = true;
            this.butGuardarPaciente.Click += new System.EventHandler(this.butGuardarPaciente_Click);
            // 
            // txtNumColegiado
            // 
            this.txtNumColegiado.Location = new System.Drawing.Point(309, 214);
            this.txtNumColegiado.Name = "txtNumColegiado";
            this.txtNumColegiado.Size = new System.Drawing.Size(228, 22);
            this.txtNumColegiado.TabIndex = 19;
            this.txtNumColegiado.Tag = "";
            // 
            // labNumHistoriaClinica
            // 
            this.labNumHistoriaClinica.AutoSize = true;
            this.labNumHistoriaClinica.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumHistoriaClinica.Location = new System.Drawing.Point(98, 214);
            this.labNumHistoriaClinica.Name = "labNumHistoriaClinica";
            this.labNumHistoriaClinica.Size = new System.Drawing.Size(205, 18);
            this.labNumHistoriaClinica.TabIndex = 16;
            this.labNumHistoriaClinica.Tag = "";
            this.labNumHistoriaClinica.Text = "Número de Historia Clinica";
            // 
            // labAltaPaciente
            // 
            this.labAltaPaciente.AutoSize = true;
            this.labAltaPaciente.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAltaPaciente.Location = new System.Drawing.Point(37, 67);
            this.labAltaPaciente.Name = "labAltaPaciente";
            this.labAltaPaciente.Size = new System.Drawing.Size(163, 27);
            this.labAltaPaciente.TabIndex = 11;
            this.labAltaPaciente.Tag = "";
            this.labAltaPaciente.Text = "Alta Paciente";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(200, 342);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(327, 22);
            this.txtDNI.TabIndex = 27;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(200, 300);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(327, 22);
            this.txtApellido.TabIndex = 26;
            // 
            // labDNIPaciente
            // 
            this.labDNIPaciente.AutoSize = true;
            this.labDNIPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDNIPaciente.Location = new System.Drawing.Point(98, 346);
            this.labDNIPaciente.Name = "labDNIPaciente";
            this.labDNIPaciente.Size = new System.Drawing.Size(38, 18);
            this.labDNIPaciente.TabIndex = 25;
            this.labDNIPaciente.Text = "DNI:";
            // 
            // labApellidoPaciente
            // 
            this.labApellidoPaciente.AutoSize = true;
            this.labApellidoPaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellidoPaciente.Location = new System.Drawing.Point(98, 304);
            this.labApellidoPaciente.Name = "labApellidoPaciente";
            this.labApellidoPaciente.Size = new System.Drawing.Size(79, 18);
            this.labApellidoPaciente.TabIndex = 24;
            this.labApellidoPaciente.Text = "Apellido: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(200, 258);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(327, 22);
            this.txtNombre.TabIndex = 23;
            // 
            // labNombrePaciente
            // 
            this.labNombrePaciente.AutoSize = true;
            this.labNombrePaciente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombrePaciente.Location = new System.Drawing.Point(98, 259);
            this.labNombrePaciente.Name = "labNombrePaciente";
            this.labNombrePaciente.Size = new System.Drawing.Size(76, 18);
            this.labNombrePaciente.TabIndex = 22;
            this.labNombrePaciente.Text = "Nombre: ";
            // 
            // AltaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.labDNIPaciente);
            this.Controls.Add(this.labApellidoPaciente);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labNombrePaciente);
            this.Controls.Add(this.butSalirPaciente);
            this.Controls.Add(this.butGuardarPaciente);
            this.Controls.Add(this.txtNumColegiado);
            this.Controls.Add(this.labNumHistoriaClinica);
            this.Controls.Add(this.labAltaPaciente);
            this.DoubleBuffered = true;
            this.Name = "AltaPaciente";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSalirPaciente;
        private System.Windows.Forms.Button butGuardarPaciente;
        private System.Windows.Forms.TextBox txtNumColegiado;
        private System.Windows.Forms.Label labNumHistoriaClinica;
        private System.Windows.Forms.Label labAltaPaciente;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label labDNIPaciente;
        private System.Windows.Forms.Label labApellidoPaciente;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labNombrePaciente;
    }
}