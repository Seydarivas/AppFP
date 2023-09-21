namespace AppFP.condicionales
{
    partial class _13
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
            lblCifras = new Label();
            txtNumero = new TextBox();
            txtCifras = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(54, 68);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(254, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingrese un numero entero positivo de 3 cifras  :";
            // 
            // lblCifras
            // 
            lblCifras.AutoSize = true;
            lblCifras.Location = new Point(54, 118);
            lblCifras.Name = "lblCifras";
            lblCifras.Size = new Size(147, 15);
            lblCifras.TabIndex = 1;
            lblCifras.Text = "Las cifras del numero son :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(343, 60);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(82, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtCifras
            // 
            txtCifras.Location = new Point(242, 110);
            txtCifras.Name = "txtCifras";
            txtCifras.Size = new Size(140, 23);
            txtCifras.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(198, 188);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(93, 27);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(479, 250);
            Controls.Add(btnCalcular);
            Controls.Add(txtCifras);
            Controls.Add(txtNumero);
            Controls.Add(lblCifras);
            Controls.Add(lblNumero);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblCifras;
        private TextBox txtNumero;
        private TextBox txtCifras;
        private Button btnCalcular;
    }
}