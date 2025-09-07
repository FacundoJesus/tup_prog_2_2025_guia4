using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Defino una variable de referencia: presupuesto.
        Presupuesto presupuesto;

        private void btnIniciarPresupuesto_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;
            presupuesto = new Presupuesto(nombre, direccion);

            tbNombre.Enabled = false;
            tbDireccion.Enabled = false;
            lbNombre.Enabled = false;
            lbDireccion.Enabled = false;
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (presupuesto != null)
            {
                double largo = Convert.ToDouble(tbLargo.Text);
                double precioBase = Convert.ToDouble(tbPrecioBase.Text);
                int codigo = Convert.ToInt32(tbCodigo.Text);

                Producto producto = null;
                if (rbBanco.Checked)
                {
                    producto = new Banco(precioBase, largo);
                    producto.Codigo = codigo;
                }
                else
                if (rbMesa.Checked)
                {
                    double ancho = Convert.ToDouble(tbAncho.Text);
                    double grosor = Convert.ToDouble(tbGrosor.Text);

                    producto = new Mesa(precioBase, largo, ancho, grosor);
                    producto.Codigo = codigo;
                }
                presupuesto.AgregarProducto(producto);
                cmbProductos.Items.Add(producto);

                //Limpio campos
                tbLargo.Clear();
                tbPrecioBase.Clear();
                tbCodigo.Clear();
                tbAncho.Clear();
                tbGrosor.Clear();
                rbBanco.Checked = false;
                rbMesa.Checked = false;
            }
            else
            {
                MessageBox.Show("Debes iniciar un presupuesto colocando los datos del Cliente.");
            }
        }

        private void btnBorrarProducto_Click(object sender, EventArgs e)
        {
            Producto prodSeleccionado = cmbProductos.SelectedItem as Producto;

            if (prodSeleccionado != null)
            {
                presupuesto.QuitarProducto(prodSeleccionado.Codigo);

                cmbProductos.Items.Remove(prodSeleccionado);
                cmbProductos.Text = "";
            }
            else
            {
                MessageBox.Show("Debes seleccionar un producto de la lista para borrarlo.");
            }
        }

        private void btnCerrarPresupuesto_Click(object sender, EventArgs e)
        {

            if (presupuesto != null)
            {
                FPresupuesto fPresupuesto = new FPresupuesto();
                fPresupuesto.lsbResultado.Items.AddRange(presupuesto.Resumen());

                //Muestro al final
                fPresupuesto.ShowDialog();
                fPresupuesto.Dispose();
            }
            else
            {
                MessageBox.Show("Debes iniciar un presupuesto con los datos del Cliente.");
            }
            
        }
    }
}
