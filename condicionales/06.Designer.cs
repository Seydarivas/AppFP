namespace AppFP.condicionales
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
            lblEdad1 = new Label();
            lblEdad2 = new Label();
            lblEdad3 = new Label();
            lblMenor = new Label();
            lblMayor = new Label();
            txtEdad1 = new TextBox();
            txtEdad2 = new TextBox();
            txtEdad3 = new TextBox();
            txtMenor = new TextBox();
            txtMayor = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblEdad1
            // 
            lblEdad1.AutoSize = true;
            lblEdad1.Location = new Point(61, 55);
            lblEdad1.Name = "lblEdad1";
            lblEdad1.Size = new Size(86, 15);
            lblEdad1.TabIndex = 0;
            lblEdad1.Text = "Primera edad  :";
            // 
            // lblEdad2
            // 
            lblEdad2.AutoSize = true;
            lblEdad2.Location = new Point(61, 102);
            lblEdad2.Name = "lblEdad2";
            lblEdad2.Size = new Size(91, 15);
            lblEdad2.TabIndex = 1;
            lblEdad2.Text = "Segunda edad  :";
            // 
            // lblEdad3
            // 
            lblEdad3.AutoSize = true;
            lblEdad3.Location = new Point(61, 147);
            lblEdad3.Name = "lblEdad3";
            lblEdad3.Size = new Size(82, 15);
            lblEdad3.TabIndex = 2;
            lblEdad3.Text = "Tercera edad  :";
            // 
            // lblMenor
            // 
            lblMenor.AutoSize = true;
            lblMenor.Location = new Point(61, 193);
            lblMenor.Name = "lblMenor";
            lblMenor.Size = new Size(80, 15);
            lblMenor.TabIndex = 3;
            lblMenor.Text = "Edad menor  :";
            // 
            // lblMayor
            // 
            lblMayor.AutoSize = true;
            lblMayor.Location = new Point(61, 245);
            lblMayor.Name = "lblMayor";
            lblMayor.Size = new Size(79, 15);
            lblMayor.TabIndex = 4;
            lblMayor.Text = "Edad mayor  :";
            // 
            // txtEdad1
            // 
            txtEdad1.Location = new Point(188, 47);
            txtEdad1.Name = "txtEdad1";
            txtEdad1.Size = new Size(58, 23);
            txtEdad1.TabIndex = 5;
            // 
            // txtEdad2
            // 
            txtEdad2.Location = new Point(188, 94);
            txtEdad2.Name = "txtEdad2";
            txtEdad2.Size = new Size(58, 23);
            txtEdad2.TabIndex = 6;
            // 
            // txtEdad3
            // 
            txtEdad3.Location = new Point(188, 139);
            txtEdad3.Name = "txtEdad3";
            txtEdad3.Size = new Size(58, 23);
            txtEdad3.TabIndex = 7;
            // 
            // txtMenor
            // 
            txtMenor.Location = new Point(188, 185);
            txtMenor.Name = "txtMenor";
            txtMenor.Size = new Size(58, 23);
            txtMenor.TabIndex = 8;
            // 
            // txtMayor
            // 
            txtMayor.Location = new Point(188, 237);
            txtMayor.Name = "txtMayor";
            txtMayor.Size = new Size(58, 23);
            txtMayor.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(119, 304);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _06
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 358);
            Controls.Add(btnCalcular);
            Controls.Add(txtMayor);
            Controls.Add(txtMenor);
            Controls.Add(txtEdad3);
            Controls.Add(txtEdad2);
            Controls.Add(txtEdad1);
            Controls.Add(lblMayor);
            Controls.Add(lblMenor);
            Controls.Add(lblEdad3);
            Controls.Add(lblEdad2);
            Controls.Add(lblEdad1);
            Name = "_06";
            Text = "_06";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEdad1;
        private Label lblEdad2;
        private Label lblEdad3;
        private Label lblMenor;
        private Label lblMayor;
        private TextBox txtEdad1;
        private TextBox txtEdad2;
        private TextBox txtEdad3;
        private TextBox txtMenor;
        private TextBox txtMayor;
        private Button btnCalcular;
    }
}