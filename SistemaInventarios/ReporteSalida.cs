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
    public partial class ReporteSalida : Form
    {
        public ReporteSalida()
        {
            InitializeComponent();
        }

        private void ReporteSalida_Load(object sender, EventArgs e)
        {
            CargarDatos();
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet5.Salidas' Puede moverla o quitarla según sea necesario.
            this.salidasTableAdapter1.Fill(this.sistemaInventarioDataSet5.Salidas);
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet4.Salidas' Puede moverla o quitarla según sea necesario.
            this.salidasTableAdapter.Fill(this.sistemaInventarioDataSet4.Salidas);

        }

        private void CargarDatos()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\SistemaInventarios\\SistemaInventarios\\SistemaInventario.mdf;Integrated Security=True"))
            {
                conexion.Open();
                string consulta = "SELECT * FROM Salidas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                // Asignar los datos al DataGridView
                ReporteSalidaGrid.DataSource = datos;
            }
        }

        private void VolverSalidaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Salida salida = new Salida();
            salida.Show();
        }
    }
}
