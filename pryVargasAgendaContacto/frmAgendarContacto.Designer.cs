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
            lblContacto = new Label();
            lblNumero = new Label();
            txtContacto = new TextBox();
            mtbNumero = new MaskedTextBox();
            btnRegistrar = new Button();
            btnCancelar = new Button();
            lstContactos = new ListBox();
            lblCantContactos = new Label();
            SuspendLayout();
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 12F);
            lblContacto.Location = new Point(38, 35);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(72, 21);
            lblContacto.TabIndex = 0;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 12F);
            lblNumero.Location = new Point(38, 74);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(68, 21);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 12F);
            txtContacto.Location = new Point(133, 27);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(159, 29);
            txtContacto.TabIndex = 0;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Font = new Font("Segoe UI", 12F);
            mtbNumero.Location = new Point(133, 66);
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
            btnRegistrar.Location = new Point(206, 144);
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
            btnCancelar.Location = new Point(76, 144);
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
            lstContactos.Location = new Point(38, 196);
            lstContactos.Name = "lstContactos";
            lstContactos.Size = new Size(254, 94);
            lstContactos.TabIndex = 3;
            // 
            // lblCantContactos
            // 
            lblCantContactos.AutoSize = true;
            lblCantContactos.Location = new Point(15, 364);
            lblCantContactos.Name = "lblCantContactos";
            lblCantContactos.Size = new Size(55, 15);
            lblCantContactos.TabIndex = 5;
            lblCantContactos.Text = "Cantidad";
            // 
            // frmAgendarContacto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 408);
            Controls.Add(lblCantContactos);
            Controls.Add(lstContactos);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(mtbNumero);
            Controls.Add(txtContacto);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Name = "frmAgendarContacto";
            Text = "Agendar contacto";
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
    }
}
