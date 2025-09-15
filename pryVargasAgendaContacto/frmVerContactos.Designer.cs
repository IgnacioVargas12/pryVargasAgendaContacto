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
            lblDatos = new Label();
            btnSiguiente = new Button();
            btnAtras = new Button();
            SuspendLayout();
            // 
            // lblDatos
            // 
            lblDatos.BorderStyle = BorderStyle.Fixed3D;
            lblDatos.Font = new Font("Segoe UI", 12F);
            lblDatos.Location = new Point(21, 40);
            lblDatos.Name = "lblDatos";
            lblDatos.Size = new Size(280, 135);
            lblDatos.TabIndex = 0;
            lblDatos.Text = "---";
            lblDatos.Click += lblListaContactos_Click;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Font = new Font("Segoe UI", 12F);
            btnSiguiente.Location = new Point(155, 187);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(97, 37);
            btnSiguiente.TabIndex = 1;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // btnAtras
            // 
            btnAtras.Font = new Font("Segoe UI", 12F);
            btnAtras.Location = new Point(52, 187);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(97, 37);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = true;
            // 
            // frmVerContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(329, 237);
            Controls.Add(btnAtras);
            Controls.Add(btnSiguiente);
            Controls.Add(lblDatos);
            Name = "frmVerContactos";
            Text = "Listado contactos";
            Load += frmVerContactos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblDatos;
        private Button btnSiguiente;
        private Button btnAtras;
    }
}