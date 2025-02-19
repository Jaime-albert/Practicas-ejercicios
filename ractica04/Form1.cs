namespace ractica04
{
    public partial class Formulario1 : Form
    {
        public Formulario1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if(texUsuario.Text == "Admin" && texContraseña.Text == "Admin")
            {

                Formulario2 formulario2 = new Formulario2();
                formulario2.Show();
                this.Hide();

            }else
            {

                MessageBox.Show("Carga Fallida ");

            }
        }
    }
}
