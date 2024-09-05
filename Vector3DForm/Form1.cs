namespace Vector3DForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblResultado.Text = "";
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los componentes de los vectores
            double x1 = double.Parse(txtV1X.Text);
            double y1 = double.Parse(txtV1Y.Text);
            double z1 = double.Parse(txtV1Z.Text);

            double x2 = double.Parse(txtV2X.Text);
            double y2 = double.Parse(txtV2Y.Text);
            double z2 = double.Parse(txtV2Z.Text);

            // Crear los objetos Vector3D
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            Vector3D vector2 = new Vector3D(x2, y2, z2);

            // Sumar los vectores
            Vector3D resultado = vector1.Sumar(vector2);

            // Mostrar el resultado
            lblResultado.Text = $"Suma: {resultado}";
        }

        private void btnProductoEscalar_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los componentes de los vectores
            double x1 = double.Parse(txtV1X.Text);
            double y1 = double.Parse(txtV1Y.Text);
            double z1 = double.Parse(txtV1Z.Text);

            double x2 = double.Parse(txtV2X.Text);
            double y2 = double.Parse(txtV2Y.Text);
            double z2 = double.Parse(txtV2Z.Text);

            // Crear los objetos Vector3D
            Vector3D vector1 = new Vector3D(x1, y1, z1);
            Vector3D vector2 = new Vector3D(x2, y2, z2);

            // Calcular el producto escalar
            double productoEscalar = vector1.ProductoEscalar(vector2);

            // Mostrar el resultado
            lblResultado.Text = $"Producto Escalar: {productoEscalar}";
        }
    }
}