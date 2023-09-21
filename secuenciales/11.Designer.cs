namespace AppFP.secuenciales
{
    partial class _11
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
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtIntercambiadas = new TextBox();
            lblIntercambiadas = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(61, 70);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(152, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Primer numero de 3 cifras  :";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(61, 121);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(164, 15);
            lblNumero2.TabIndex = 1;
            lblNumero2.Text = "Segundo numero de 3 cifras  :";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(253, 62);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(81, 23);
            txtNumero1.TabIndex = 2;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(253, 113);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(81, 23);
            txtNumero2.TabIndex = 3;
            // 
            // txtIntercambiadas
            // 
            txtIntercambiadas.Location = new Point(310, 163);
            txtIntercambiadas.Name = "txtIntercambiadas";
            txtIntercambiadas.Size = new Size(85, 23);
            txtIntercambiadas.TabIndex = 4;
            // 
            // lblIntercambiadas
            // 
            lblIntercambiadas.AutoSize = true;
            lblIntercambiadas.Location = new Point(61, 171);
            lblIntercambiadas.Name = "lblIntercambiadas";
            lblIntercambiadas.Size = new Size(215, 15);
            lblIntercambiadas.TabIndex = 5;
            lblIntercambiadas.Text = "Primera y tercera cifra intercambiadas  :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(188, 230);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(88, 30);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 308);
            Controls.Add(btnCalcular);
            Controls.Add(lblIntercambiadas);
            Controls.Add(txtIntercambiadas);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private Label lblNumero2;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtIntercambiadas;
        private Label lblIntercambiadas;
        private Button btnCalcular;
    }
}