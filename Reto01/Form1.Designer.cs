namespace Reto01
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
            lblTitulo = new Label();
            pictureBox1 = new PictureBox();
            lblTerror = new Label();
            lblRomance = new Label();
            rbInfantil = new RadioButton();
            rbTerror = new RadioButton();
            rbRomance = new RadioButton();
            btnMostrar = new Button();
            cbboxPeliculas = new ComboBox();
            lblCalculo = new Label();
            texNombre = new TextBox();
            Fecha = new DateTimePicker();
            lblNombCom = new Label();
            label3 = new Label();
            texPrecio = new TextBox();
            lblPrecio = new Label();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnEliminar = new Button();
            lblInfantil = new Label();
            dtpEntrega = new DateTimePicker();
            lblFechaEntrega = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = SystemColors.ActiveCaptionText;
            lblTitulo.Font = new Font("Tw Cen MT", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = Color.DodgerBlue;
            lblTitulo.Location = new Point(12, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 39);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "PELIMUNDO";
            lblTitulo.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1038, 79);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblTerror
            // 
            lblTerror.BackColor = Color.Black;
            lblTerror.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTerror.ForeColor = SystemColors.ButtonHighlight;
            lblTerror.Image = (Image)resources.GetObject("lblTerror.Image");
            lblTerror.ImageAlign = ContentAlignment.TopCenter;
            lblTerror.Location = new Point(531, 142);
            lblTerror.Name = "lblTerror";
            lblTerror.Size = new Size(274, 55);
            lblTerror.TabIndex = 3;
            lblTerror.Text = "TERROR ";
            // 
            // lblRomance
            // 
            lblRomance.BackColor = Color.FromArgb(255, 192, 192);
            lblRomance.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRomance.Image = (Image)resources.GetObject("lblRomance.Image");
            lblRomance.Location = new Point(743, 211);
            lblRomance.Name = "lblRomance";
            lblRomance.Size = new Size(269, 55);
            lblRomance.TabIndex = 4;
            lblRomance.Text = "ROMANCE";
            // 
            // rbInfantil
            // 
            rbInfantil.AutoSize = true;
            rbInfantil.Font = new Font("Segoe UI", 9F);
            rbInfantil.Location = new Point(21, 178);
            rbInfantil.Name = "rbInfantil";
            rbInfantil.Size = new Size(62, 19);
            rbInfantil.TabIndex = 5;
            rbInfantil.TabStop = true;
            rbInfantil.Text = "Infantil";
            rbInfantil.UseVisualStyleBackColor = true;
            // 
            // rbTerror
            // 
            rbTerror.AutoSize = true;
            rbTerror.Font = new Font("Segoe UI", 9F);
            rbTerror.Location = new Point(101, 178);
            rbTerror.Name = "rbTerror";
            rbTerror.Size = new Size(55, 19);
            rbTerror.TabIndex = 6;
            rbTerror.TabStop = true;
            rbTerror.Text = "Terror";
            rbTerror.UseVisualStyleBackColor = true;
            // 
            // rbRomance
            // 
            rbRomance.AutoSize = true;
            rbRomance.Font = new Font("Segoe UI", 9F);
            rbRomance.Location = new Point(172, 178);
            rbRomance.Name = "rbRomance";
            rbRomance.Size = new Size(75, 19);
            rbRomance.TabIndex = 7;
            rbRomance.TabStop = true;
            rbRomance.Text = "Romance";
            rbRomance.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 9F);
            btnMostrar.Location = new Point(21, 211);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 8;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // cbboxPeliculas
            // 
            cbboxPeliculas.Font = new Font("Segoe UI", 9F);
            cbboxPeliculas.FormattingEnabled = true;
            cbboxPeliculas.Location = new Point(126, 211);
            cbboxPeliculas.Name = "cbboxPeliculas";
            cbboxPeliculas.Size = new Size(121, 23);
            cbboxPeliculas.TabIndex = 9;
            // 
            // lblCalculo
            // 
            lblCalculo.AutoSize = true;
            lblCalculo.Font = new Font("Segoe UI", 9F);
            lblCalculo.Location = new Point(12, 75);
            lblCalculo.Name = "lblCalculo";
            lblCalculo.Size = new Size(102, 15);
            lblCalculo.TabIndex = 10;
            lblCalculo.Text = "Renta de Peliculas";
            // 
            // texNombre
            // 
            texNombre.Font = new Font("Segoe UI", 9F);
            texNombre.Location = new Point(21, 142);
            texNombre.Name = "texNombre";
            texNombre.Size = new Size(226, 23);
            texNombre.TabIndex = 11;
            // 
            // Fecha
            // 
            Fecha.Font = new Font("Segoe UI", 9F);
            Fecha.Location = new Point(21, 270);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(226, 23);
            Fecha.TabIndex = 12;
            // 
            // lblNombCom
            // 
            lblNombCom.AutoSize = true;
            lblNombCom.Font = new Font("Segoe UI", 9F);
            lblNombCom.Location = new Point(62, 115);
            lblNombCom.Name = "lblNombCom";
            lblNombCom.Size = new Size(115, 15);
            lblNombCom.TabIndex = 14;
            lblNombCom.Text = "Nombre Comprador";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(103, 251);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 16;
            label3.Text = "Fecha";
            // 
            // texPrecio
            // 
            texPrecio.Font = new Font("Segoe UI", 9F);
            texPrecio.Location = new Point(21, 350);
            texPrecio.Name = "texPrecio";
            texPrecio.Size = new Size(226, 23);
            texPrecio.TabIndex = 18;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Font = new Font("Segoe UI", 9F);
            lblPrecio.Location = new Point(103, 322);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(40, 15);
            lblPrecio.TabIndex = 19;
            lblPrecio.Text = "Precio";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column8, Column5, Column6, Column7 });
            dataGridView1.Location = new Point(276, 298);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(736, 150);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Pelicula";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Fecha";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Precio";
            Column4.Name = "Column4";
            // 
            // Column8
            // 
            Column8.HeaderText = "Dia de entrega";
            Column8.Name = "Column8";
            // 
            // Column5
            // 
            Column5.HeaderText = "Incremento 1 a 5 dias $";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "incremento 6 a 9 dias $ ";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Incremento  10 a mas dias $";
            Column7.Name = "Column7";
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 9F);
            btnAgregar.Location = new Point(21, 406);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 21;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 9F);
            btnEliminar.Location = new Point(172, 406);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // lblInfantil
            // 
            lblInfantil.BackColor = Color.FromArgb(255, 192, 192);
            lblInfantil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfantil.Image = (Image)resources.GetObject("lblInfantil.Image");
            lblInfantil.Location = new Point(319, 83);
            lblInfantil.Name = "lblInfantil";
            lblInfantil.Size = new Size(279, 47);
            lblInfantil.TabIndex = 23;
            lblInfantil.Text = "INFANTIL";
            // 
            // dtpEntrega
            // 
            dtpEntrega.Location = new Point(276, 269);
            dtpEntrega.Name = "dtpEntrega";
            dtpEntrega.Size = new Size(226, 23);
            dtpEntrega.TabIndex = 24;
            // 
            // lblFechaEntrega
            // 
            lblFechaEntrega.AutoSize = true;
            lblFechaEntrega.Location = new Point(346, 251);
            lblFechaEntrega.Name = "lblFechaEntrega";
            lblFechaEntrega.Size = new Size(98, 15);
            lblFechaEntrega.TabIndex = 25;
            lblFechaEntrega.Text = "Fecha De Enterga";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScrollMargin = new Size(0, 1000);
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(1024, 550);
            Controls.Add(lblFechaEntrega);
            Controls.Add(dtpEntrega);
            Controls.Add(lblInfantil);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(dataGridView1);
            Controls.Add(lblPrecio);
            Controls.Add(texPrecio);
            Controls.Add(label3);
            Controls.Add(lblNombCom);
            Controls.Add(Fecha);
            Controls.Add(texNombre);
            Controls.Add(lblCalculo);
            Controls.Add(cbboxPeliculas);
            Controls.Add(btnMostrar);
            Controls.Add(rbRomance);
            Controls.Add(rbTerror);
            Controls.Add(rbInfantil);
            Controls.Add(lblRomance);
            Controls.Add(lblTerror);
            Controls.Add(lblTitulo);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private PictureBox pictureBox1;
        private Label lblTerror;
        private Label lblRomance;
        private RadioButton rbInfantil;
        private RadioButton rbTerror;
        private RadioButton rbRomance;
        private Button btnMostrar;
        private ComboBox cbboxPeliculas;
        private LinkLabel linklblInfantil;
        private Label lblCalculo;
        private TextBox texNombre;
        private DateTimePicker Fecha;
        private Label lblNombCom;
        private Label label3;
        private TextBox texPrecio;
        private Label lblPrecio;
        private DataGridView dataGridView1;
        private Button btnAgregar;
        private Button btnEliminar;
        private Label lblInfantil;
        private DateTimePicker dtpEntrega;
        private Label lblFechaEntrega;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
    }
}
