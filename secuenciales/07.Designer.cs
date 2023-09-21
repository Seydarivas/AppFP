namespace AppFP.secuenciales
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
            lblBase = new Label();
            lblAltura = new Label();
            lblArea = new Label();
            lblPerimetro = new Label();
            btnCalcular = new Button();
            txtBase = new TextBox();
            txtAltura = new TextBox();
            txtArea = new TextBox();
            txtPerimetro = new TextBox();
            SuspendLayout();
            // 
            // lblBase
            // 
            lblBase.AutoSize = true;
            lblBase.Location = new Point(51, 45);
            lblBase.Name = "lblBase";
            lblBase.Size = new Size(40, 15);
            lblBase.TabIndex = 0;
            lblBase.Text = "base  :";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(257, 45);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(46, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "altura  :";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(98, 102);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(119, 15);
            lblArea.TabIndex = 2;
            lblArea.Text = "Area del rectangulo  :";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(98, 151);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(147, 15);
            lblPerimetro.TabIndex = 3;
            lblPerimetro.Text = "Perimetro del rectangulo  :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(194, 211);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(86, 30);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(117, 37);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(66, 23);
            txtBase.TabIndex = 5;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(331, 37);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(68, 23);
            txtAltura.TabIndex = 6;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(244, 94);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(91, 23);
            txtArea.TabIndex = 7;
            // 
            // txtPerimetro
            // 
            txtPerimetro.Location = new Point(271, 143);
            txtPerimetro.Name = "txtPerimetro";
            txtPerimetro.Size = new Size(90, 23);
            txtPerimetro.TabIndex = 8;
            // 
            // _07
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 282);
            Controls.Add(txtPerimetro);
            Controls.Add(txtArea);
            Controls.Add(txtAltura);
            Controls.Add(txtBase);
            Controls.Add(btnCalcular);
            Controls.Add(lblPerimetro);
            Controls.Add(lblArea);
            Controls.Add(lblAltura);
            Controls.Add(lblBase);
            Name = "_07";
            Text = "_07";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBase;
        private Label lblAltura;
        private Label lblArea;
        private Label lblPerimetro;
        private Button btnCalcular;
        private TextBox txtBase;
        private TextBox txtAltura;
        private TextBox txtArea;
        private TextBox txtPerimetro;
    }
}