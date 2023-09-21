namespace AppFP.condicionales
{
    partial class _12
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
            lblDia = new Label();
            txtNumero = new TextBox();
            txtDia = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(60, 65);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(165, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingrese un numero del 1 al 7  :";
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(60, 128);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(98, 15);
            lblDia.TabIndex = 1;
            lblDia.Text = "Nombre del dia  :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(276, 57);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(79, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtDia
            // 
            txtDia.Location = new Point(203, 120);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(111, 23);
            txtDia.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(168, 195);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 31);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 261);
            Controls.Add(btnCalcular);
            Controls.Add(txtDia);
            Controls.Add(txtNumero);
            Controls.Add(lblDia);
            Controls.Add(lblNumero);
            Name = "_12";
            Text = "_12";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblDia;
        private TextBox txtNumero;
        private TextBox txtDia;
        private Button btnCalcular;
    }
}