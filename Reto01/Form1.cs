namespace Reto01
{
    public partial class Form1 : Form
    {   //creacion de variables 
        string vSeleccion;//variable con la cual se mostra la selecion de pelicula
        //variables para incerementos en porsentaje 
        double vincrementoI15, vincrementoI25, vincrementoI35;
        double vincrementoT10, vincrementoT20, vincrementoT30;
        double vincrementoR17, vincrementoR37;

        int vIndice;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            //ifs para poner las pelis dependiendo de cual categoria se eligio 
            if (rbInfantil.Checked == true)//infantil
            {   //peliculas a eleccion 
                cbboxPeliculas.Items.Add("Rampuncel");
                cbboxPeliculas.Items.Add("El rey leon");

            }

            if (rbRomance.Checked == true)//romance
            {   //peliculas a eleccion 
                cbboxPeliculas.Items.Add("Amanecer");
                cbboxPeliculas.Items.Add("Sol caido");

            }


            if (rbTerror.Checked == true)//terror
            {   //peliculas a eleccion
                cbboxPeliculas.Items.Add("It");
                cbboxPeliculas.Items.Add("El payaso asesino");

            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //acciones a realizar al dar click agregar
        private void btnAgregar_Click(object sender, EventArgs e)
        {    //convercion de texto a lineal
            vSeleccion = Convert.ToString(cbboxPeliculas.Text);

            int vIndice = dataGridView1.Rows.Add();//marcador de indice 

            dataGridView1.Rows[vIndice].Cells[0].Value = texNombre.Text;//indicador de posicion primaria 
            dataGridView1.Rows[vIndice].Cells[1].Value = vSeleccion;//secundaria
            dataGridView1.Rows[vIndice].Cells[2].Value = Fecha.Text;//terciaria
            dataGridView1.Rows[vIndice].Cells[3].Value = texPrecio.Text;//cuarta
            dataGridView1.Rows[vIndice].Cells[4].Value = dtpEntrega.Text;//quinta

            //if indicacion de porsentaje segun la seleccion de categoria
            if (rbInfantil.Checked == true)//infantil
            {   //operacion para dar porsentaje
                vincrementoI15 = (15 / Convert.ToDouble(texPrecio.Text)) * 100;
                vincrementoI25 = (25 / Convert.ToDouble(texPrecio.Text)) * 100;
                vincrementoI35 = (35 / Convert.ToDouble(texPrecio.Text)) * 100;

                dataGridView1.Rows[vIndice].Cells[5].Value = vincrementoI15;//sexta
                dataGridView1.Rows[vIndice].Cells[6].Value = vincrementoI25;//septima
                dataGridView1.Rows[vIndice].Cells[7].Value = vincrementoI35;//octava
            }

            if (rbRomance.Checked == true)//Romance
            {
                vincrementoR17 = (17 / Convert.ToDouble(texPrecio.Text)) * 100;
                vincrementoR37 = (37 / Convert.ToDouble(texPrecio.Text)) * 100;

                dataGridView1.Rows[vIndice].Cells[5].Value = vincrementoR17;
                dataGridView1.Rows[vIndice].Cells[6].Value = vincrementoR17;
                dataGridView1.Rows[vIndice].Cells[7].Value = vincrementoR37;

            }

            if (rbTerror.Checked == true)//Terror
            {
                vincrementoT10 = (10 / Convert.ToDouble(texPrecio.Text)) * 100;
                vincrementoT20 = (20 / Convert.ToDouble(texPrecio.Text)) * 100;
                vincrementoT30 = (30 / Convert.ToDouble(texPrecio.Text)) * 100;

                dataGridView1.Rows[vIndice].Cells[5].Value = vincrementoT10;
                dataGridView1.Rows[vIndice].Cells[6].Value = vincrementoT20;
                dataGridView1.Rows[vIndice].Cells[7].Value = vincrementoT30;

            }
        }

        private void lblCalculo_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {    //condicion para eliminar datos guardados en la tabla 
            if(vIndice != 1)
            {
                dataGridView1.Rows.RemoveAt(vIndice);//borrar los indices
            }
            else
            {
                MessageBox.Show("No se selecciono bien");//mensaje por si no se seleciono nada o no hay nada
            }
        }
    }
}
