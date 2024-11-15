namespace Excepcioness
{

    public partial class Form1 : Form
    {
        Empleado empleao = new Empleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                empleao.Id = int.Parse(txtId.Text);
                empleao.Nombre = txtNombre.Text;
                empleao.Edad = int.Parse(txtEdad.Text);
                MessageBox.Show("El dato se ingreso correctamente");\

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
                return;
            }


        }
    }
}
