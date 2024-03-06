namespace Hospital
{
    partial class AltaPersAdmi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaPersAdmi));
            this.butSalirAdmi = new System.Windows.Forms.Button();
            this.butGuardarAdmi = new System.Windows.Forms.Button();
            this.txtNumTrabajador = new System.Windows.Forms.TextBox();
            this.txtDNIAdmi = new System.Windows.Forms.TextBox();
            this.txtApellidoAdmi = new System.Windows.Forms.TextBox();
            this.labNumTrabajador = new System.Windows.Forms.Label();
            this.labDNIAdmi = new System.Windows.Forms.Label();
            this.labApellidoAdmi = new System.Windows.Forms.Label();
            this.txtNombreAdmi = new System.Windows.Forms.TextBox();
            this.labNombreAdmi = new System.Windows.Forms.Label();
            this.labAltaMedico = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSalirAdmi
            // 
            this.butSalirAdmi.Location = new System.Drawing.Point(870, 662);
            this.butSalirAdmi.Name = "butSalirAdmi";
            this.butSalirAdmi.Size = new System.Drawing.Size(75, 23);
            this.butSalirAdmi.TabIndex = 21;
            this.butSalirAdmi.Text = "Salir";
            this.butSalirAdmi.UseVisualStyleBackColor = true;
            this.butSalirAdmi.Click += new System.EventHandler(this.butSalirAdmi_Click);
            // 
            // butGuardarAdmi
            // 
            this.butGuardarAdmi.Location = new System.Drawing.Point(452, 403);
            this.butGuardarAdmi.Name = "butGuardarAdmi";
            this.butGuardarAdmi.Size = new System.Drawing.Size(75, 23);
            this.butGuardarAdmi.TabIndex = 20;
            this.butGuardarAdmi.Text = "Guardar";
            this.butGuardarAdmi.UseVisualStyleBackColor = true;
            // 
            // txtNumTrabajador
            // 
            this.txtNumTrabajador.Location = new System.Drawing.Point(299, 213);
            this.txtNumTrabajador.Name = "txtNumTrabajador";
            this.txtNumTrabajador.Size = new System.Drawing.Size(228, 22);
            this.txtNumTrabajador.TabIndex = 19;
            // 
            // txtDNIAdmi
            // 
            this.txtDNIAdmi.Location = new System.Drawing.Point(200, 341);
            this.txtDNIAdmi.Name = "txtDNIAdmi";
            this.txtDNIAdmi.Size = new System.Drawing.Size(327, 22);
            this.txtDNIAdmi.TabIndex = 18;
            // 
            // txtApellidoAdmi
            // 
            this.txtApellidoAdmi.Location = new System.Drawing.Point(200, 299);
            this.txtApellidoAdmi.Name = "txtApellidoAdmi";
            this.txtApellidoAdmi.Size = new System.Drawing.Size(327, 22);
            this.txtApellidoAdmi.TabIndex = 17;
            // 
            // labNumTrabajador
            // 
            this.labNumTrabajador.AutoSize = true;
            this.labNumTrabajador.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumTrabajador.Location = new System.Drawing.Point(98, 214);
            this.labNumTrabajador.Name = "labNumTrabajador";
            this.labNumTrabajador.Size = new System.Drawing.Size(181, 18);
            this.labNumTrabajador.TabIndex = 16;
            this.labNumTrabajador.Text = "Número de trabajador: ";
            // 
            // labDNIAdmi
            // 
            this.labDNIAdmi.AutoSize = true;
            this.labDNIAdmi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDNIAdmi.Location = new System.Drawing.Point(98, 345);
            this.labDNIAdmi.Name = "labDNIAdmi";
            this.labDNIAdmi.Size = new System.Drawing.Size(38, 18);
            this.labDNIAdmi.TabIndex = 15;
            this.labDNIAdmi.Text = "DNI:";
            // 
            // labApellidoAdmi
            // 
            this.labApellidoAdmi.AutoSize = true;
            this.labApellidoAdmi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellidoAdmi.Location = new System.Drawing.Point(98, 303);
            this.labApellidoAdmi.Name = "labApellidoAdmi";
            this.labApellidoAdmi.Size = new System.Drawing.Size(79, 18);
            this.labApellidoAdmi.TabIndex = 14;
            this.labApellidoAdmi.Text = "Apellido: ";
            // 
            // txtNombreAdmi
            // 
            this.txtNombreAdmi.Location = new System.Drawing.Point(200, 257);
            this.txtNombreAdmi.Name = "txtNombreAdmi";
            this.txtNombreAdmi.Size = new System.Drawing.Size(327, 22);
            this.txtNombreAdmi.TabIndex = 13;
            // 
            // labNombreAdmi
            // 
            this.labNombreAdmi.AutoSize = true;
            this.labNombreAdmi.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombreAdmi.Location = new System.Drawing.Point(98, 258);
            this.labNombreAdmi.Name = "labNombreAdmi";
            this.labNombreAdmi.Size = new System.Drawing.Size(76, 18);
            this.labNombreAdmi.TabIndex = 12;
            this.labNombreAdmi.Text = "Nombre: ";
            // 
            // labAltaMedico
            // 
            this.labAltaMedico.AutoSize = true;
            this.labAltaMedico.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAltaMedico.Location = new System.Drawing.Point(37, 67);
            this.labAltaMedico.Name = "labAltaMedico";
            this.labAltaMedico.Size = new System.Drawing.Size(324, 27);
            this.labAltaMedico.TabIndex = 11;
            this.labAltaMedico.Text = "Alta Personal Administrativo";
            // 
            // AltaPersAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.butSalirAdmi);
            this.Controls.Add(this.butGuardarAdmi);
            this.Controls.Add(this.txtNumTrabajador);
            this.Controls.Add(this.txtDNIAdmi);
            this.Controls.Add(this.txtApellidoAdmi);
            this.Controls.Add(this.labNumTrabajador);
            this.Controls.Add(this.labDNIAdmi);
            this.Controls.Add(this.labApellidoAdmi);
            this.Controls.Add(this.txtNombreAdmi);
            this.Controls.Add(this.labNombreAdmi);
            this.Controls.Add(this.labAltaMedico);
            this.DoubleBuffered = true;
            this.Name = "AltaPersAdmi";
            this.Text = "Alta Personal Administrativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSalirAdmi;
        private System.Windows.Forms.Button butGuardarAdmi;
        private System.Windows.Forms.TextBox txtNumTrabajador;
        private System.Windows.Forms.TextBox txtDNIAdmi;
        private System.Windows.Forms.TextBox txtApellidoAdmi;
        private System.Windows.Forms.Label labNumTrabajador;
        private System.Windows.Forms.Label labDNIAdmi;
        private System.Windows.Forms.Label labApellidoAdmi;
        private System.Windows.Forms.TextBox txtNombreAdmi;
        private System.Windows.Forms.Label labNombreAdmi;
        private System.Windows.Forms.Label labAltaMedico;
    }
}