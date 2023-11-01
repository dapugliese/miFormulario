namespace miFormulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            lblApellidoNombre.Text = txbApellido.Text + ", " + txbNombre.Text;
        }
    }
}