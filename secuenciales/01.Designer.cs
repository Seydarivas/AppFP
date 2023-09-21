using System.Windows.Forms.VisualStyles;

namespace AppFP.secuenciales
{
    partial class _01
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
            lblVarones = new Label();
            lblMujeres = new Label();
            txtVarones = new TextBox();
            txtMujeres = new TextBox();
            btnCalcular = new Button();
            lblpVarones = new Label();
            lblpMujeres = new Label();
            SuspendLayout();
            // 
            // lblVarones
            // 
            lblVarones.AutoSize = true;
            lblVarones.Location = new Point(79, 50);
            lblVarones.Name = "lblVarones";
            lblVarones.Size = new Size(60, 15);
            lblVarones.TabIndex = 0;
            lblVarones.Text = "varones  : ";
            lblVarones.Click += label1_Click;
            // 
            // lblMujeres
            // 
            lblMujeres.AutoSize = true;
            lblMujeres.Location = new Point(82, 98);
            lblMujeres.Name = "lblMujeres";
            lblMujeres.Size = new Size(58, 15);
            lblMujeres.TabIndex = 1;
            lblMujeres.Text = "mujeres : ";
            // 
            // txtVarones
            // 
            txtVarones.Location = new Point(160, 42);
            txtVarones.Name = "txtVarones";
            txtVarones.Size = new Size(75, 23);
            txtVarones.TabIndex = 2;
            // 
            // txtMujeres
            // 
            txtMujeres.Location = new Point(160, 90);
            txtMujeres.Name = "txtMujeres";
            txtMujeres.Size = new Size(75, 23);
            txtMujeres.TabIndex = 3;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(129, 166);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblpVarones
            // 
            lblpVarones.AutoSize = true;
            lblpVarones.Location = new Point(283, 47);
            lblpVarones.Name = "lblpVarones";
            lblpVarones.Size = new Size(17, 15);
            lblpVarones.TabIndex = 5;
            lblpVarones.Text = "%";
            // 
            // lblpMujeres
            // 
            lblpMujeres.AutoSize = true;
            lblpMujeres.Location = new Point(283, 98);
            lblpMujeres.Name = "lblpMujeres";
            lblpMujeres.Size = new Size(17, 15);
            lblpMujeres.TabIndex = 6;
            lblpMujeres.Text = "%";
            // 
            // _01
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 294);
            Controls.Add(lblpMujeres);
            Controls.Add(lblpVarones);
            Controls.Add(btnCalcular);
            Controls.Add(txtMujeres);
            Controls.Add(txtVarones);
            Controls.Add(lblMujeres);
            Controls.Add(lblVarones);
            Name = "_01";
            Text = "_01";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVarones;
        private Label lblMujeres;
        private TextBox txtVarones;
        private TextBox txtMujeres;
        private Button btnCalcular;
        private Label lblpVarones;
        private Label lblpMujeres;

        



}
}