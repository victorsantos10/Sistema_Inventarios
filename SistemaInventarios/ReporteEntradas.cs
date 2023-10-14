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
    public partial class ReporteEntradas : Form
    {
        public ReporteEntradas()
        {
            InitializeComponent();
        }

        private void ReporteEntradas_Load(object sender, EventArgs e)
        {
            CargarDatos();
            // TODO: esta línea de código carga datos en la tabla 'sistemaInventarioDataSet3.Entradas' Puede moverla o quitarla según sea necesario.
            this.entradasTableAdapter.Fill(this.sistemaInventarioDataSet3.Entradas);

        }

        private void CargarDatos()
        {
            using (SqlConnection conexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\SistemaInventarios\\SistemaInventarios\\SistemaInventario.mdf;Integrated Security=True"))
            {
                conexion.Open();
                string consulta = "SELECT * FROM Entradas";
                SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                DataTable datos = new DataTable();
                adaptador.Fill(datos);

                // Asignar los datos al DataGridView
                ReporteEntradaGrid.DataSource = datos;
            }
        }

        private void VolverEntradaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Entrada entrada = new Entrada();
            entrada.Show(); 
        }
    }
}
