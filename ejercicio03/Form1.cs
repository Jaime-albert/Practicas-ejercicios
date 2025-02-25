namespace ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {   //creacion de variables
            double vNum1 = 0.0;
            double vNum2 = 0.0;
            double vResultado = 0.0;
            //conversion de texto a double
            vNum1 = Convert.ToDouble(texnumero1.Text);
            vNum2 = Convert.ToDouble(texnumero2.Text);
            //if para resultado
            if(rbSuma.Checked == true)
            {   //suma
                vResultado = vNum1 + vNum2;
            }

            if(rbResta.Checked == true)
            {   //resta
                vResultado = vNum1 - vNum2;
            }

            if(rbMulti.Checked == true)
            {   //multiplicacion
                vResultado = vNum1 * vNum2;
            }
            
            if(rbDiv.Checked == true)
            {   //divicion
                vResultado = vNum1 / vNum2;
            }
            //mostrar el resultado segun la eleccion
            lblResultado.Text = vResultado.ToString();
        }
    }
}
