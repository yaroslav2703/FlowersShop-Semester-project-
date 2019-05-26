using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace Flowershop.Windows
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void formRegister_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Registration registraition = new Registration();
            registraition.Show();
            Close();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Classes.Admin admin = new Classes.Admin();
            if (txbLogin.Text == admin.login && txbPassword.Password == admin.password)
            {
                MainWindow mainWindow = new MainWindow(admin);
                mainWindow.Show();
                Close();
                return;
            }


            string connectionString = @"Server=ASUS\SQLEXPRESS;Database=PDV_MyBase;Trusted_Connection=True;";
            string sqlExpression = "SELECT * FROM USERS";

            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    sqlConnection.Open();

                    if (txbLogin.Text != String.Empty)
                    {
                        SqlCommand sqlCommand = new SqlCommand(sqlExpression, sqlConnection);
                        SqlDataReader reader = sqlCommand.ExecuteReader();

                        Classes.User tempUser = new Classes.User();

                        if (reader.HasRows)
                        {
                            bool flagPerson = false;

                            while (reader.Read())
                            {
                                if (txbLogin.Text == (string)reader.GetValue(1) && txbPassword.Password == (string)reader.GetValue(2))
                                {
                                    flagPerson = true;
                                    tempUser.idUser = reader.GetValue(0);
                                    tempUser.login = reader.GetValue(1);
                                    tempUser.password = reader.GetValue(2);
                                    break;
                                }
                            }
                            reader.Close();

                            if (flagPerson)
                            {
                                //Передать tempUser
                                MainWindow mainWindow = new MainWindow(tempUser);
                                mainWindow.Show();
                                Close();
                            }
                            else
                            {
                                MessageBox.Show("Такого пользователя нет!");
                                txbLogin.Text = "";
                                txbPassword.Password = "";
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Введите корректные данные!");
                        txbLogin.Text = "";
                        txbPassword.Password = "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}