namespace practica02
{
    partial class lblFormula
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
            lblNombre = new Label();
            lblForula = new Label();
            texN1 = new TextBox();
            lblResultado = new Label();
            btnConvertir = new Button();
            lblTit2 = new Label();
            lblFormula2 = new Label();
            btnConvertir2 = new Button();
            lblResultado2 = new Label();
            texN2 = new TextBox();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.White;
            lblNombre.ForeColor = Color.FromArgb(192, 0, 192);
            lblNombre.Location = new Point(104, 9);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(159, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Formula Celsius a Fahernheit\r\n";
            // 
            // lblForula
            // 
            lblForula.AutoSize = true;
            lblForula.BackColor = Color.White;
            lblForula.ForeColor = SystemColors.ControlText;
            lblForula.Location = new Point(95, 44);
            lblForula.Name = "lblForula";
            lblForula.Size = new Size(180, 15);
            lblForula.TabIndex = 1;
            lblForula.Text = "Formula : ( Celsius x 9/5) +32 = F";
            // 
            // texN1
            // 
            texN1.BackColor = Color.White;
            texN1.ForeColor = SystemColors.ControlText;
            texN1.Location = new Point(37, 82);
            texN1.Name = "texN1";
            texN1.Size = new Size(100, 23);
            texN1.TabIndex = 2;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Black;
            lblResultado.ForeColor = Color.Lime;
            lblResultado.Location = new Point(282, 85);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(59, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "Resultado";
            // 
            // btnConvertir
            // 
            btnConvertir.BackColor = Color.White;
            btnConvertir.ForeColor = SystemColors.ControlText;
            btnConvertir.Location = new Point(176, 82);
            btnConvertir.Name = "btnConvertir";
            btnConvertir.Size = new Size(75, 23);
            btnConvertir.TabIndex = 4;
            btnConvertir.Text = "Convertir";
            btnConvertir.UseVisualStyleBackColor = false;
            btnConvertir.Click += btnConvertir_Click;
            // 
            // lblTit2
            // 
            lblTit2.AutoSize = true;
            lblTit2.BackColor = SystemColors.Control;
            lblTit2.ForeColor = SystemColors.ControlText;
            lblTit2.Location = new Point(409, 161);
            lblTit2.Name = "lblTit2";
            lblTit2.Size = new Size(159, 15);
            lblTit2.TabIndex = 5;
            lblTit2.Text = "Formula Fahernheit a Celsius";
            // 
            // lblFormula2
            // 
            lblFormula2.AutoSize = true;
            lblFormula2.BackColor = SystemColors.Control;
            lblFormula2.ForeColor = SystemColors.ControlText;
            lblFormula2.Location = new Point(387, 193);
            lblFormula2.Name = "lblFormula2";
            lblFormula2.Size = new Size(204, 15);
            lblFormula2.TabIndex = 6;
            lblFormula2.Text = "Formula : ( Fahernheit - 32 ) x 5/9 = C\r\n";
            // 
            // btnConvertir2
            // 
            btnConvertir2.BackColor = SystemColors.Control;
            btnConvertir2.ForeColor = SystemColors.ControlText;
            btnConvertir2.Location = new Point(493, 243);
            btnConvertir2.Name = "btnConvertir2";
            btnConvertir2.Size = new Size(75, 23);
            btnConvertir2.TabIndex = 7;
            btnConvertir2.Text = "Convertir";
            btnConvertir2.UseVisualStyleBackColor = false;
            btnConvertir2.Click += btnConvertir2_Click;
            // 
            // lblResultado2
            // 
            lblResultado2.AutoSize = true;
            lblResultado2.BackColor = SystemColors.ActiveCaptionText;
            lblResultado2.ForeColor = Color.Lime;
            lblResultado2.Location = new Point(608, 247);
            lblResultado2.Name = "lblResultado2";
            lblResultado2.Size = new Size(59, 15);
            lblResultado2.TabIndex = 8;
            lblResultado2.Text = "Resultado";
            // 
            // texN2
            // 
            texN2.BackColor = SystemColors.Control;
            texN2.ForeColor = SystemColors.ControlText;
            texN2.Location = new Point(351, 244);
            texN2.Name = "texN2";
            texN2.Size = new Size(100, 23);
            texN2.TabIndex = 9;
            // 
            // lblFormula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(texN2);
            Controls.Add(lblResultado2);
            Controls.Add(btnConvertir2);
            Controls.Add(lblFormula2);
            Controls.Add(lblTit2);
            Controls.Add(btnConvertir);
            Controls.Add(lblResultado);
            Controls.Add(texN1);
            Controls.Add(lblForula);
            Controls.Add(lblNombre);
            Name = "lblFormula";
            Text = "Formula";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblForula;
        private TextBox texN1;
        private Label lblResultado;
        private Button btnConvertir;
        private Label lblTit2;
        private Label lblFormula2;
        private Button btnConvertir2;
        private Label lblResultado2;
        private TextBox texN2;
    }
}
