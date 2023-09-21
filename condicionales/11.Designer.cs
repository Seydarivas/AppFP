namespace AppFP.condicionales
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
            lblNumero = new Label();
            lblSigno = new Label();
            txtNumero = new TextBox();
            txtSigno = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(83, 61);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(116, 15);
            lblNumero.TabIndex = 0;
            lblNumero.Text = "Ingrese un numero  :";
            // 
            // lblSigno
            // 
            lblSigno.AutoSize = true;
            lblSigno.Location = new Point(83, 119);
            lblSigno.Name = "lblSigno";
            lblSigno.Size = new Size(46, 15);
            lblSigno.TabIndex = 1;
            lblSigno.Text = "Signo  :";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(242, 53);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(75, 23);
            txtNumero.TabIndex = 2;
            // 
            // txtSigno
            // 
            txtSigno.Location = new Point(170, 111);
            txtSigno.Name = "txtSigno";
            txtSigno.Size = new Size(95, 23);
            txtSigno.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(148, 186);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 28);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _11
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 246);
            Controls.Add(btnCalcular);
            Controls.Add(txtSigno);
            Controls.Add(txtNumero);
            Controls.Add(lblSigno);
            Controls.Add(lblNumero);
            Name = "_11";
            Text = "_11";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumero;
        private Label lblSigno;
        private TextBox txtNumero;
        private TextBox txtSigno;
        private Button btnCalcular;
    }
}