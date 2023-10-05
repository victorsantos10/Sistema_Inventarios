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
        private string connectionString = "Data Source=THEKILLERCODE;Initial Catalog=Experimentacion;Integrated Security=True;\r\n"; // Reemplaza esto con tu cadena de conexión a la base de datos

        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string usuario = UserTextBox.Text;
            string clave = PasswordTextBox.Text;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT ID_Usuario FROM Usuario WHERE Usuario = @Usuario AND Clave = @Clave";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Usuario", usuario);
                command.Parameters.AddWithValue("@Clave", clave);

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    // Las credenciales son válidas
                    MessageBox.Show("Inicio de sesión exitoso");
                    // Puedes abrir el formulario principal aquí o realizar cualquier otra acción necesaria.
                }
                else
                {
                    // Las credenciales no son válidas
                    MessageBox.Show("Nombre de usuario o contraseña incorrectos");
                }
            }
        }
    }
}