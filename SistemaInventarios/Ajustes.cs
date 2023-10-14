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

  
    public partial class Ajustes : Form
    {

        string CadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\SistemaInventarios\\SistemaInventarios\\SistemaInventario.mdf;Integrated Security=True";
        public Ajustes()
        {
            InitializeComponent();
        }

        private void Ajustes_SalidaBTn_Click(object sender, EventArgs e)
        {
            this.Close();
            Salida salida = new Salida();
            salida.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ajustes_InventarioBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Inventario inventario = new Inventario();
            inventario.Show();
        }

        private void Ajustes_AjustesBtn_Click(object sender, EventArgs e)
        {
            Ajustes_AjustesBtn.Enabled = false; 
        }

        private void Ajustes_SalirBtn_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas cerrar la aplicación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                // Cierra la aplicación
                Application.Exit(); // Opcionalmente, puedes usar Application.ExitThread();
            }
        }

        private void Ajustes_EntradaBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Entrada entrada = new Entrada();
            entrada.Show();
        }

        private void Ajustes_CrearBtn_Click(object sender, EventArgs e)
        {
            IngresoUsers ingreso = new IngresoUsers();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            ingreso.NombreUser = Ajustes_UserText.Text;
            ingreso.contraseña = Ajustes_ClaveText.Text;    
            ingreso.Tipo = Ajustes_TipoUserBox.Text;
            SqlCommand comando = new SqlCommand("InsertUsuario", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Usuario", ingreso.NombreUser);
            comando.Parameters.AddWithValue("@Clave", ingreso.contraseña);
            comando.Parameters.AddWithValue("@Tipo", ingreso.Tipo);
            comando.ExecuteNonQuery();
            MessageBox.Show("Usuario creado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Ajustes_AgregarBtn_Click(object sender, EventArgs e)
        {
            IngresoUsers ingreso = new IngresoUsers();
            SqlConnection conexion = new SqlConnection(CadenaConexion);
            conexion.Open();
            ingreso.NombreCliente = Ajustes_ClienteText.Text;
            ingreso.NumeroCliente = NroClienteText.Text;
            SqlCommand comando = new SqlCommand("InsertCliente", conexion);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@NombreCliente", ingreso.NombreCliente);
            comando.Parameters.AddWithValue("@Numero", ingreso.NumeroCliente);
            comando.ExecuteNonQuery();
            MessageBox.Show("Cliente agregado correctamente.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
