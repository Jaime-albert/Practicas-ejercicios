namespace ejercicio01
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
            btncambiar = new Button();
            lblcambiante = new Label();
            texcambiador = new TextBox();
            SuspendLayout();
            // 
            // btncambiar
            // 
            btncambiar.Location = new Point(154, 160);
            btncambiar.Name = "btncambiar";
            btncambiar.Size = new Size(75, 23);
            btncambiar.TabIndex = 0;
            btncambiar.Text = "Cambiar";
            btncambiar.UseVisualStyleBackColor = true;
            btncambiar.Click += btncambiar_Click;
            // 
            // lblcambiante
            // 
            lblcambiante.AutoSize = true;
            lblcambiante.Location = new Point(155, 43);
            lblcambiante.Name = "lblcambiante";
            lblcambiante.Size = new Size(74, 15);
            lblcambiante.TabIndex = 1;
            lblcambiante.Text = "Hola Mundo";
            // 
            // texcambiador
            // 
            texcambiador.Location = new Point(141, 96);
            texcambiador.Name = "texcambiador";
            texcambiador.Size = new Size(100, 23);
            texcambiador.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 224);
            Controls.Add(texcambiador);
            Controls.Add(lblcambiante);
            Controls.Add(btncambiar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncambiar;
        private Label lblcambiante;
        private TextBox texcambiador;
    }
}
