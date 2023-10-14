using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaInventarios
{
    public partial class Salida : Form
    {
        public Salida()
        {
            InitializeComponent();
        }

        string CadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\SistemaInventarios\\SistemaInventarios\\SistemaInventario.mdf;Integrated Security=True";

        private void Salida_EntradaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Entrada entrada = new Entrada();
            entrada.Show();
        }

        private void Salida_SalidaBTn_Click(object sender, EventArgs e)
        {
            Salida_SalidaBTn.Enabled = false;
        }

        private void Salida_InventarioBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void Salida_AjustesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
        }

        private void Salida_SalirBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cierra la aplicación
                Application.Exit(); // Opcionalmente, puedes usar Application.ExitThread();
            }
        }

        private void Salida_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'productos._Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.productos._Productos);
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet8.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.sistemaInventarioDataSet8.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet6.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.sistemaInventarioDataSet6.Clientes);
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet2.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.sistemaInventarioDataSet2.Proveedores);   

        }

        private void Salida_ReporteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteSalida reporteSalida = new ReporteSalida();  
            reporteSalida.Show();   
        }


        private void Salida_DespacharBtn1_Click(object sender, EventArgs e)
        {
            EntradaClase salida = new EntradaClase();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            salida.Proveedor = Salida_ProveedorBox.Text;
            salida.Cliente = Salida_SalidaCliente.Text; 

            salida.Producto1 = Salida_ProductoBox1.Text;
            salida.Cantidad1 = int.Parse(Salida_CantidadText1.Text);

            SqlCommand comando1 = new SqlCommand("RestarCantidadProducto", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Proveedor", salida.Proveedor);
            comando1.Parameters.AddWithValue("@NombreProducto", salida.Producto1);
            comando1.Parameters.AddWithValue("@CantidadARestar", salida.Cantidad1);
            comando1.ExecuteNonQuery();
            MessageBox.Show("Producto despachado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand comando2 = new SqlCommand("Salidas_Reportes", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@Producto", salida.Producto1);
            comando2.Parameters.AddWithValue("@CantidadProductos", salida.Cantidad1);
            comando2.Parameters.AddWithValue("@Cliente", salida.Cliente);
            comando2.ExecuteNonQuery();

        }

        private void Salida_DespacharBtn2_Click(object sender, EventArgs e)
        {
            EntradaClase salida = new EntradaClase();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            salida.Proveedor = Salida_ProveedorBox.Text;
            salida.Cliente = Salida_SalidaCliente.Text;

            salida.Producto2 = Salida_ProductoBox1.Text;
            salida.Cantidad2 = int.Parse(Salida_CantidadText1.Text);

            SqlCommand comando1 = new SqlCommand("RestarCantidadProducto", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Proveedor", salida.Proveedor);
            comando1.Parameters.AddWithValue("@NombreProducto", salida.Producto2);
            comando1.Parameters.AddWithValue("@CantidadARestar", salida.Cantidad2);
            comando1.ExecuteNonQuery();
            MessageBox.Show("Producto despachado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand comando2 = new SqlCommand("Salidas_Reportes", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@Producto", salida.Producto2);
            comando2.Parameters.AddWithValue("@CantidadProductos", salida.Cantidad2);
            comando2.Parameters.AddWithValue("@Cliente", salida.Cliente);
            comando2.ExecuteNonQuery();
        }

        private void Salida_DespacharBtn3_Click(object sender, EventArgs e)
        {
            EntradaClase salida = new EntradaClase();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            salida.Proveedor = Salida_ProveedorBox.Text;
            salida.Cliente = Salida_SalidaCliente.Text;

            salida.Producto3 = Salida_ProductoBox1.Text;
            salida.Cantidad3 = int.Parse(Salida_CantidadText1.Text);

            SqlCommand comando1 = new SqlCommand("RestarCantidadProducto", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Proveedor", salida.Proveedor);
            comando1.Parameters.AddWithValue("@NombreProducto", salida.Producto3);
            comando1.Parameters.AddWithValue("@CantidadARestar", salida.Cantidad3);
            comando1.ExecuteNonQuery();
            MessageBox.Show("Producto despachado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand comando2 = new SqlCommand("Salidas_Reportes", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@Producto", salida.Producto3);
            comando2.Parameters.AddWithValue("@CantidadProductos", salida.Cantidad3);
            comando2.Parameters.AddWithValue("@Cliente", salida.Cliente);
            comando2.ExecuteNonQuery();
        }

        private void Salida_DespacharBtn4_Click(object sender, EventArgs e)
        {
            EntradaClase salida = new EntradaClase();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            salida.Proveedor = Salida_ProveedorBox.Text;
            salida.Cliente = Salida_SalidaCliente.Text;

            salida.Producto4 = Salida_ProductoBox1.Text;
            salida.Cantidad4 = int.Parse(Salida_CantidadText1.Text);

            SqlCommand comando1 = new SqlCommand("RestarCantidadProducto", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Proveedor", salida.Proveedor);
            comando1.Parameters.AddWithValue("@NombreProducto", salida.Producto4);
            comando1.Parameters.AddWithValue("@CantidadARestar", salida.Cantidad4);
            comando1.ExecuteNonQuery();
            MessageBox.Show("Producto despachado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand comando2 = new SqlCommand("Salidas_Reportes", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@Producto", salida.Producto4);
            comando2.Parameters.AddWithValue("@CantidadProductos", salida.Cantidad4);
            comando2.Parameters.AddWithValue("@Cliente", salida.Cliente);
            comando2.ExecuteNonQuery();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.proveedoresTableAdapter.FillBy(this.sistemaInventarioDataSet2.Proveedores);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
