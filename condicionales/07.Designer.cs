namespace AppFP.condicionales
{
    partial class _07
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
            lblNumero3 = new Label();
            lblIntermedio = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtNumero3 = new TextBox();
            txtIntermedio = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(60, 55);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(96, 15);
            lblNumero1.TabIndex = 0;
            lblNumero1.Text = "Primer numero  :";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(60, 99);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(108, 15);
            lblNumero2.TabIndex = 1;
            lblNumero2.Text = "Segundo numero  :";
            // 
            // lblNumero3
            // 
            lblNumero3.AutoSize = true;
            lblNumero3.Location = new Point(60, 148);
            lblNumero3.Name = "lblNumero3";
            lblNumero3.Size = new Size(92, 15);
            lblNumero3.TabIndex = 2;
            lblNumero3.Text = "Tercer numero  :";
            // 
            // lblIntermedio
            // 
            lblIntermedio.AutoSize = true;
            lblIntermedio.Location = new Point(60, 195);
            lblIntermedio.Name = "lblIntermedio";
            lblIntermedio.Size = new Size(121, 15);
            lblIntermedio.TabIndex = 3;
            lblIntermedio.Text = "Numero intermedio  :";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(199, 47);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(63, 23);
            txtNumero1.TabIndex = 4;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(199, 91);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(63, 23);
            txtNumero2.TabIndex = 5;
            // 
            // txtNumero3
            // 
            txtNumero3.Location = new Point(199, 140);
            txtNumero3.Name = "txtNumero3";
            txtNumero3.Size = new Size(63, 23);
            txtNumero3.TabIndex = 6;
            // 
            // txtIntermedio
            // 
            txtIntermedio.Location = new Point(199, 187);
            txtIntermedio.Name = "txtIntermedio";
            txtIntermedio.Size = new Size(63, 23);
            txtIntermedio.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(130, 256);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(87, 26);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(335, 311);
            Controls.Add(btnCalcular);
            Controls.Add(txtIntermedio);
            Controls.Add(txtNumero3);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblIntermedio);
            Controls.Add(lblNumero3);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblNumero3;
        private Label lblIntermedio;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtNumero3;
        private TextBox txtIntermedio;
        private Button btnCalcular;
    }
}