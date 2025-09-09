namespace pryVargasAgendaContacto
{
    partial class frmAgendarContacto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendarContacto));
            lblContacto = new Label();
            lblNumero = new Label();
            txtContacto = new TextBox();
            mtbNumero = new MaskedTextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lstContactos = new ListBox();
            lblCantContactos = new Label();
            lblFecha = new Label();
            lblContador = new Label();
            lblRFecha = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 12F);
            lblContacto.Location = new Point(23, 29);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(72, 21);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(23, 76);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 21);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 12F);
            txtContacto.Location = new Point(118, 21);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(159, 29);
            txtContacto.TabIndex = 0;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Font = new Font("Segoe UI", 12F);
            mtbNumero.Location = new Point(118, 68);
            mtbNumero.Mask = "(351)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(159, 29);
            mtbNumero.TabIndex = 1;
            mtbNumero.TextChanged += mtbNumero_TextChanged;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Enabled = false;
            btnRegistrar.Font = new Font("Segoe UI", 12F);
            btnRegistrar.Location = new Point(191, 127);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(86, 31);
            btnRegistrar.TabIndex = 2;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F);
            btnCancelar.Location = new Point(61, 127);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(85, 31);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lstContactos
            // 
            lstContactos.FormattingEnabled = true;
            lstContactos.ItemHeight = 15;
            lstContactos.Location = new Point(23, 179);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(254, 94);
            lstContactos.TabIndex = 3;
            // 
            // lblCantContactos
            // 
            lblCantContactos.AutoSize = true;
            lblCantContactos.Location = new Point(20, 293);
            lblCantContactos.Name = "lblCantContactos";
            lblCantContactos.Size = new Size(126, 15);
            lblCantContactos.TabIndex = 5;
            lblCantContactos.Text = "Cantidad de contactos";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(23, 330);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(74, 15);
            lblFecha.TabIndex = 6;
            lblFecha.Text = "Fecha y hora";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(152, 293);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(22, 15);
            lblContador.TabIndex = 7;
            lblContador.Text = "---";
            // 
            // lblRFecha
            // 
            lblRFecha.AutoSize = true;
            lblRFecha.Location = new Point(103, 330);
            lblRFecha.Name = "lblRFecha";
            lblRFecha.Size = new Size(22, 15);
            lblRFecha.TabIndex = 8;
            lblRFecha.Text = "---";
            // 
            // frmAgendarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 364);
            Controls.Add(lblRFecha);
            Controls.Add(lblContador);
            Controls.Add(lblFecha);
            Controls.Add(lblCantContactos);
            Controls.Add(lstContactos);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(mtbNumero);
            Controls.Add(txtContacto);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAgendarContacto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agendar contacto";
            Load += frmAgendarContacto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblContacto;
        private Label lblNumero;
        private TextBox txtContacto;
        private MaskedTextBox mtbNumero;
        private Button btnRegistrar;
        private Button btnCancelar;
        private ListBox lstContactos;
        private Label lblCantContactos;
        private Label lblFecha;
        private Label lblContador;
        private Label lblRFecha;
    }
}
