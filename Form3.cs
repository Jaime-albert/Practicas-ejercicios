using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;

namespace ractica04
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection(@"server=DESKTOP-DD24R23\SQLEXPRESS ; database = milogin; INTEGRATED SECURITY = true");
            conexion.Open();//Conexion abierta  //coneccion con el servidor a travez de sql server 
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuarios (IDusuario, Usuario, Contrasena) VALUES ('" + texID.Text.Trim() + "','" + texUsuario.Text.Trim() + "', '" + texContraeña.Text.Trim() + "')", conexion);
            cmd.ExecuteNonQuery();//insert into es una asignacion de valores a una tabla ocupando los espacios puestos entre parentecis "()"
            conexion.Close();//cierre de conecion


            //valuador si las dos contrasenas son iguales saldra un mensaje de valida
            if (texContraeña == texCcontraseña)
            {
                MessageBox.Show("Detalles incorrectos", "error", MessageBoxButtons.OK);//mensaje de fallo
            }
            else
            {
                MessageBox.Show("Asignacion completa", "nuevo registro", MessageBoxButtons.OK);//mensaje de entrada

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("volviendo");//mensaje indicador de accion que se ejecuta en este caso volver
            Formulario2 index = new Formulario2();//abre el formulario 2
            index.Show();//mostrarlo
            this.Hide();//cerrar el anterior 
        }
    }
}
