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
    public partial class Login : Form
    {
        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\VisualStudio\\SistemaInventarios\\SistemaInventarios\\SistemaInventario.mdf;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }
    
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string usuario = UserTextBox.Text;
            string clave = PasswordTextBox.Text;
            SqlConnection conexion = new SqlConnection(connectionString);
            try
            {

                conexion.Open();
                String Consulta = "Select * FROM Usuarios WHERE Usuario = '" + UserTextBox.Text + "' AND Clave = '" + PasswordTextBox.Text + "' ";
                SqlDataAdapter SDA = new SqlDataAdapter(Consulta, connectionString);
                DataTable dtable = new DataTable();
                SDA.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    usuario = UserTextBox.Text;
                    clave = PasswordTextBox.Text;
                    //MessageBox.Show("Inicio de sesión exitoso");
                    // Puedes abrir el formulario principal aquí o realizar cualquier otra acción necesaria.
                    MessageBox.Show("Bienvenido!.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Inventario inventario = new Inventario();
                    inventario.Show();
                  
                }
                else
                {
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UserTextBox.Clear();
                    PasswordTextBox.Clear();

                    UserTextBox.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }
            finally { 

                conexion.Close();   
            }

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    connection.Open();

            //    string query = "SELECT ID_Usuario FROM Usuario WHERE Usuario =  AND Clave = @Clave";
            //    SqlCommand command = new SqlCommand(query, connection);
            //    command.Parameters.AddWithValue("@Usuario", usuario);
            //    command.Parameters.AddWithValue("@Clave", clave);

            //    object result = command.ExecuteScalar();

            //    if (result != null)
            //    {
            //        // Las credenciales son válidas
            //        MessageBox.Show("Inicio de sesión exitoso");
            //        // Puedes abrir el formulario principal aquí o realizar cualquier otra acción necesaria.
            //        Inventario inventario = new Inventario();
            //        this.Close();
            //        inventario.Show();

            //    }
            //    else
            //    {
            //        // Las credenciales no son válidas
            //        MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            //    }
            //}
        }


    }
}