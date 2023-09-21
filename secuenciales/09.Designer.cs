namespace AppFP.secuenciales
{
    partial class _09
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
            lblSuma = new Label();
            txtNumero = new TextBox();
            txtSuma = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(55, 63);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(254, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingrese un numero entero positivo de 4 cifras  :";
            // 
            // lblSuma
            // 
            lblSuma.AutoSize = true;
            lblSuma.Location = new Point(55, 113);
            lblSuma.Name = "lblSuma";
            lblSuma.Size = new Size(113, 15);
            lblSuma.TabIndex = 1;
            lblSuma.Text = "Suma de sus cifras  :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(341, 55);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(69, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtSuma
            // 
            txtSuma.Location = new Point(209, 105);
            txtSuma.Name = "txtSuma";
            txtSuma.Size = new Size(62, 23);
            txtSuma.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(209, 178);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(83, 27);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _09
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 249);
            Controls.Add(btnCalcular);
            Controls.Add(txtSuma);
            Controls.Add(txtNumero);
            Controls.Add(lblSuma);
            Controls.Add(lblNumero);
            Name = "_09";
            Text = "_09";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblSuma;
        private TextBox txtNumero;
        private TextBox txtSuma;
        private Button btnCalcular;
    }
}