namespace Hospital
{
    partial class ListaMedicoPaciente
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
            this.labPacientesMédico = new System.Windows.Forms.Label();
            this.listBoxPacientes = new System.Windows.Forms.ListBox();
            this.comboBoxListarMedicos = new System.Windows.Forms.ComboBox();
            this.labListarMedicos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labPacientesMédico
            // 
            this.labPacientesMédico.AutoSize = true;
            this.labPacientesMédico.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPacientesMédico.Location = new System.Drawing.Point(169, 116);
            this.labPacientesMédico.Name = "labPacientesMédico";
            this.labPacientesMédico.Size = new System.Drawing.Size(215, 27);
            this.labPacientesMédico.TabIndex = 21;
            this.labPacientesMédico.Text = "Pacientes Médico";
            // 
            // listBoxPacientes
            // 
            this.listBoxPacientes.FormattingEnabled = true;
            this.listBoxPacientes.ItemHeight = 16;
            this.listBoxPacientes.Location = new System.Drawing.Point(174, 158);
            this.listBoxPacientes.Name = "listBoxPacientes";
            this.listBoxPacientes.Size = new System.Drawing.Size(458, 260);
            this.listBoxPacientes.TabIndex = 20;
            // 
            // comboBoxListarMedicos
            // 
            this.comboBoxListarMedicos.FormattingEnabled = true;
            this.comboBoxListarMedicos.Location = new System.Drawing.Point(174, 73);
            this.comboBoxListarMedicos.Name = "comboBoxListarMedicos";
            this.comboBoxListarMedicos.Size = new System.Drawing.Size(300, 24);
            this.comboBoxListarMedicos.TabIndex = 19;
            // 
            // labListarMedicos
            // 
            this.labListarMedicos.AutoSize = true;
            this.labListarMedicos.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labListarMedicos.Location = new System.Drawing.Point(169, 33);
            this.labListarMedicos.Name = "labListarMedicos";
            this.labListarMedicos.Size = new System.Drawing.Size(170, 27);
            this.labListarMedicos.TabIndex = 18;
            this.labListarMedicos.Text = "Listar Médicos";
            // 
            // ListaMedicoPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labPacientesMédico);
            this.Controls.Add(this.listBoxPacientes);
            this.Controls.Add(this.comboBoxListarMedicos);
            this.Controls.Add(this.labListarMedicos);
            this.Name = "ListaMedicoPaciente";
            this.Text = "ListaMedicoPaciente";
            this.Load += new System.EventHandler(this.ListaMedicoPaciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPacientesMédico;
        private System.Windows.Forms.ListBox listBoxPacientes;
        private System.Windows.Forms.ComboBox comboBoxListarMedicos;
        private System.Windows.Forms.Label labListarMedicos;
    }
}