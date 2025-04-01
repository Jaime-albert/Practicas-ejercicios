using System;
using System.Collections.Generic;
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
    public partial class Form4 : Form
    {
        private int currentIndex = 0;
        private DataTable pokemonTable = new DataTable();
        private string connectionString = (@"server=DESKTOP-DD24R23\SQLEXPRESS ; database = Pokemon; INTEGRATED SECURITY = true");
        public Form4()
        {
            InitializeComponent();
            CargarDatos();
            MostrarPokemon();
            CambiarFoto();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Form3 index = new Form3();
            index.Show();
            this.Hide();
        }

        private void CargarDatos()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM pokemon";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                pokemonTable = new DataTable();
                adapter.Fill(pokemonTable);
            }
        }

        private void MostrarPokemon()
        {
            if (pokemonTable.Rows.Count > 0 && currentIndex < pokemonTable.Rows.Count)
            {
                DataRow row = pokemonTable.Rows[currentIndex];
                lblNumero.Text = row["nDexNa"].ToString();
                lblNP.Text = "Nombre: " + row["Nombre"].ToString();
                lblTipo.Text = "Tipo1: " + row["Tipo1"].ToString();
                lblTipo2.Text = "Tipo2: " + row["Tipo2"].ToString();
                lblDescripcion.Text = "Descripcion: " + row["Descripcion"].ToString();
                lblH1.Text = "Habilidad1: " + row["Habilidad1"].ToString();
                lblH2.Text = "Habilidad2: " + row["Habilidad2"].ToString();

                // 🔹 Forzar ejecución del evento TextChanged
                lblTipo_TextChanged(lblTipo, EventArgs.Empty);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (currentIndex < pokemonTable.Rows.Count - 1)
            {
                currentIndex++;
                MostrarPokemon();
                CambiarFoto();
                CambiarFoto2();

            }
            else
            {
                MessageBox.Show("No hay más Pokémon.");
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (currentIndex > 0)
            {
                currentIndex--;
                MostrarPokemon();
                CambiarFoto();
                CambiarFoto2();
            }
            else
            {
                MessageBox.Show("Estás en el primer Pokémon.");
            }
        }
        private void CambiarFoto()
        {
            try
            {
                Foto1.Image = Image.FromFile(@"C:\Users\Dell Latitude\Desktop\ractica04\Fotos\" + lblNumero.Text + ".png");
            }
            catch
            {
                Foto1.Image = null;
            }
        }

        private void CambiarFoto2()
        {
            try
            {
                Foto2.Image = Image.FromFile(@"C:\Users\Dell Latitude\Desktop\ractica04\Fotos\" + lblNumero.Text + 1 + ".png");
            }
            catch
            {
                Foto2.Image = null;
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
