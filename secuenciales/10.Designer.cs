namespace AppFP.secuenciales
{
    partial class _10
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
            lblReves = new Label();
            btnCalcular = new Button();
            txtNumero = new TextBox();
            txtReves = new TextBox();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(52, 48);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(156, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Numero natural de 4 cifras  :";
            // 
            // lblReves
            // 
            lblReves.AutoSize = true;
            lblReves.Location = new Point(52, 113);
            lblReves.Name = "lblReves";
            lblReves.Size = new Size(102, 15);
            lblReves.TabIndex = 1;
            lblReves.Text = "Numero al reves  :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(133, 177);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(244, 40);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(67, 23);
            txtNumero.TabIndex = 3;
            // 
            // txtReves
            // 
            txtReves.Location = new Point(244, 105);
            txtReves.Name = "txtReves";
            txtReves.Size = new Size(67, 23);
            txtReves.TabIndex = 4;
            // 
            // _10
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(385, 245);
            Controls.Add(txtReves);
            Controls.Add(txtNumero);
            Controls.Add(btnCalcular);
            Controls.Add(lblReves);
            Controls.Add(lblNumero);
            Name = "_10";
            Text = "_10";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblReves;
        private Button btnCalcular;
        private TextBox txtNumero;
        private TextBox txtReves;
    }
}