namespace Hospital
{
    partial class AltaMedico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AltaMedico));
            this.labAltaMedico = new System.Windows.Forms.Label();
            this.labNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.labApellido = new System.Windows.Forms.Label();
            this.labDNI = new System.Windows.Forms.Label();
            this.labNumColegiado = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNumColegiado = new System.Windows.Forms.TextBox();
            this.butGuardar = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labAltaMedico
            // 
            this.labAltaMedico.AutoSize = true;
            this.labAltaMedico.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAltaMedico.Location = new System.Drawing.Point(27, 57);
            this.labAltaMedico.Name = "labAltaMedico";
            this.labAltaMedico.Size = new System.Drawing.Size(151, 27);
            this.labAltaMedico.TabIndex = 0;
            this.labAltaMedico.Text = "Alta médico";
            // 
            // labNombre
            // 
            this.labNombre.AutoSize = true;
            this.labNombre.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNombre.Location = new System.Drawing.Point(91, 182);
            this.labNombre.Name = "labNombre";
            this.labNombre.Size = new System.Drawing.Size(76, 18);
            this.labNombre.TabIndex = 1;
            this.labNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(190, 181);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(327, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // labApellido
            // 
            this.labApellido.AutoSize = true;
            this.labApellido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labApellido.Location = new System.Drawing.Point(88, 218);
            this.labApellido.Name = "labApellido";
            this.labApellido.Size = new System.Drawing.Size(79, 18);
            this.labApellido.TabIndex = 3;
            this.labApellido.Text = "Apellido: ";
            // 
            // labDNI
            // 
            this.labDNI.AutoSize = true;
            this.labDNI.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDNI.Location = new System.Drawing.Point(91, 253);
            this.labDNI.Name = "labDNI";
            this.labDNI.Size = new System.Drawing.Size(38, 18);
            this.labDNI.TabIndex = 4;
            this.labDNI.Text = "DNI:";
            // 
            // labNumColegiado
            // 
            this.labNumColegiado.AutoSize = true;
            this.labNumColegiado.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNumColegiado.Location = new System.Drawing.Point(88, 145);
            this.labNumColegiado.Name = "labNumColegiado";
            this.labNumColegiado.Size = new System.Drawing.Size(181, 18);
            this.labNumColegiado.TabIndex = 5;
            this.labNumColegiado.Text = "Número de colegiado: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(190, 218);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(327, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(190, 253);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(327, 22);
            this.txtDNI.TabIndex = 7;
            // 
            // txtNumColegiado
            // 
            this.txtNumColegiado.Location = new System.Drawing.Point(289, 144);
            this.txtNumColegiado.Name = "txtNumColegiado";
            this.txtNumColegiado.Size = new System.Drawing.Size(228, 22);
            this.txtNumColegiado.TabIndex = 8;
            // 
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(574, 218);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(75, 23);
            this.butGuardar.TabIndex = 9;
            this.butGuardar.Text = "Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.butGuardar_Click);
            // 
            // butSalir
            // 
            this.butSalir.Location = new System.Drawing.Point(895, 718);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(75, 23);
            this.butSalir.TabIndex = 10;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = true;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // AltaMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(982, 753);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butGuardar);
            this.Controls.Add(this.txtNumColegiado);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.labNumColegiado);
            this.Controls.Add(this.labDNI);
            this.Controls.Add(this.labApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labNombre);
            this.Controls.Add(this.labAltaMedico);
            this.DoubleBuffered = true;
            this.Name = "AltaMedico";
            this.Text = "Alta Médico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labAltaMedico;
        private System.Windows.Forms.Label labNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label labApellido;
        private System.Windows.Forms.Label labDNI;
        private System.Windows.Forms.Label labNumColegiado;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNumColegiado;
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Button butSalir;
    }
}