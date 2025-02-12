namespace ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncambiar_Click(object sender, EventArgs e)
        {
            lblcambiante.Text = texcambiador.Text;//ejecucion de cambiador a cambiante
            
            texcambiador.Text = "";//reinicio a blanco 
        }
    }
}
