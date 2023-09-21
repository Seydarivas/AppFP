namespace AppFP.condicionales
{
    partial class _04
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
            lblNota1 = new Label();
            lblNota2 = new Label();
            lblNota3 = new Label();
            lblPromedio = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtPromedio = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNota1
            // 
            lblNota1.AutoSize = true;
            lblNota1.Location = new Point(47, 56);
            lblNota1.Name = "lblNota1";
            lblNota1.Size = new Size(159, 15);
            lblNota1.TabIndex = 0;
            lblNota1.Text = "Nota de la primera practica  :";
            // 
            // lblNota2
            // 
            lblNota2.AutoSize = true;
            lblNota2.Location = new Point(47, 110);
            lblNota2.Name = "lblNota2";
            lblNota2.Size = new Size(163, 15);
            lblNota2.TabIndex = 1;
            lblNota2.Text = "Nota de la segunda practica  :";
            // 
            // lblNota3
            // 
            lblNota3.AutoSize = true;
            lblNota3.Location = new Point(47, 159);
            lblNota3.Name = "lblNota3";
            lblNota3.Size = new Size(154, 15);
            lblNota3.TabIndex = 2;
            lblNota3.Text = "Nota de la tercera practica  :";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(47, 215);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(94, 15);
            lblPromedio.TabIndex = 3;
            lblPromedio.Text = "Promedio final  :";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(239, 48);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(78, 23);
            txtNota1.TabIndex = 5;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(239, 102);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(78, 23);
            txtNota2.TabIndex = 6;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(239, 151);
            txtNota3.Name = "txtNota3";
            txtNota3.Size = new Size(78, 23);
            txtNota3.TabIndex = 7;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(239, 207);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(78, 23);
            txtPromedio.TabIndex = 8;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(142, 286);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(96, 31);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 361);
            Controls.Add(btnCalcular);
            Controls.Add(txtPromedio);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(lblPromedio);
            Controls.Add(lblNota3);
            Controls.Add(lblNota2);
            Controls.Add(lblNota1);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNota1;
        private Label lblNota2;
        private Label lblNota3;
        private Label lblPromedio;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtPromedio;
        private Button btnCalcular;
    }
}