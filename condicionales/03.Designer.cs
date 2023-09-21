namespace AppFP.condicionales
{
    partial class _03
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
            lblGrados = new Label();
            lblAngulo = new Label();
            txtGrados = new TextBox();
            txtAngulo = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblGrados
            // 
            lblGrados.AutoSize = true;
            lblGrados.Location = new Point(52, 57);
            lblGrados.Name = "lblGrados";
            lblGrados.Size = new Size(110, 15);
            lblGrados.TabIndex = 0;
            lblGrados.Text = "Angulo en grados  :";
            // 
            // lblAngulo
            // 
            lblAngulo.AutoSize = true;
            lblAngulo.Location = new Point(52, 109);
            lblAngulo.Name = "lblAngulo";
            lblAngulo.Size = new Size(83, 15);
            lblAngulo.TabIndex = 1;
            lblAngulo.Text = "Clasificacion  :";
            // 
            // txtGrados
            // 
            txtGrados.Location = new Point(193, 49);
            txtGrados.Name = "txtGrados";
            txtGrados.Size = new Size(70, 23);
            txtGrados.TabIndex = 2;
            // 
            // txtAngulo
            // 
            txtAngulo.Location = new Point(193, 101);
            txtAngulo.Name = "txtAngulo";
            txtAngulo.Size = new Size(70, 23);
            txtAngulo.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(118, 166);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(85, 25);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 223);
            Controls.Add(btnCalcular);
            Controls.Add(txtAngulo);
            Controls.Add(txtGrados);
            Controls.Add(lblAngulo);
            Controls.Add(lblGrados);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGrados;
        private Label lblAngulo;
        private TextBox txtGrados;
        private TextBox txtAngulo;
        private Button btnCalcular;
    }
}