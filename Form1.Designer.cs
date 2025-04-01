
namespace ractica04
{
    partial class Formulario1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulario1));
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblLoguin = new Label();
            lblUsuario = new Label();
            lblContraseña = new Label();
            texUsuario = new TextBox();
            texContraseña = new TextBox();
            btnEntrar = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblLoguin
            // 
            lblLoguin.AutoSize = true;
            lblLoguin.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLoguin.Location = new Point(218, 35);
            lblLoguin.Name = "lblLoguin";
            lblLoguin.Size = new Size(75, 25);
            lblLoguin.TabIndex = 0;
            lblLoguin.Text = "Loguin";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(226, 101);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(63, 19);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Sylfaen", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblContraseña.Location = new Point(222, 184);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(88, 19);
            lblContraseña.TabIndex = 2;
            lblContraseña.Text = "Contraseña";
            // 
            // texUsuario
            // 
            texUsuario.Location = new Point(216, 136);
            texUsuario.Name = "texUsuario";
            texUsuario.Size = new Size(100, 23);
            texUsuario.TabIndex = 3;
            texUsuario.TextChanged += texUsuario_TextChanged;
            // 
            // texContraseña
            // 
            texContraseña.Location = new Point(215, 225);
            texContraseña.Name = "texContraseña";
            texContraseña.Size = new Size(100, 23);
            texContraseña.TabIndex = 4;
            // 
            // btnEntrar
            // 
            btnEntrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(226, 265);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(75, 23);
            btnEntrar.TabIndex = 5;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = true;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 209);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 300);
            Controls.Add(btnEntrar);
            Controls.Add(texContraseña);
            Controls.Add(texUsuario);
            Controls.Add(lblContraseña);
            Controls.Add(lblUsuario);
            Controls.Add(lblLoguin);
            Controls.Add(pictureBox1);
            Name = "Formulario1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void texUsuario_TextChanged(object sender, EventArgs e)
        {
            
        }
        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblLoguin;
        private Label lblUsuario;
        private Label lblContraseña;
        private TextBox texUsuario;
        private TextBox texContraseña;
        private Button btnEntrar;
        private PictureBox pictureBox1;
    }
}
