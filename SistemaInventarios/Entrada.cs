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

namespace SistemaInventarios
{
    public partial class Entrada : Form
    {
        string CadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\SistemaInventarios\\SistemaInventarios\\SistemaInventario.mdf;Integrated Security=True";
        public Entrada()
        {
            InitializeComponent();
        }

        private void Entrada_ReporteBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            ReporteEntradas reporte = new ReporteEntradas();
            reporte.Show();
        }

        private void Entrada_SalidaBTn_Click(object sender, EventArgs e)
        {
            this.Close();
            Salida salida = new Salida();
            salida.Show();
        }

        private void Entrada_EntradaBtn_Click(object sender, EventArgs e)
        {
            Entrada_EntradaBtn.Enabled = false;
        }

        private void Entrada_InventarioBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void Entrada_AjustesBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Ajustes ajustes = new Ajustes();
            ajustes.Show();
        }

        private void Entrada_SalirBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cierra la aplicación
                Application.Exit(); // Opcionalmente, puedes usar Application.ExitThread();
            }
        }

        private void Entrada_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet2.Proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.sistemaInventarioDataSet2.Proveedores);
        }

        private void Entrada_RecibirBtn1_Click(object sender, EventArgs e)
        {
            EntradaClase entrada = new EntradaClase();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            entrada.Proveedor = Entrada_ProveedorBox.Text;

            entrada.Producto1 = Entrada_ProductoBox1.Text;
            entrada.Unidad1 = Entrada_UnidadBox1.Text;
            entrada.Cantidad1 = int.Parse(Entrada_CantidadText1.Text);

            SqlCommand comando1 = new SqlCommand("Agregar_Productos", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Proveedor", entrada.Proveedor);
            comando1.Parameters.AddWithValue("@Unidad", entrada.Unidad1);
            comando1.Parameters.AddWithValue("@Cantidad", entrada.Cantidad1);
            comando1.Parameters.AddWithValue("@Nombre", entrada.Producto1);
            comando1.ExecuteNonQuery();
            MessageBox.Show("Producto agregado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand comando2 = new SqlCommand("Entradas_Reportes", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@Proveedor", entrada.Proveedor);
            comando2.Parameters.AddWithValue("@CantidadProductos", entrada.Cantidad1);
            comando2.Parameters.AddWithValue("@Nombre_Producto", entrada.Producto1);
            comando2.ExecuteNonQuery();
        }

        private void Entrada_RecibirBtn2_Click(object sender, EventArgs e)
        {
            EntradaClase entrada = new EntradaClase();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            entrada.Proveedor = Entrada_ProveedorBox.Text;

            entrada.Producto2 = Entrada_ProductoBox2.Text;
            entrada.Unidad2 = Entrada_UnidadBox2.Text;
            entrada.Cantidad2 = int.Parse(Entrada_CantidadText2.Text);

            SqlCommand comando1 = new SqlCommand("Agregar_Productos", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Proveedor", entrada.Proveedor);
            comando1.Parameters.AddWithValue("@Unidad", entrada.Unidad2);
            comando1.Parameters.AddWithValue("@Cantidad", entrada.Cantidad2);
            comando1.Parameters.AddWithValue("@Nombre", entrada.Producto2);
            comando1.ExecuteNonQuery();
            MessageBox.Show("Producto agregado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand comando2 = new SqlCommand("Entradas_Reportes", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@Proveedor", entrada.Proveedor);
            comando2.Parameters.AddWithValue("@CantidadProductos", entrada.Cantidad2);
            comando2.Parameters.AddWithValue("@Nombre_Producto", entrada.Producto2);
            comando2.ExecuteNonQuery();
        }

        private void Entrada_RecibirBtn3_Click(object sender, EventArgs e)
        {
            EntradaClase entrada = new EntradaClase();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            entrada.Proveedor = Entrada_ProveedorBox.Text;

            entrada.Producto3 = Entrada_ProductoBox3.Text;
            entrada.Unidad3 = Entrada_UnidadBox3.Text;
            entrada.Cantidad3 = int.Parse(Entrada_CantidadText3.Text);

            SqlCommand comando1 = new SqlCommand("Agregar_Productos", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Proveedor", entrada.Proveedor);
            comando1.Parameters.AddWithValue("@Unidad", entrada.Unidad3);
            comando1.Parameters.AddWithValue("@Cantidad", entrada.Cantidad3);
            comando1.Parameters.AddWithValue("@Nombre", entrada.Producto3);
            comando1.ExecuteNonQuery();
            MessageBox.Show("Producto agregado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand comando2 = new SqlCommand("Entradas_Reportes", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@Proveedor", entrada.Proveedor);
            comando2.Parameters.AddWithValue("@CantidadProductos", entrada.Cantidad3);
            comando2.Parameters.AddWithValue("@Nombre_Producto", entrada.Producto3);
            comando2.ExecuteNonQuery();
        }

        private void Entrada_RecibirBtn4_Click(object sender, EventArgs e)
        {
            EntradaClase entrada = new EntradaClase();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            entrada.Proveedor = Entrada_ProveedorBox.Text;

            entrada.Producto4 = Entrada_ProductoBox4.Text;
            entrada.Unidad4 = Entrada_UnidadBox4.Text;
            entrada.Cantidad4 = int.Parse(Entrada_CantidadText4.Text);

            SqlCommand comando1 = new SqlCommand("Agregar_Productos", conexion);
            comando1.CommandType = System.Data.CommandType.StoredProcedure;
            comando1.Parameters.AddWithValue("@Proveedor", entrada.Proveedor);
            comando1.Parameters.AddWithValue("@Unidad", entrada.Unidad4);
            comando1.Parameters.AddWithValue("@Cantidad", entrada.Cantidad4);
            comando1.Parameters.AddWithValue("@Nombre", entrada.Producto4);
            comando1.ExecuteNonQuery();
            MessageBox.Show("Producto agregado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

            SqlCommand comando2 = new SqlCommand("Entradas_Reportes", conexion);
            comando2.CommandType = System.Data.CommandType.StoredProcedure;
            comando2.Parameters.AddWithValue("@Proveedor", entrada.Proveedor);
            comando2.Parameters.AddWithValue("@CantidadProductos", entrada.Cantidad4);
            comando2.Parameters.AddWithValue("@Nombre_Producto", entrada.Producto4);
            comando2.ExecuteNonQuery();
        }
    }
}
