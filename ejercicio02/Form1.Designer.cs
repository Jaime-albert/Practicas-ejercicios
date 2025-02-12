namespace ejercicio02
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
            btnjuntar = new Button();
            lblpalabra = new Label();
            texpal2 = new TextBox();
            texpal1 = new TextBox();
            SuspendLayout();
            // 
            // btnjuntar
            // 
            btnjuntar.Location = new Point(256, 121);
            btnjuntar.Name = "btnjuntar";
            btnjuntar.Size = new Size(75, 23);
            btnjuntar.TabIndex = 0;
            btnjuntar.Text = "Juntar";
            btnjuntar.UseVisualStyleBackColor = true;
            btnjuntar.Click += btnjuntar_Click;
            // 
            // lblpalabra
            // 
            lblpalabra.AutoSize = true;
            lblpalabra.Location = new Point(256, 189);
            lblpalabra.Name = "lblpalabra";
            lblpalabra.Size = new Size(74, 15);
            lblpalabra.TabIndex = 1;
            lblpalabra.Text = "Hola Mundo";
            // 
            // texpal2
            // 
            texpal2.Location = new Point(329, 71);
            texpal2.Name = "texpal2";
            texpal2.Size = new Size(100, 23);
            texpal2.TabIndex = 2;
            // 
            // texpal1
            // 
            texpal1.Location = new Point(158, 71);
            texpal1.Name = "texpal1";
            texpal1.Size = new Size(100, 23);
            texpal1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 250);
            Controls.Add(texpal1);
            Controls.Add(texpal2);
            Controls.Add(lblpalabra);
            Controls.Add(btnjuntar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnjuntar;
        private Label lblpalabra;
        private TextBox texpal2;
        private TextBox texpal1;
    }
}
