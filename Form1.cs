using System.ComponentModel.Design.Serialization;
using System.Data.SqlClient;


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

            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-DD24R23\SQLEXPRESS ; database = milogin; INTEGRATED SECURITY = true");
            conexion.Open();
            SqlCommand cdm = new SqlCommand("SELECT Usuario, Contrasena FROM Usuarios WHERE Usuario = @vUsuario AND Contrasena = @vContrasena ", conexion);
            cdm.Parameters.AddWithValue("@vUsuario", texUsuario.Text.Trim());
            cdm.Parameters.AddWithValue("@vContrasena", texContraseña.Text.Trim());

            SqlDataReader lector = cdm.ExecuteReader();

            if (lector.Read())
            {
                conexion.Close();
                MessageBox.Show("Login Exitoso");
                Formulario2 index = new Formulario2();
                index.Show();
                this.Hide();
            }else
            {
                MessageBox.Show("error no se encontraron los datos");
            }
        }
    }
}
