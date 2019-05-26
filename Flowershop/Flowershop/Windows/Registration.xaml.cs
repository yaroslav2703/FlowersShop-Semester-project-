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
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void formLogin_MouseDown(object sender, MouseButtonEventArgs e)
            {
                login login = new login();
                login.Show();
                Close();
            }

           private void btnClose_Click(object sender, RoutedEventArgs e)
           {
                Close();
            }

            private void btnRegister_Click(object sender, RoutedEventArgs e)
            {
                string connectionString = @"Server=ASUS\SQLEXPRESS;Database=PDV_MyBase;Trusted_Connection=True;";

                string sqlExpression1 = $"INSERT INTO Users ([Login], [Password]) VALUES ('{txbLogin.Text}', '{txbPassword1.Password}')";
                string sqlExpression2 = "SELECT * FROM Users";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        if (txbLogin.Text.ToString() != String.Empty)
                        {
                            if (txbPassword1.Password.Length < 6)
                            {
                                MessageBox.Show("Маленький пароль!");
                                return;
                            }

                            if (txbPassword1.Password != txbPassword2.Password)
                            {
                                MessageBox.Show("Пароли не совпадают!");
                                return;
                            }


                            SqlCommand command2 = new SqlCommand(sqlExpression2, connection);
                            SqlDataReader reader = command2.ExecuteReader();

                            bool flagPerson = false;
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    if (txbLogin.Text == (string)reader.GetValue(1))
                                    {
                                        flagPerson = true;
                                        break;
                                    }
                                }
                            }
                            reader.Close();


                            if (!flagPerson)
                            {
                                SqlCommand command1 = new SqlCommand(sqlExpression1, connection);
                                command1.ExecuteNonQuery();
                                MessageBox.Show("Регистрация прошла успешно!");

                                login login = new login();
                                login.Show();
                                Close();

                                txbLogin.Text = "";
                                txbPassword1.Password = "";
                                txbPassword2.Password = "";
                            }
                            else
                            {
                                MessageBox.Show("Такой пользователь уже существует!");

                                txbLogin.Text = "";
                                txbPassword1.Password = "";
                                txbPassword2.Password = "";
                            }


                        }
                        else
                        {
                            MessageBox.Show("Введите корректные данные!");
                            txbLogin.Text = "";
                            txbPassword1.Password = "";
                            txbPassword2.Password = "";
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    }