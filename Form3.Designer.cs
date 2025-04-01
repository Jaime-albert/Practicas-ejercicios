namespace ractica04
{
    partial class Form3
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
            lblReg = new Label();
            lblUsuario = new Label();
            label2 = new Label();
            lblConfirmar = new Label();
            texUsuario = new TextBox();
            texContraeña = new TextBox();
            texCcontraseña = new TextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lblID = new Label();
            texID = new TextBox();
            SuspendLayout();
            // 
            // lblReg
            // 
            lblReg.AutoSize = true;
            lblReg.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblReg.Location = new Point(60, 9);
            lblReg.Name = "lblReg";
            lblReg.Size = new Size(134, 17);
            lblReg.TabIndex = 0;
            lblReg.Text = "Reguistro De Usuario";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblUsuario.Location = new Point(225, 48);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(53, 17);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 130);
            label2.Name = "label2";
            label2.Size = new Size(75, 17);
            label2.TabIndex = 2;
            label2.Text = "Contraseña";
            // 
            // lblConfirmar
            // 
            lblConfirmar.AutoSize = true;
            lblConfirmar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblConfirmar.Location = new Point(225, 130);
            lblConfirmar.Name = "lblConfirmar";
            lblConfirmar.Size = new Size(174, 17);
            lblConfirmar.TabIndex = 3;
            lblConfirmar.Text = "Confirmacion de contraseña";
            // 
            // texUsuario
            // 
            texUsuario.Location = new Point(225, 68);
            texUsuario.Name = "texUsuario";
            texUsuario.Size = new Size(188, 23);
            texUsuario.TabIndex = 4;
            // 
            // texContraeña
            // 
            texContraeña.Location = new Point(12, 156);
            texContraeña.Name = "texContraeña";
            texContraeña.Size = new Size(174, 23);
            texContraeña.TabIndex = 5;
            // 
            // texCcontraseña
            // 
            texCcontraseña.Location = new Point(225, 156);
            texCcontraseña.Name = "texCcontraseña";
            texCcontraseña.Size = new Size(188, 23);
            texCcontraseña.TabIndex = 6;
            // 
            // btnAceptar
            // 
            btnAceptar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAceptar.Location = new Point(12, 210);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(100, 23);
            btnAceptar.TabIndex = 7;
            btnAceptar.Text = "Confirmar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(178, 210);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 23);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblID.Location = new Point(12, 48);
            lblID.Name = "lblID";
            lblID.Size = new Size(22, 17);
            lblID.TabIndex = 9;
            lblID.Text = "ID";
            // 
            // texID
            // 
            texID.Location = new Point(12, 68);
            texID.Name = "texID";
            texID.Size = new Size(174, 23);
            texID.TabIndex = 10;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(425, 273);
            Controls.Add(texID);
            Controls.Add(lblID);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(texCcontraseña);
            Controls.Add(texContraeña);
            Controls.Add(texUsuario);
            Controls.Add(lblConfirmar);
            Controls.Add(label2);
            Controls.Add(lblUsuario);
            Controls.Add(lblReg);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReg;
        private Label lblUsuario;
        private Label label2;
        private Label lblConfirmar;
        private TextBox texUsuario;
        private TextBox texContraeña;
        private TextBox texCcontraseña;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label lblID;
        private TextBox texID;
    }
}