namespace AppFP.secuenciales
{
    partial class _03
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
            lblTramo1 = new Label();
            lblTramo2 = new Label();
            lblTramo3 = new Label();
            lblMetros = new Label();
            lblYardas = new Label();
            txtTramo1 = new TextBox();
            txtTramo2 = new TextBox();
            txtTramo3 = new TextBox();
            txtMetros = new TextBox();
            txtYardas = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblTramo1
            // 
            lblTramo1.AutoSize = true;
            lblTramo1.Location = new Point(51, 50);
            lblTramo1.Name = "lblTramo1";
            lblTramo1.Size = new Size(122, 15);
            lblTramo1.TabIndex = 0;
            lblTramo1.Text = "Primer tramo en km  :";
            // 
            // lblTramo2
            // 
            lblTramo2.AutoSize = true;
            lblTramo2.Location = new Point(51, 109);
            lblTramo2.Name = "lblTramo2";
            lblTramo2.Size = new Size(138, 15);
            lblTramo2.TabIndex = 1;
            lblTramo2.Text = "Segundo tramo en pies  :";
            lblTramo2.Click += lblTramo2_Click;
            // 
            // lblTramo3
            // 
            lblTramo3.AutoSize = true;
            lblTramo3.Location = new Point(51, 157);
            lblTramo3.Name = "lblTramo3";
            lblTramo3.Size = new Size(132, 15);
            lblTramo3.TabIndex = 2;
            lblTramo3.Text = "Tercer tramo en millas  :";
            // 
            // lblMetros
            // 
            lblMetros.AutoSize = true;
            lblMetros.Location = new Point(51, 211);
            lblMetros.Name = "lblMetros";
            lblMetros.Size = new Size(150, 15);
            lblMetros.TabIndex = 3;
            lblMetros.Text = "Recorrido total en metros  :";
            // 
            // lblYardas
            // 
            lblYardas.AutoSize = true;
            lblYardas.Location = new Point(51, 267);
            lblYardas.Name = "lblYardas";
            lblYardas.Size = new Size(147, 15);
            lblYardas.TabIndex = 4;
            lblYardas.Text = "Recorrido total en yardas  :";
            // 
            // txtTramo1
            // 
            txtTramo1.Location = new Point(207, 42);
            txtTramo1.Name = "txtTramo1";
            txtTramo1.Size = new Size(78, 23);
            txtTramo1.TabIndex = 5;
            // 
            // txtTramo2
            // 
            txtTramo2.Location = new Point(207, 101);
            txtTramo2.Name = "txtTramo2";
            txtTramo2.Size = new Size(78, 23);
            txtTramo2.TabIndex = 6;
            // 
            // txtTramo3
            // 
            txtTramo3.Location = new Point(207, 149);
            txtTramo3.Name = "txtTramo3";
            txtTramo3.Size = new Size(78, 23);
            txtTramo3.TabIndex = 7;
            // 
            // txtMetros
            // 
            txtMetros.Location = new Point(207, 203);
            txtMetros.Name = "txtMetros";
            txtMetros.ReadOnly = true;
            txtMetros.Size = new Size(78, 23);
            txtMetros.TabIndex = 8;
            // 
            // txtYardas
            // 
            txtYardas.Location = new Point(207, 259);
            txtYardas.Name = "txtYardas";
            txtYardas.ReadOnly = true;
            txtYardas.Size = new Size(78, 23);
            txtYardas.TabIndex = 9;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(137, 323);
            btnCalcular.Margin = new Padding(4);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(85, 35);
            btnCalcular.TabIndex = 10;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // _03
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(359, 415);
            Controls.Add(btnCalcular);
            Controls.Add(txtYardas);
            Controls.Add(txtMetros);
            Controls.Add(txtTramo3);
            Controls.Add(txtTramo2);
            Controls.Add(txtTramo1);
            Controls.Add(lblYardas);
            Controls.Add(lblMetros);
            Controls.Add(lblTramo3);
            Controls.Add(lblTramo2);
            Controls.Add(lblTramo1);
            Name = "_03";
            Text = "_03";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTramo1;
        private Label lblTramo2;
        private Label lblTramo3;
        private Label lblMetros;
        private Label lblYardas;
        private TextBox txtTramo1;
        private TextBox txtTramo2;
        private TextBox txtTramo3;
        private TextBox txtMetros;
        private TextBox txtYardas;
        private Button btnCalcular;
    }
}