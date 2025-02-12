namespace practica02
{
    public partial class lblFormula : Form
    {
        Decimal vResultado;
        public lblFormula()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            vResultado =  (Convert.ToDecimal(texN1.Text) * 9 / 5 ) + 32;
            lblResultado.Text = vResultado.ToString();

        }

        private void btnConvertir2_Click(object sender, EventArgs e)
        {
            vResultado = (Convert.ToDecimal(texN2.Text) - 32) * 5/9 ;
            lblResultado2.Text = vResultado.ToString();
        }
    }
}
