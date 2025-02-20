namespace Practica5
{
    public partial class Form1 : Form
    {
        double vResultado;//indicador de variable para el resultado
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPromedio_Click(object sender, EventArgs e)
        {     //opercion con los textBox suma y division de promedios 
            vResultado = ( Convert.ToDouble(texp1.Text) + Convert.ToDouble(texp2.Text) + Convert.ToDouble(texp3.Text) ) / 3;
                            //texp1 , textp2 , texp3 , son donde ingresamos valores de los promedios 1 , 2 y 3

            lblPromedio.Text = vResultado.ToString();// mostrar resultado en forma de cadena en el apartado promedio
            // inicio de if anidado
            if (vResultado >= 95)//si es mayor o igual a 95 ejecutara la parte verdadera si no ejecutara la parte falsa
            {

                lblEstatus.Text = "Exento";//parte verdadera

            }
            else
            {
                //parte falsa y inicio de un segindo if
                if (vResultado >= 70)
                {
                    lblEstatus.Text = "Ordinario";//parte verdadera del segundo if 

                }
                else
                {
                    //parte falsa del segundo if y inicio del tercer if
                    if (vResultado >= 50)
                    {

                        lblEstatus.Text = "Extraordinario";//parte verdadera del tercer if

                    }
                    else
                    {

                        lblEstatus.Text = "Especial";//parte falsa del tercer if 

                    }
                }
            }


        }

        private void lblPromedio_Click(object sender, EventArgs e)
        {

        }

        private void lblEstatus_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {   //reinicio de variables a vacio 
            texp1.Text = "";
            texp2.Text = "";
            texp3.Text = "";
            lblEstatus.Text = "";
            lblPromedio.Text = "";
        }
    }
}