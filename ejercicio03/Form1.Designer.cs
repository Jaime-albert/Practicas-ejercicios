namespace ejercicio03
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
            texnumero1 = new TextBox();
            texnumero2 = new TextBox();
            btnCalcular = new Button();
            rbSuma = new RadioButton();
            label1 = new Label();
            rbResta = new RadioButton();
            rbDiv = new RadioButton();
            rbMulti = new RadioButton();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // texnumero1
            // 
            texnumero1.Location = new Point(26, 39);
            texnumero1.Name = "texnumero1";
            texnumero1.Size = new Size(100, 23);
            texnumero1.TabIndex = 0;
            // 
            // texnumero2
            // 
            texnumero2.Location = new Point(84, 68);
            texnumero2.Name = "texnumero2";
            texnumero2.Size = new Size(100, 23);
            texnumero2.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Font = new Font("Sylfaen", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCalcular.Location = new Point(26, 114);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // rbSuma
            // 
            rbSuma.AutoSize = true;
            rbSuma.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            rbSuma.Location = new Point(208, 39);
            rbSuma.Name = "rbSuma";
            rbSuma.Size = new Size(68, 26);
            rbSuma.TabIndex = 3;
            rbSuma.TabStop = true;
            rbSuma.Text = "Suma";
            rbSuma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 22);
            label1.TabIndex = 4;
            label1.Text = "Ingrese valores numericos ";
            // 
            // rbResta
            // 
            rbResta.AutoSize = true;
            rbResta.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            rbResta.Location = new Point(208, 64);
            rbResta.Name = "rbResta";
            rbResta.Size = new Size(68, 26);
            rbResta.TabIndex = 5;
            rbResta.TabStop = true;
            rbResta.Text = "Resta";
            rbResta.UseVisualStyleBackColor = true;
            // 
            // rbDiv
            // 
            rbDiv.AutoSize = true;
            rbDiv.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            rbDiv.Location = new Point(208, 114);
            rbDiv.Name = "rbDiv";
            rbDiv.Size = new Size(94, 26);
            rbDiv.TabIndex = 6;
            rbDiv.TabStop = true;
            rbDiv.Text = "Divicion";
            rbDiv.UseVisualStyleBackColor = true;
            // 
            // rbMulti
            // 
            rbMulti.AutoSize = true;
            rbMulti.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic);
            rbMulti.Location = new Point(208, 89);
            rbMulti.Name = "rbMulti";
            rbMulti.Size = new Size(140, 26);
            rbMulti.TabIndex = 7;
            rbMulti.TabStop = true;
            rbMulti.Text = "Multiplicacion";
            rbMulti.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(101, 155);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(83, 22);
            lblResultado.TabIndex = 8;
            lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(415, 219);
            Controls.Add(lblResultado);
            Controls.Add(rbMulti);
            Controls.Add(rbDiv);
            Controls.Add(rbResta);
            Controls.Add(label1);
            Controls.Add(rbSuma);
            Controls.Add(btnCalcular);
            Controls.Add(texnumero2);
            Controls.Add(texnumero1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox texnumero1;
        private TextBox texnumero2;
        private Button btnCalcular;
        private RadioButton rbSuma;
        private Label label1;
        private RadioButton rbResta;
        private RadioButton rbDiv;
        private RadioButton rbMulti;
        private Label lblResultado;
    }
}
