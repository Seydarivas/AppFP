namespace AppFP.secuenciales
{
    partial class _13
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
            lblOpuesto = new Label();
            lblAdyacente = new Label();
            lblHipotenusa = new Label();
            txtOpuesto = new TextBox();
            txtAdyacente = new TextBox();
            txtHipotenusa = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblOpuesto
            // 
            lblOpuesto.AutoSize = true;
            lblOpuesto.Location = new Point(73, 58);
            lblOpuesto.Name = "lblOpuesto";
            lblOpuesto.Size = new Size(97, 15);
            lblOpuesto.TabIndex = 0;
            lblOpuesto.Text = "Cateto opuesto  :";
            // 
            // lblAdyacente
            // 
            lblAdyacente.AutoSize = true;
            lblAdyacente.Location = new Point(73, 104);
            lblAdyacente.Name = "lblAdyacente";
            lblAdyacente.Size = new Size(108, 15);
            lblAdyacente.TabIndex = 1;
            lblAdyacente.Text = "Cateto adyacente  :";
            // 
            // lblHipotenusa
            // 
            lblHipotenusa.AutoSize = true;
            lblHipotenusa.Location = new Point(73, 154);
            lblHipotenusa.Name = "lblHipotenusa";
            lblHipotenusa.Size = new Size(77, 15);
            lblHipotenusa.TabIndex = 2;
            lblHipotenusa.Text = "Hipotenusa  :";
            // 
            // txtOpuesto
            // 
            txtOpuesto.Location = new Point(214, 50);
            txtOpuesto.Name = "txtOpuesto";
            txtOpuesto.Size = new Size(71, 23);
            txtOpuesto.TabIndex = 3;
            // 
            // txtAdyacente
            // 
            txtAdyacente.Location = new Point(214, 96);
            txtAdyacente.Name = "txtAdyacente";
            txtAdyacente.Size = new Size(71, 23);
            txtAdyacente.TabIndex = 4;
            // 
            // txtHipotenusa
            // 
            txtHipotenusa.Location = new Point(214, 146);
            txtHipotenusa.Name = "txtHipotenusa";
            txtHipotenusa.Size = new Size(71, 23);
            txtHipotenusa.TabIndex = 5;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(149, 226);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 6;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 281);
            Controls.Add(btnCalcular);
            Controls.Add(txtHipotenusa);
            Controls.Add(txtAdyacente);
            Controls.Add(txtOpuesto);
            Controls.Add(lblHipotenusa);
            Controls.Add(lblAdyacente);
            Controls.Add(lblOpuesto);
            Name = "_13";
            Text = "_13";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOpuesto;
        private Label lblAdyacente;
        private Label lblHipotenusa;
        private TextBox txtOpuesto;
        private TextBox txtAdyacente;
        private TextBox txtHipotenusa;
        private Button btnCalcular;
    }
}