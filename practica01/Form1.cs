namespace practica01
{
    public partial class Form1 : Form
    {
        int vResultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(texN1.Text) + Convert.ToInt32(texN2.Text);
            lblResultado.Text = vResultado.ToString();
            lblcambio.Text = "+";
        }

        private void texN1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(texN1.Text) - Convert.ToInt32(texN2.Text);
            lblResultado.Text = vResultado.ToString();
            lblcambio.Text = "-";
        }

        private void btnMultip_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(texN1.Text) * Convert.ToInt32(texN2.Text);
            lblResultado.Text = vResultado.ToString();
            lblcambio.Text = "*";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(texN1.Text) / Convert.ToInt32(texN2.Text);
            lblResultado.Text = vResultado.ToString();
            lblcambio.Text = "/";
        }
    }
}
