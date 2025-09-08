namespace pyrLunaAgendaDeContactosGUI
{
    partial class frmPrincipal
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
            lstRegistro = new ListBox();
            mskNumero = new MaskedTextBox();
            btnCancelar = new Button();
            btnRegistrar = new Button();
            lblGestionContacto = new Label();
            txtContacto = new TextBox();
            lblNumero = new Label();
            lblContacto = new Label();
            SuspendLayout();
            // 
            // lstRegistro
            // 
            lstRegistro.FormattingEnabled = true;
            lstRegistro.ItemHeight = 15;
            lstRegistro.Location = new Point(18, 188);
            lstRegistro.Name = "lstRegistro";
            lstRegistro.Size = new Size(338, 199);
            lstRegistro.TabIndex = 16;
            // 
            // mskNumero
            // 
            mskNumero.Font = new Font("Segoe UI", 16F);
            mskNumero.Location = new Point(124, 104);
            mskNumero.Mask = "999999999";
            mskNumero.Name = "mskNumero";
            mskNumero.PromptChar = ' ';
            mskNumero.Size = new Size(232, 36);
            mskNumero.TabIndex = 2;
            mskNumero.ValidatingType = typeof(int);
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 16F);
            btnCancelar.Location = new Point(124, 146);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(111, 36);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 16F);
            btnRegistrar.Location = new Point(241, 146);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(115, 36);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // lblGestionContacto
            // 
            lblGestionContacto.AutoSize = true;
            lblGestionContacto.Font = new Font("Segoe UI", 16F);
            lblGestionContacto.Location = new Point(98, 18);
            lblGestionContacto.Name = "lblGestionContacto";
            lblGestionContacto.Size = new Size(179, 30);
            lblGestionContacto.TabIndex = 12;
            lblGestionContacto.Text = "Gestion Contacto";
            // 
            // txtContacto
            // 
            txtContacto.Font = new Font("Segoe UI", 16F);
            txtContacto.Location = new Point(124, 62);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(232, 36);
            txtContacto.TabIndex = 1;
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 16F);
            lblNumero.Location = new Point(18, 107);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(93, 30);
            lblNumero.TabIndex = 10;
            lblNumero.Text = "Numero";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 16F);
            lblContacto.Location = new Point(18, 65);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(100, 30);
            lblContacto.TabIndex = 9;
            lblContacto.Text = "Contacto";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 404);
            Controls.Add(lstRegistro);
            Controls.Add(mskNumero);
            Controls.Add(btnCancelar);
            Controls.Add(btnRegistrar);
            Controls.Add(lblGestionContacto);
            Controls.Add(txtContacto);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Name = "frmPrincipal";
            Text = "Agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstRegistro;
        private MaskedTextBox mskNumero;
        private Button btnCancelar;
        private Button btnRegistrar;
        private Label lblGestionContacto;
        private TextBox txtContacto;
        private Label lblNumero;
        private Label lblContacto;
    }
}