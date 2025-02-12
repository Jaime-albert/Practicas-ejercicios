namespace practica01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSuma = new Button();
            texN1 = new TextBox();
            lblcambio = new Label();
            lblResultado = new Label();
            texN2 = new TextBox();
            btnResta = new Button();
            btnMultip = new Button();
            btnDiv = new Button();
            SuspendLayout();
            // 
            // btnSuma
            // 
            btnSuma.BackColor = SystemColors.ButtonFace;
            btnSuma.ForeColor = SystemColors.ActiveCaptionText;
            btnSuma.Location = new Point(0, 0);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(92, 23);
            btnSuma.TabIndex = 0;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = false;
            btnSuma.Click += btnSuma_Click;
            // 
            // texN1
            // 
            texN1.BackColor = SystemColors.ButtonFace;
            texN1.ForeColor = SystemColors.ActiveCaptionText;
            texN1.Location = new Point(103, 26);
            texN1.Name = "texN1";
            texN1.Size = new Size(100, 23);
            texN1.TabIndex = 1;
            texN1.TextChanged += texN1_TextChanged;
            // 
            // lblcambio
            // 
            lblcambio.AutoSize = true;
            lblcambio.BackColor = SystemColors.ButtonFace;
            lblcambio.ForeColor = SystemColors.ActiveCaptionText;
            lblcambio.Location = new Point(227, 29);
            lblcambio.Name = "lblcambio";
            lblcambio.Size = new Size(47, 15);
            lblcambio.TabIndex = 2;
            lblcambio.Text = "cambio";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = SystemColors.ButtonFace;
            lblResultado.ForeColor = SystemColors.ActiveCaptionText;
            lblResultado.Location = new Point(436, 29);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            lblResultado.Click += label2_Click;
            // 
            // texN2
            // 
            texN2.BackColor = SystemColors.ButtonFace;
            texN2.ForeColor = SystemColors.ActiveCaptionText;
            texN2.Location = new Point(298, 26);
            texN2.Name = "texN2";
            texN2.Size = new Size(100, 23);
            texN2.TabIndex = 4;
            // 
            // btnResta
            // 
            btnResta.BackColor = SystemColors.ButtonFace;
            btnResta.ForeColor = SystemColors.ActiveCaptionText;
            btnResta.Location = new Point(0, 29);
            btnResta.Name = "btnResta";
            btnResta.Size = new Size(92, 23);
            btnResta.TabIndex = 5;
            btnResta.Text = "Resta";
            btnResta.UseVisualStyleBackColor = false;
            btnResta.Click += btnResta_Click;
            // 
            // btnMultip
            // 
            btnMultip.BackColor = SystemColors.ButtonFace;
            btnMultip.ForeColor = SystemColors.ActiveCaptionText;
            btnMultip.Location = new Point(0, 58);
            btnMultip.Name = "btnMultip";
            btnMultip.Size = new Size(92, 23);
            btnMultip.TabIndex = 6;
            btnMultip.Text = "Multiplicacion";
            btnMultip.UseVisualStyleBackColor = false;
            btnMultip.Click += btnMultip_Click;
            // 
            // btnDiv
            // 
            btnDiv.BackColor = SystemColors.ButtonFace;
            btnDiv.ForeColor = SystemColors.ActiveCaptionText;
            btnDiv.Location = new Point(0, 87);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(92, 23);
            btnDiv.TabIndex = 7;
            btnDiv.Text = "Division";
            btnDiv.UseVisualStyleBackColor = false;
            btnDiv.Click += btnDiv_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(507, 114);
            Controls.Add(btnDiv);
            Controls.Add(btnMultip);
            Controls.Add(btnResta);
            Controls.Add(texN2);
            Controls.Add(lblResultado);
            Controls.Add(lblcambio);
            Controls.Add(texN1);
            Controls.Add(btnSuma);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSuma;
        private TextBox texN1;
        private Label lblcambio;
        private Label lblResultado;
        private TextBox texN2;
        private Button btnResta;
        private Button btnMultip;
        private Button btnDiv;
    }
}
