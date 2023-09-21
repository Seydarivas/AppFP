namespace AppFP.secuenciales
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
            lblPies = new Label();
            lblPulgadas = new Label();
            lblMetros = new Label();
            txtMetros = new TextBox();
            txtPulgadas = new TextBox();
            txtPies = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblPies
            // 
            lblPies.AutoSize = true;
            lblPies.Location = new Point(50, 65);
            lblPies.Name = "lblPies";
            lblPies.Size = new Size(98, 15);
            lblPies.TabIndex = 0;
            lblPies.Text = "Estatura en pies  :";
            // 
            // lblPulgadas
            // 
            lblPulgadas.AutoSize = true;
            lblPulgadas.Location = new Point(50, 131);
            lblPulgadas.Name = "lblPulgadas";
            lblPulgadas.Size = new Size(125, 15);
            lblPulgadas.TabIndex = 1;
            lblPulgadas.Text = "Estatura en pulgadas  :";
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(50, 189);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(158, 15);
            lblMetros.TabIndex = 2;
            lblMetros.Text = "Total de estatura en metros  :";
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(233, 181);
            txtMetros.Name = "txtMetros";
            txtMetros.ReadOnly = true;
            txtMetros.Size = new Size(78, 23);
            txtMetros.TabIndex = 3;
            // 
            // txtPulgadas
            // 
            txtPulgadas.Location = new Point(190, 123);
            txtPulgadas.Name = "txtPulgadas";
            txtPulgadas.Size = new Size(68, 23);
            txtPulgadas.TabIndex = 4;
            // 
            // txtPies
            // 
            txtPies.Location = new Point(190, 62);
            txtPies.Name = "txtPies";
            txtPies.Size = new Size(68, 23);
            txtPies.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(148, 252);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(77, 32);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _04
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 332);
            Controls.Add(btnCalcular);
            Controls.Add(txtPies);
            Controls.Add(txtPulgadas);
            Controls.Add(txtMetros);
            Controls.Add(lblMetros);
            Controls.Add(lblPulgadas);
            Controls.Add(lblPies);
            Name = "_04";
            Text = "_04";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPies;
        private Label lblPulgadas;
        private Label lblMetros;
        private TextBox txtMetros;
        private TextBox txtPulgadas;
        private TextBox txtPies;
        private Button btnCalcular;
    }
}