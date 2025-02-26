using System.Windows.Forms;

namespace examen01
{
    public partial class Form1 : Form
    {
        double vDia;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResultado_Click(object sender, EventArgs e)
        {

            vDia = Convert.ToDouble(texDiaN.Text);

            if (rbEnero.Checked == true)
            {
                if (vDia <= 19)
                {
                    //redirige a el formulario 2
                    Fr2 fr2 = new Fr2();
                    //muestra el segundo formulario
                    fr2.Show();
                }
                else
                {
                    //redirige a el formulario 3
                    fr3 fr3 = new fr3();
                    //muestra el segundo formulario
                    fr3.Show();
                }
            }


            if (rbFebrero.Checked == true)
            {
                if (vDia <= 19)
                {
                    //redirige a el formulario 3 acuario
                    fr3 fr3 = new fr3();
                    //muestra el segundo formulario
                    fr3.Show();
                }
                else
                {
                    //redirige a el formulario 4 pisis
                    Fr4 Fr4 = new Fr4();
                    //muestra el segundo formulario
                    Fr4.Show();
                }
            }

            if (rbMarzo.Checked == true)
            {
                if (vDia <= 20)
                {
                    //redirige a el formulario 4 pisis
                    Fr4 Fr4 = new Fr4();
                    //muestra el segundo formulario
                    Fr4.Show();
                }
                else
                {
                    //redirige a el formulario 5 aries
                    fr5 fr5 = new fr5();
                    //muestra el segundo formulario
                    fr5.Show();
                }
            };

            if (rbAbril.Checked == true)
            {
                if (vDia <= 19)
                {
                    //redirige a el formulario 5 aries
                    fr5 fr5 = new fr5();
                    //muestra el segundo formulario
                    fr5.Show();
                }
                else
                {
                    //redirige a el formulario 6 tauro
                    fr6 fr6 = new fr6();
                    //muestra el segundo formulario
                    fr6.Show();
                }
            }

            if (rbMayo.Checked == true)
            {
                if (vDia <= 20)
                {
                    //redirige a el formulario 6 tauro
                    fr6 fr6 = new fr6();
                    //muestra el segundo formulario
                    fr6.Show();
                }
                else
                {
                    //redirige a el formulario 7 geminis
                    fr7 fr7 = new fr7();
                    //muestra el segundo formulario
                    fr7.Show();
                }
            }

            if (rbJunio.Checked == true)
            {
                if (vDia <= 22)
                {
                    //redirige a el formulario 7 geminis
                    fr7 fr7 = new fr7();
                    //muestra el segundo formulario
                    fr7.Show();
                }
                else
                {
                    //redirige a el formulario 8 cancer
                    fr8 fr8 = new fr8();
                    //muestra el segundo formulario
                    fr8.Show();
                }
            }

            if (rbJulio.Checked == true)
            {
                if (vDia <= 22)
                {
                    //redirige a el formulario 8 cancer
                    fr8 fr8 = new fr8();
                    //muestra el segundo formulario
                    fr8.Show();
                }
                else
                {
                    //redirige a el formulario 9 leo
                    fr9 fr9 = new fr9();
                    //muestra el segundo formulario
                    fr9.Show();
                }
            }

            if (rbAgosto.Checked == true)
            {
                if (vDia <= 22)
                {
                    //redirige a el formulario 9 leo
                    fr9 fr9 = new fr9();
                    //muestra el segundo formulario
                    fr9.Show();
                }
                else
                {
                    //redirige a el formulario 10 virgo
                    fr10 fr10 = new fr10();
                    //muestra el segundo formulario
                    fr10.Show();
                }
            }

            if (rbSeptiembre.Checked == true)
            {
                if (vDia <= 22)
                {
                    //redirige a el formulario 10 virgo
                    fr10 fr10 = new fr10();
                    //muestra el segundo formulario
                    fr10.Show();
                }
                else
                {
                    //redirige a el formulario 11 libra
                    fr11 fr11 = new fr11();
                    //muestra el segundo formulario
                    fr11.Show();
                }
            }

            if (rbOctubre.Checked == true)
            {
                if (vDia <= 22)
                {
                    //redirige a el formulario 11 libra
                    fr11 fr11 = new fr11();
                    //muestra el segundo formulario
                    fr11.Show();
                }
                else
                {
                    //redirige a el formulario 12 escorpio
                    fr12 fr12 = new fr12();
                    //muestra el segundo formulario
                    fr12.Show();
                }
            }

            if (rbNoviembre.Checked == true)
            {
                if (vDia <= 21)
                {
                    //redirige a el formulario 12
                    fr12 fr12 = new fr12();
                    //muestra el segundo formulario
                    fr12.Show();
                }
                else
                {
                    //redirige a el formulario 2
                    Fr2 Fr2 = new Fr2();
                    //muestra el segundo formulario
                    Fr2.Show();
                }
            }

            if (rbDiciembre.Checked == true)
            {
                if (vDia <= 21)
                {
                    //redirige a el formulario 12
                    fr12 fr12 = new fr12();
                    //muestra el segundo formulario
                    fr12.Show();
                }
                else
                {
                    //redirige a el formulario 2
                    Fr2 Fr2 = new Fr2();
                    //muestra el segundo formulario
                    Fr2.Show();
                }
            }
        }
    }
}


            
               

           
        
    



                    