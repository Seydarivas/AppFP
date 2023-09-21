namespace AppFP.secuenciales
{
    partial class _02
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
            lblMetros = new Label();
            lblCentimetros = new Label();
            lblPulgadas = new Label();
            lblPies = new Label();
            lblYardas = new Label();
            txtMetros = new TextBox();
            txtCentimetros = new TextBox();
            txtPies = new TextBox();
            txtYardas = new TextBox();
            txtPulgadas = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(58, 52);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(50, 15);
            lblMetros.TabIndex = 0;
            lblMetros.Text = "Metros :";
            lblMetros.Click += label1_Click;
            // 
            // lblCentimetros
            // 
            lblCentimetros.AutoSize = true;
            lblCentimetros.Location = new Point(58, 102);
            lblCentimetros.Name = "lblCentimetros";
            lblCentimetros.Size = new Size(78, 15);
            lblCentimetros.TabIndex = 1;
            lblCentimetros.Text = "Centimetros :";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(58, 155);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(55, 15);
            lblPulgadas.TabIndex = 2;
            lblPulgadas.Text = "Pulgadas";
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(58, 209);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(34, 15);
            lblPies.TabIndex = 3;
            lblPies.Text = "Pies :";
            // 
            // lblYardas
            // 
            lblYardas.AutoSize = true;
            lblYardas.Location = new Point(58, 255);
            lblYardas.Name = "lblYardas";
            lblYardas.Size = new Size(47, 15);
            lblYardas.TabIndex = 4;
            lblYardas.Text = "Yardas :";
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(149, 44);
            txtMetros.Name = "txtMetros";
            txtMetros.Size = new Size(79, 23);
            txtMetros.TabIndex = 5;
            // 
            // txtCentimetros
            // 
            txtCentimetros.Location = new Point(149, 94);
            txtCentimetros.Name = "txtCentimetros";
            txtCentimetros.ReadOnly = true;
            txtCentimetros.Size = new Size(79, 23);
            txtCentimetros.TabIndex = 6;
            // 
            // txtPies
            // 
            txtPies.Location = new Point(149, 201);
            txtPies.Name = "txtPies";
            txtPies.ReadOnly = true;
            txtPies.Size = new Size(79, 23);
            txtPies.TabIndex = 7;
            // 
            // txtYardas
            // 
            txtYardas.Location = new Point(149, 247);
            txtYardas.Name = "txtYardas";
            txtYardas.ReadOnly = true;
            txtYardas.Size = new Size(79, 23);
            txtYardas.TabIndex = 8;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(149, 147);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.ReadOnly = true;
            txtPulgadas.Size = new Size(79, 23);
            txtPulgadas.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(107, 314);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(78, 26);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _02
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 372);
            Controls.Add(btnCalcular);
            Controls.Add(txtPulgadas);
            Controls.Add(txtYardas);
            Controls.Add(txtPies);
            Controls.Add(txtCentimetros);
            Controls.Add(txtMetros);
            Controls.Add(lblYardas);
            Controls.Add(lblPies);
            Controls.Add(lblPulgadas);
            Controls.Add(lblCentimetros);
            Controls.Add(lblMetros);
            Name = "_02";
            Text = "_02";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMetros;
        private Label lblCentimetros;
        private Label lblPulgadas;
        private Label lblPies;
        private Label lblYardas;
        private TextBox txtMetros;
        private TextBox txtCentimetros;
        private TextBox txtPies;
        private TextBox txtYardas;
        private TextBox txtPulgadas;
        private Button btnCalcular;
    }
}