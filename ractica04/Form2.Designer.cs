namespace ractica04
{
    partial class Formulario2
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
            lblInicio = new Label();
            SuspendLayout();
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Font = new Font("Stencil", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInicio.Location = new Point(129, 21);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(501, 342);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "DEAT \r\n\r\n          LIFE";
            // 
            // Formulario2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInicio);
            Name = "Formulario2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblInicio;
    }
}