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
using Microsoft.VisualBasic.ApplicationServices;

namespace ractica04
{
    public partial class Formulario2 : Form
    {
        private int currentIndex = 0;
        private DataTable pokemonTable = new DataTable();//crea una tabla de datos llamada pokemontable
        private string connectionString = (@"server=DESKTOP-DD24R23\SQLEXPRESS ; database = Pokemon; INTEGRATED SECURITY = true");//crea la conecion con la bace de datos
        public Formulario2()
        {
            InitializeComponent();
            CargarDatos();//funcion para cargar los datos guadados
            MostrarPokemon();//funcion de mostrar pokemon
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form3 index = new Form3();//abre el formulario 3
            index.Show();
            this.Hide();
        }

        private void CargarDatos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM pokemon";//seleciona de la tabla pokemon los datos guardados en ella
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);//
                pokemonTable = new DataTable();//todo lo de pokemon table se convertira en una tabla de datos
                adapter.Fill(pokemonTable);//
            }
        }

        private void MostrarPokemon()
        {
            if (pokemonTable.Rows.Count > 0 && currentIndex < pokemonTable.Rows.Count)//inicia los parametros para tomar el valoe del pokemon a elejir
            {
                DataRow row = pokemonTable.Rows[currentIndex];
                lblNumero.Text = row["nDexNa"].ToString();//muestra el numero del pokemon
                lblNP.Text = "Nombre: " + row["Nombre"].ToString();//muestra el numero del pokemon
                lblTipo.Text = "Tipo1: " + row["Tipo1"].ToString();//muestra el tipo1 del pokemon
                lblTipo2.Text = "Tipo2: " + row["Tipo2"].ToString();//muestra el tipo2 del pokemon
                lblDescripcion.Text = "Descripcion: " + row["Descripcion"].ToString();//muestra la descripcion del pokemon
                lblH1.Text = "Habilidad1: " + row["Habilidad1"].ToString();//muestra la habilidad1 del pokemon
                lblH2.Text = "Habilidad2: " + row["Habilidad2"].ToString();//muestra la habilidad2 del pokemon

                // 🔹 Forzar ejecución del evento TextChanged
                lblTipo_TextChanged(lblTipo, EventArgs.Empty);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentIndex < pokemonTable.Rows.Count - 1)//si el numero es menor a uno de la tabla lo muestra 
            {
                currentIndex++;//increment el numero del pokemon
                MostrarPokemon();//muestra el pokemon
                CambiarFotos(1);//avanza la imagen


            }
            else
            {
                MessageBox.Show("No hay más Pokémon.");//mensaje si no hay pokemon
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)//numero en el cual inicia
            {
                currentIndex--;//reduce el numero del pokemon
                MostrarPokemon();//muestra el pokemon
                CambiarFotos(-1); // Retrocede una imagen
            }
            else
            {
                MessageBox.Show("Estás en el primer Pokémon.");//mensaje si no hay un valor menor
            }
        }
        private void CambiarFotos(int cambio)
        {
            try
            {
                // Convertir el texto del label a número
                int numero = int.Parse(lblNumero.Text);

                // Aplicar el cambio (+1 para siguiente, -1 para anterior)
                numero += cambio;

                // Evitar que el número sea menor a 1
                if (numero < 1)
                    numero = 1;

                // Cargar Foto1 con el número actual
                Foto1.Image = Image.FromFile($@"C:\Users\Dell Latitude\Desktop\ractica04\Fotos\{numero}.png");

                // Cargar Foto2 con el número siguiente
                int siguienteNumero = numero + 1;
                Foto2.Image = Image.FromFile($@"C:\Users\Dell Latitude\Desktop\ractica04\Fotos\{siguienteNumero}.png");

                // Actualizar lblNumero con el nuevo número
                lblNumero.Text = numero.ToString();
            }
            catch
            {
                // Si la imagen no existe, volver al inicio
                lblNumero.Text = "1";
                Foto1.Image = Image.FromFile(@"C:\Users\Dell Latitude\Desktop\ractica04\Fotos\1.png");
                Foto2.Image = Image.FromFile(@"C:\Users\Dell Latitude\Desktop\ractica04\Fotos\2.png");
            }
        }

        private void lblTipo_Click(object sender, EventArgs e)
        {

        }

        private void lblTipo_TextChanged(object sender, EventArgs e)
        {
            // Eliminar "Tipo1: " para obtener solo el tipo
            string tipo = lblTipo.Text.Replace("Tipo1: ", "").Trim().ToLower();

            // Definir los colores según el tipo de Pokémon
            Dictionary<string, Color> coloresTipos = new Dictionary<string, Color>
    {
        { "fuego", Color.Red },
        { "agua", Color.Blue },
        { "planta", Color.Green },
        { "electrico", Color.Yellow },
        { "hielo", Color.LightBlue },
        { "lucha", Color.Orange },
        { "veneno", Color.Purple },
        { "tierra", Color.SaddleBrown },
        { "volador", Color.SkyBlue },
        { "psíquico", Color.MediumOrchid },
        { "bicho", Color.Olive },
        { "roca", Color.DarkGoldenrod },
        { "fantasma", Color.DarkSlateBlue },
        { "dragón", Color.Indigo },
        { "siniestro", Color.Black },
        { "acero", Color.Gray },
        { "hada", Color.HotPink },
        { "normal", Color.DarkGray }
    };

            // Verificar si el tipo existe en el diccionario y cambiar el color
            if (coloresTipos.ContainsKey(tipo))
            {
                lblTipo.ForeColor = coloresTipos[tipo];
            }
            else
            {
                lblTipo.ForeColor = Color.Black; // Color por defecto si no es un tipo válido
            }
        }

    private void lblTipo2_TextChanged(object sender, EventArgs e)
        {
            // Eliminar "Tipo2: " para obtener solo el tipo
            string tipo2 = lblTipo2.Text.Replace("Tipo2: ", "").Trim().ToLower();

            // Definir los colores según el tipo de Pokémon
            Dictionary<string, Color> coloresTipos2 = new Dictionary<string, Color>
    {
        { "fuego", Color.Red },
        { "agua", Color.Blue },
        { "planta", Color.Green },
        { "electrico", Color.Yellow },
        { "hielo", Color.LightBlue },
        { "lucha", Color.Orange },
        { "veneno", Color.Purple },
        { "tierra", Color.SaddleBrown },
        { "volador", Color.SkyBlue },
        { "psíquico", Color.MediumOrchid },
        { "bicho", Color.Olive },
        { "roca", Color.DarkGoldenrod },
        { "fantasma", Color.DarkSlateBlue },
        { "dragón", Color.Indigo },
        { "siniestro", Color.Black },
        { "acero", Color.Gray },
        { "hada", Color.HotPink },
        { "normal", Color.DarkGray }
    };

            // Verificar si el tipo existe en el diccionario y cambiar el color
            if (coloresTipos2.ContainsKey(tipo2))
            {
                lblTipo2.ForeColor = coloresTipos2[tipo2];
            }
            else
            {
                lblTipo2.ForeColor = Color.Black; // Color por defecto si no es un tipo válido
            }
        }
    }
}   
