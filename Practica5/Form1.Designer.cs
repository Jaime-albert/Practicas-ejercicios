namespace Practica5
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
            lblTercerPar = new Label();
            lblSegundopar = new Label();
            lblPrimerpar = new Label();
            lblPromedio = new Label();
            texp1 = new TextBox();
            texp3 = new TextBox();
            texp2 = new TextBox();
            btnPromedio = new Button();
            lblEstatus = new Label();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // lblTercerPar
            // 
            lblTercerPar.AutoSize = true;
            lblTercerPar.BackColor = Color.Khaki;
            lblTercerPar.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblTercerPar.Location = new Point(12, 180);
            lblTercerPar.Name = "lblTercerPar";
            lblTercerPar.Size = new Size(117, 22);
            lblTercerPar.TabIndex = 0;
            lblTercerPar.Text = "Tercer Parcial";
            // 
            // lblSegundopar
            // 
            lblSegundopar.AutoSize = true;
            lblSegundopar.BackColor = Color.LemonChiffon;
            lblSegundopar.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSegundopar.Location = new Point(12, 91);
            lblSegundopar.Name = "lblSegundopar";
            lblSegundopar.Size = new Size(130, 22);
            lblSegundopar.TabIndex = 1;
            lblSegundopar.Text = "Segundo Parcial";
            // 
            // lblPrimerpar
            // 
            lblPrimerpar.AutoSize = true;
            lblPrimerpar.BackColor = Color.Khaki;
            lblPrimerpar.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPrimerpar.Location = new Point(12, 9);
            lblPrimerpar.Name = "lblPrimerpar";
            lblPrimerpar.Size = new Size(120, 22);
            lblPrimerpar.TabIndex = 2;
            lblPrimerpar.Text = "Primer Parcial";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.BackColor = Color.Beige;
            lblPromedio.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPromedio.Location = new Point(299, 107);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(82, 22);
            lblPromedio.TabIndex = 3;
            lblPromedio.Text = "Promedio";
            lblPromedio.Click += lblPromedio_Click;
            // 
            // texp1
            // 
            texp1.Location = new Point(12, 49);
            texp1.Name = "texp1";
            texp1.Size = new Size(100, 23);
            texp1.TabIndex = 4;
            // 
            // texp3
            // 
            texp3.Location = new Point(12, 217);
            texp3.Name = "texp3";
            texp3.Size = new Size(100, 23);
            texp3.TabIndex = 5;
            // 
            // texp2
            // 
            texp2.Location = new Point(12, 125);
            texp2.Name = "texp2";
            texp2.Size = new Size(100, 23);
            texp2.TabIndex = 6;
            // 
            // btnPromedio
            // 
            btnPromedio.BackColor = Color.Khaki;
            btnPromedio.Location = new Point(171, 108);
            btnPromedio.Name = "btnPromedio";
            btnPromedio.Size = new Size(75, 23);
            btnPromedio.TabIndex = 7;
            btnPromedio.Text = "Promedio";
            btnPromedio.UseVisualStyleBackColor = false;
            btnPromedio.Click += btnPromedio_Click;
            // 
            // lblEstatus
            // 
            lblEstatus.AutoSize = true;
            lblEstatus.BackColor = Color.Beige;
            lblEstatus.Font = new Font("Sylfaen", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblEstatus.Location = new Point(299, 49);
            lblEstatus.Name = "lblEstatus";
            lblEstatus.Size = new Size(63, 22);
            lblEstatus.TabIndex = 8;
            lblEstatus.Text = "Estatus";
            lblEstatus.Click += lblEstatus_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.Khaki;
            btnBorrar.Location = new Point(299, 193);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(75, 23);
            btnBorrar.TabIndex = 9;
            btnBorrar.Text = "Limpiar";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(550, 279);
            Controls.Add(btnBorrar);
            Controls.Add(lblEstatus);
            Controls.Add(btnPromedio);
            Controls.Add(texp2);
            Controls.Add(texp3);
            Controls.Add(texp1);
            Controls.Add(lblPromedio);
            Controls.Add(lblPrimerpar);
            Controls.Add(lblSegundopar);
            Controls.Add(lblTercerPar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTercerPar;
        private Label lblSegundopar;
        private Label lblPrimerpar;
        private Label lblPromedio;
        private TextBox texp1;
        private TextBox texp3;
        private TextBox texp2;
        private Button btnPromedio;
        private Label lblEstatus;
        private Button btnBorrar;
    }
}
