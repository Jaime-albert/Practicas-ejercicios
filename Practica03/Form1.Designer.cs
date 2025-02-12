namespace Practica03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnArea = new Button();
            btnPerimetro = new Button();
            lblRadio = new Label();
            lblPerimetro = new Label();
            lblArea = new Label();
            texRadio = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // btnArea
            // 
            btnArea.Location = new Point(287, 140);
            btnArea.Name = "btnArea";
            btnArea.Size = new Size(75, 23);
            btnArea.TabIndex = 0;
            btnArea.Text = "Area";
            btnArea.UseVisualStyleBackColor = true;
            btnArea.Click += btnArea_Click;
            // 
            // btnPerimetro
            // 
            btnPerimetro.Location = new Point(287, 188);
            btnPerimetro.Name = "btnPerimetro";
            btnPerimetro.Size = new Size(75, 23);
            btnPerimetro.TabIndex = 1;
            btnPerimetro.Text = "Perimetro";
            btnPerimetro.UseVisualStyleBackColor = true;
            btnPerimetro.Click += btnPerimetro_Click;
            // 
            // lblRadio
            // 
            lblRadio.AutoSize = true;
            lblRadio.Location = new Point(74, 56);
            lblRadio.Name = "lblRadio";
            lblRadio.Size = new Size(200, 15);
            lblRadio.TabIndex = 3;
            lblRadio.Text = "Favor de ingresar su radio del circulo";
            // 
            // lblPerimetro
            // 
            lblPerimetro.AutoSize = true;
            lblPerimetro.Location = new Point(407, 188);
            lblPerimetro.Name = "lblPerimetro";
            lblPerimetro.Size = new Size(114, 15);
            lblPerimetro.TabIndex = 4;
            lblPerimetro.Text = "Resultado Perimetro";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(407, 144);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(84, 15);
            lblArea.TabIndex = 5;
            lblArea.Text = "Resultado area";
            // 
            // texRadio
            // 
            texRadio.Location = new Point(114, 102);
            texRadio.Name = "texRadio";
            texRadio.Size = new Size(100, 23);
            texRadio.TabIndex = 6;
            texRadio.TextChanged += texRadio_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(617, 125);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 211);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(46, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 145);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(430, -163);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(375, 234);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 334);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(texRadio);
            Controls.Add(lblArea);
            Controls.Add(lblPerimetro);
            Controls.Add(lblRadio);
            Controls.Add(btnPerimetro);
            Controls.Add(btnArea);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnArea;
        private Button btnPerimetro;
        private Label lblRadio;
        private Label lblPerimetro;
        private Label lblArea;
        private TextBox texRadio;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
