namespace AppFP.secuenciales
{
    partial class _05
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
            btnCalcular = new Button();
            lblGB = new Label();
            lblMB = new Label();
            lblKB = new Label();
            lblBY = new Label();
            txtGB = new TextBox();
            txtMB = new TextBox();
            txtKB = new TextBox();
            txtBY = new TextBox();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(188, 261);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(87, 32);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblGB
            // 
            lblGB.AutoSize = true;
            lblGB.Location = new Point(52, 54);
            lblGB.Name = "lblGB";
            lblGB.Size = new Size(184, 15);
            lblGB.TabIndex = 1;
            lblGB.Text = "Capacidad del disco duro en GB  :";
            // 
            // lblMB
            // 
            lblMB.AutoSize = true;
            lblMB.Location = new Point(202, 100);
            lblMB.Name = "lblMB";
            lblMB.Size = new Size(34, 15);
            lblMB.TabIndex = 2;
            lblMB.Text = "MB  :";
            // 
            // lblKB
            // 
            lblKB.AutoSize = true;
            lblKB.Location = new Point(206, 148);
            lblKB.Name = "lblKB";
            lblKB.Size = new Size(30, 15);
            lblKB.TabIndex = 3;
            lblKB.Text = "KB  :";
            // 
            // lblBY
            // 
            lblBY.AutoSize = true;
            lblBY.Location = new Point(188, 196);
            lblBY.Name = "lblBY";
            lblBY.Size = new Size(48, 15);
            lblBY.TabIndex = 4;
            lblBY.Text = "BYTES  :";
            // 
            // txtGB
            // 
            txtGB.Location = new Point(270, 46);
            txtGB.Name = "txtGB";
            txtGB.Size = new Size(67, 23);
            txtGB.TabIndex = 5;
            // 
            // txtMB
            // 
            txtMB.Location = new Point(270, 92);
            txtMB.Name = "txtMB";
            txtMB.ReadOnly = true;
            txtMB.Size = new Size(67, 23);
            txtMB.TabIndex = 6;
            // 
            // txtKB
            // 
            txtKB.Location = new Point(270, 140);
            txtKB.Name = "txtKB";
            txtKB.ReadOnly = true;
            txtKB.Size = new Size(67, 23);
            txtKB.TabIndex = 7;
            // 
            // txtBY
            // 
            txtBY.Location = new Point(270, 188);
            txtBY.Name = "txtBY";
            txtBY.ReadOnly = true;
            txtBY.Size = new Size(67, 23);
            txtBY.TabIndex = 8;
            // 
            // _05
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 344);
            Controls.Add(txtBY);
            Controls.Add(txtKB);
            Controls.Add(txtMB);
            Controls.Add(txtGB);
            Controls.Add(lblBY);
            Controls.Add(lblKB);
            Controls.Add(lblMB);
            Controls.Add(lblGB);
            Controls.Add(btnCalcular);
            Name = "_05";
            Text = "_05";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private Label lblGB;
        private Label lblMB;
        private Label lblKB;
        private Label lblBY;
        private TextBox txtGB;
        private TextBox txtMB;
        private TextBox txtKB;
        private TextBox txtBY;
    }
}