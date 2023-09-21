namespace AppFP.condicionales
{
    partial class _05
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
            lblNumero = new Label();
            lblNuevo = new Label();
            txtNumero = new TextBox();
            txtNuevo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(49, 64);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(172, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingrese un numero de 4 cifras  :";
            // 
            // lblNuevo
            // 
            lblNuevo.AutoSize = true;
            lblNuevo.Location = new Point(49, 119);
            lblNuevo.Name = "lblNuevo";
            lblNuevo.Size = new Size(289, 15);
            lblNuevo.TabIndex = 1;
            lblNuevo.Text = "Numero mayor formado por la cifra mayor y menor  :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(256, 56);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(71, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtNuevo
            // 
            txtNuevo.Location = new Point(373, 111);
            txtNuevo.Name = "txtNuevo";
            txtNuevo.Size = new Size(69, 23);
            txtNuevo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(220, 187);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(521, 246);
            Controls.Add(btnCalcular);
            Controls.Add(txtNuevo);
            Controls.Add(txtNumero);
            Controls.Add(lblNuevo);
            Controls.Add(lblNumero);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblNuevo;
        private TextBox txtNumero;
        private TextBox txtNuevo;
        private Button btnCalcular;
    }
}