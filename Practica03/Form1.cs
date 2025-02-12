namespace Practica03
{
    public partial class Form1 : Form
    {
        Double vResultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnArea_Click(object sender, EventArgs e)
        {
            vResultado = Math.Pow(Convert.ToDouble(texRadio.Text), 2) * Math.PI;
            lblArea.Text = vResultado.ToString();
        }

        private void btnPerimetro_Click(object sender, EventArgs e)
        {
            vResultado = (Convert.ToDouble(texRadio.Text) * 2) * Math.PI;
            lblPerimetro.Text = vResultado.ToString();
        }

        private void texRadio_TextChanged(object sender, EventArgs e)
        {

        }

        private void texRadio_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
