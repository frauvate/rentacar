using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRental
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();

            //veri tabanı bağlantısı için kullanılan yol
            string connectionString = "YOUR SERVER NAME";
            TestDatabaseConnection(connectionString);

        }

        //bağlantının başarılı bir şekilde gerçekleşip gerçekleşmediği uyarısını veren fonksiyon 
        private void TestDatabaseConnection(string connectionString)
        {
            //sql bağlantı nesnesi ile veri tabanı bağlantısı sağlanır
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); //bağlantıyı aç
                    MessageBox.Show("Database connection successful!");
                }
                catch (Exception ex) //herhangi bir sorunla karşılaşıldığında uyarı verir
                {
                    MessageBox.Show($"Couldn't be connected to the database: {ex.Message}");
                }
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userBox.Text; //kullanıcı adını al
            string password = passwordBox.Text; //şifreyi al

            if (ValidateUser(username, password))
            {
                MessageBox.Show("Login succesful!");

                //dashboard formunu aç
                Dashboard dashboard = new Dashboard();
                dashboard.Show();

                //login formunu gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password!");
            }
        }

        //kullanıcıyı doğrulayan fonksiyon
        private bool ValidateUser(string username, string password)
        {
            string connectionString = "YOUR SERVER NAME";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Address = @username AND Password = @password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    try
                    {
                        connection.Open();
                        int count = (int)command.ExecuteScalar(); //sorgu sonucu kullanıcı sayısını döndürür
                        return count > 0; //kullanıcı varsa true döndür
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occured: {ex.Message}");
                        return false;
                    }
                }
            }
        }

        private void registerLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
        }

        private void forgotPasswordLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgotPassword forgotPasswordForm = new ForgotPassword();
            forgotPasswordForm.ShowDialog();
        }

        //kapatma butonu için fonksiyon
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close(); //formu kapatır
        }

        //formun kenarlıkları kapatıldığı için hareket özelliği tanımlanması
        //windows API çağrısı
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
