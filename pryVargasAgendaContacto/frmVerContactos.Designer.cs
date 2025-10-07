namespace pryVargasAgendaContacto
{
    partial class frmVerContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerContactos));
            lblDatos = new Label();
            btnSiguiente = new Button();
            btnAtras = new Button();
            lblDatosIndividual = new Label();
            lblListadoContactos = new Label();
            lblContactosIndividual = new Label();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Font = new Font("Segoe UI", 12F);
            lblDatos.Location = new Point(21, 56);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(280, 135);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "---";
            lblDatos.Click += lblListaContactos_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Segoe UI", 12F);
            btnSiguiente.Location = new Point(154, 374);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(97, 37);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click_1;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Segoe UI", 12F);
            btnAtras.Location = new Point(51, 374);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(97, 37);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            btnAtras.Click += btnAtras_Click_1;
            // 
            // lblDatosIndividual
            // 
            lblDatosIndividual.BorderStyle = BorderStyle.Fixed3D;
            lblDatosIndividual.Font = new Font("Segoe UI", 12F);
            lblDatosIndividual.Location = new Point(21, 236);
            lblDatosIndividual.Name = "lblDatosIndividual";
            lblDatosIndividual.Size = new Size(280, 135);
            lblDatosIndividual.TabIndex = 3;
            lblDatosIndividual.Text = "---";
            // 
            // lblListadoContactos
            // 
            lblListadoContactos.AutoSize = true;
            lblListadoContactos.Font = new Font("Segoe UI", 14F);
            lblListadoContactos.Location = new Point(21, 26);
            lblListadoContactos.Name = "lblListadoContactos";
            lblListadoContactos.Size = new Size(184, 25);
            lblListadoContactos.TabIndex = 4;
            lblListadoContactos.Text = "Listado de contactos";
            // 
            // lblContactosIndividual
            // 
            lblContactosIndividual.AutoSize = true;
            lblContactosIndividual.Font = new Font("Segoe UI", 14F);
            lblContactosIndividual.Location = new Point(21, 211);
            lblContactosIndividual.Name = "lblContactosIndividual";
            lblContactosIndividual.Size = new Size(160, 25);
            lblContactosIndividual.TabIndex = 5;
            lblContactosIndividual.Text = "Listado individual";
            // 
            // frmVerContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 428);
            Controls.Add(lblContactosIndividual);
            Controls.Add(lblListadoContactos);
            Controls.Add(lblDatosIndividual);
            Controls.Add(btnAtras);
            Controls.Add(btnSiguiente);
            Controls.Add(lblDatos);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmVerContactos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Listado contactos";
            Load += frmVerContactos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDatos;
        private Button btnSiguiente;
        private Button btnAtras;
        private Label lblDatosIndividual;
        private Label lblListadoContactos;
        private Label lblContactosIndividual;
    }
}