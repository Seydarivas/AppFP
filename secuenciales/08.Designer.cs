namespace AppFP.secuenciales
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
            lblRadio = new Label();
            lblAltura = new Label();
            linkLabel2 = new LinkLabel();
            txtAltura = new TextBox();
            txtAlateral = new TextBox();
            txtBase = new TextBox();
            txtAbase = new TextBox();
            lblAbase = new Label();
            lblAlateral = new Label();
            lblAtotal = new Label();
            txtAtotal = new TextBox();
            btnCalcular = new Button();
            SuspendLayout();
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(49, 55);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(43, 15);
            lblRadio.TabIndex = 0;
            lblRadio.Text = "radio  :";
            // 
            // lblAltura
            // 
            lblAltura.AutoSize = true;
            lblAltura.Location = new Point(284, 55);
            lblAltura.Name = "lblAltura";
            lblAltura.Size = new Size(46, 15);
            lblAltura.TabIndex = 1;
            lblAltura.Text = "altura  :";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(103, 228);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(0, 15);
            linkLabel2.TabIndex = 3;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(371, 47);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(73, 23);
            txtAltura.TabIndex = 4;
            // 
            // txtAlateral
            // 
            txtAlateral.Location = new Point(284, 155);
            txtAlateral.Name = "txtAlateral";
            txtAlateral.Size = new Size(85, 23);
            txtAlateral.TabIndex = 5;
            // 
            // txtBase
            // 
            txtBase.Location = new Point(123, 47);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(76, 23);
            txtBase.TabIndex = 6;
            // 
            // txtAbase
            // 
            txtAbase.Location = new Point(284, 109);
            txtAbase.Name = "txtAbase";
            txtAbase.Size = new Size(85, 23);
            txtAbase.TabIndex = 7;
            // 
            // lblAbase
            // 
            lblAbase.AutoSize = true;
            lblAbase.Location = new Point(93, 117);
            lblAbase.Name = "lblAbase";
            lblAbase.Size = new Size(157, 15);
            lblAbase.TabIndex = 8;
            lblAbase.Text = "Area de la base del cilindro  :";
            // 
            // lblAlateral
            // 
            lblAlateral.AutoSize = true;
            lblAlateral.Location = new Point(93, 163);
            lblAlateral.Name = "lblAlateral";
            lblAlateral.Size = new Size(137, 15);
            lblAlateral.TabIndex = 9;
            lblAlateral.Text = "Area lateral del cilindro  :";
            // 
            // lblAtotal
            // 
            lblAtotal.AutoSize = true;
            lblAtotal.Location = new Point(93, 213);
            lblAtotal.Name = "lblAtotal";
            lblAtotal.Size = new Size(129, 15);
            lblAtotal.TabIndex = 10;
            lblAtotal.Text = "Area total del cilindro  :";
            // 
            // txtAtotal
            // 
            txtAtotal.Location = new Point(284, 205);
            txtAtotal.Name = "txtAtotal";
            txtAtotal.Size = new Size(85, 23);
            txtAtotal.TabIndex = 11;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(203, 275);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(89, 37);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            // 
            // _08
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 355);
            Controls.Add(btnCalcular);
            Controls.Add(txtAtotal);
            Controls.Add(lblAtotal);
            Controls.Add(lblAlateral);
            Controls.Add(lblAbase);
            Controls.Add(txtAbase);
            Controls.Add(txtBase);
            Controls.Add(txtAlateral);
            Controls.Add(txtAltura);
            Controls.Add(linkLabel2);
            Controls.Add(lblAltura);
            Controls.Add(lblRadio);
            Name = "_08";
            Text = "_08";
            Load += _08_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRadio;
        private Label lblAltura;
        private LinkLabel linkLabel2;
        private TextBox txtAltura;
        private TextBox txtAlateral;
        private TextBox txtBase;
        private TextBox txtAbase;
        private Label lblAbase;
        private Label lblAlateral;
        private Label lblAtotal;
        private TextBox txtAtotal;
        private Button btnCalcular;
    }
}