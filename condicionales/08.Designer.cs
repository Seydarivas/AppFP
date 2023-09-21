namespace AppFP.condicionales
{
    partial class _08
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
            lblExamen1 = new Label();
            lblExamen2 = new Label();
            lblExamen3 = new Label();
            txtExamen2 = new TextBox();
            txtExamen1 = new TextBox();
            txtExamen3 = new TextBox();
            txtPropina = new TextBox();
            lblPropina = new Label();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblExamen1
            // 
            lblExamen1.AutoSize = true;
            lblExamen1.Location = new Point(89, 53);
            lblExamen1.Name = "lblExamen1";
            lblExamen1.Size = new Size(144, 15);
            lblExamen1.TabIndex = 0;
            lblExamen1.Text = "Nota del primer examen  :";
            // 
            // lblExamen2
            // 
            lblExamen2.AutoSize = true;
            lblExamen2.Location = new Point(92, 103);
            lblExamen2.Name = "lblExamen2";
            lblExamen2.Size = new Size(155, 15);
            lblExamen2.TabIndex = 1;
            lblExamen2.Text = "Nota del segundo examen  :";
            // 
            // lblExamen3
            // 
            lblExamen3.AutoSize = true;
            lblExamen3.Location = new Point(89, 154);
            lblExamen3.Name = "lblExamen3";
            lblExamen3.Size = new Size(139, 15);
            lblExamen3.TabIndex = 2;
            lblExamen3.Text = "Nota del tercer examen  :";
            // 
            // txtExamen2
            // 
            txtExamen2.Location = new Point(284, 95);
            txtExamen2.Name = "txtExamen2";
            txtExamen2.Size = new Size(74, 23);
            txtExamen2.TabIndex = 4;
            // 
            // txtExamen1
            // 
            txtExamen1.Location = new Point(284, 45);
            txtExamen1.Name = "txtExamen1";
            txtExamen1.Size = new Size(74, 23);
            txtExamen1.TabIndex = 5;
            // 
            // txtExamen3
            // 
            txtExamen3.Location = new Point(284, 146);
            txtExamen3.Name = "txtExamen3";
            txtExamen3.Size = new Size(74, 23);
            txtExamen3.TabIndex = 6;
            // 
            // txtPropina
            // 
            txtPropina.Location = new Point(393, 199);
            txtPropina.Name = "txtPropina";
            txtPropina.Size = new Size(72, 23);
            txtPropina.TabIndex = 7;
            // 
            // lblPropina
            // 
            lblPropina.AutoSize = true;
            lblPropina.Location = new Point(34, 207);
            lblPropina.Name = "lblPropina";
            lblPropina.Size = new Size(324, 15);
            lblPropina.TabIndex = 8;
            lblPropina.Text = "Monto mensual de la propina por la nota de sus examenes  :";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(211, 274);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 28);
            btnCalcular.TabIndex = 9;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 394);
            Controls.Add(btnCalcular);
            Controls.Add(lblPropina);
            Controls.Add(txtPropina);
            Controls.Add(txtExamen3);
            Controls.Add(txtExamen1);
            Controls.Add(txtExamen2);
            Controls.Add(lblExamen3);
            Controls.Add(lblExamen2);
            Controls.Add(lblExamen1);
            Name = "_08";
            Text = "_08";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblExamen1;
        private Label lblExamen2;
        private Label lblExamen3;
        private TextBox txtExamen2;
        private TextBox txtExamen1;
        private TextBox txtExamen3;
        private TextBox txtPropina;
        private Label lblPropina;
        private Button btnCalcular;
    }
}