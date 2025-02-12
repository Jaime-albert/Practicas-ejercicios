namespace ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnjuntar_Click(object sender, EventArgs e)
        {
            lblpalabra.Text = texpal1.Text + " " + texpal2.Text;
            texpal1.Text = "";
            texpal2.Text = "";
        }
    }
}
