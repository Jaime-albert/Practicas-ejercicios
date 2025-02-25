namespace ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double vNum1 = 0.0;
            double vNum2 = 0.0;
            double vResultado = 0.0;

            vNum1 = Convert.ToDouble(texnumero1.Text);
            vNum2 = Convert.ToDouble(texnumero2.Text);

            if(rbSuma.Checked == true)
            {
                vResultado = vNum1 + vNum2;
            }

            if(rbResta.Checked == true)
            {
                vResultado = vNum1 - vNum2;
            }

            if(rbMulti.Checked == true)
            {
                vResultado = vNum1 * vNum2;
            }
            
            if(rbDiv.Checked == true)
            {
                vResultado = vNum1 / vNum2;
            }

            lblResultado.Text = vResultado.ToString();
        }
    }
}
