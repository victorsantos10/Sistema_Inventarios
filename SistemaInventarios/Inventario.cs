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
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            CargarDatos();
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet1.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter1.Fill(this.sistemaInventarioDataSet1.Productos);
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet.Productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.sistemaInventarioDataSet.Productos);

        }
        private void CargarDatos()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\SistemaInventarios\\SistemaInventarios\\SistemaInventario.mdf;Integrated Security=True")) 
            { 
                conexion.Open();    
                string consulta = "SELECT Proveedor, Unidad, Cantidad, Nombre_Producto FROM Productos";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                // Asignar los datos al DataGridView
                Inventario_GridView1.DataSource = datos;
            }
        }
        private void Inventario_EntradaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Entrada entrada = new Entrada();
            entrada.Show();
        }

        private void Inventario_InventarioBtn_Click(object sender, EventArgs e)
        {
            Inventario_InventarioBtn.Enabled = false;   
        }

        private void Inventario_SalidaBTn_Click(object sender, EventArgs e)
        {
            this.Close();
            Salida salida = new Salida();   
            salida.Show();
        }

        private void Inventario_AjustesBtn_Click(object sender, EventArgs e)
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
    }
}
