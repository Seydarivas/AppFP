namespace AppFP.secuenciales
{
    partial class _06
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
            lblRadio = new Label();
            lblAltura = new Label();
            lblArea = new Label();
            lblVolumen = new Label();
            txtRadio = new TextBox();
            txtAltura = new TextBox();
            txtArea = new TextBox();
            txtVolumen = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(55, 55);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(43, 15);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "radio  :";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(259, 55);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(46, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "altura  :";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(97, 118);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(129, 15);
            lblArea.TabIndex = 2;
            lblArea.Text = "Area total del cilindro  :";
            // 
            // lblVolumen
            // 
            lblVolumen.AutoSize = true;
            lblVolumen.Location = new Point(101, 168);
            lblVolumen.Name = "lblVolumen";
            lblVolumen.Size = new Size(125, 15);
            lblVolumen.TabIndex = 3;
            lblVolumen.Text = "Volumen del cilindro  :";
            // 
            // txtRadio
            // 
            txtRadio.Location = new Point(130, 47);
            txtRadio.Name = "txtRadio";
            txtRadio.Size = new Size(75, 23);
            txtRadio.TabIndex = 4;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(344, 52);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(75, 23);
            txtAltura.TabIndex = 5;
            // 
            // txtArea
            // 
            txtArea.Location = new Point(259, 110);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(81, 23);
            txtArea.TabIndex = 6;
            // 
            // txtVolumen
            // 
            txtVolumen.Location = new Point(259, 160);
            txtVolumen.Name = "txtVolumen";
            txtVolumen.Size = new Size(81, 23);
            txtVolumen.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(186, 232);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 33);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(475, 303);
            Controls.Add(btnCalcular);
            Controls.Add(txtVolumen);
            Controls.Add(txtArea);
            Controls.Add(txtAltura);
            Controls.Add(txtRadio);
            Controls.Add(lblVolumen);
            Controls.Add(lblArea);
            Controls.Add(lblAltura);
            Controls.Add(lblRadio);
            Name = "_06";
            Text = "_06";
            Load += _06_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private Label lblAltura;
        private Label lblArea;
        private Label lblVolumen;
        private TextBox txtRadio;
        private TextBox txtAltura;
        private TextBox txtArea;
        private TextBox txtVolumen;
        private Button btnCalcular;
    }
}