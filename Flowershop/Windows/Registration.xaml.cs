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

                    try
                    {
                       

                        if (txbLogin.Text.ToString() != String.Empty)
                        {


                              User new_user = new User();
                              new_user.Type = "User";
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

                            new_user.Login = txbLogin.Text;
                            new_user.Password = txbPassword1.Password;

                             User user1 = null;
                              user1 = Windows.login.DB.Users.FirstOrDefault(t => t.Login == new_user.Login);

                            if (user1==null)
                            {

                                Windows.login.DB.Users.Add(new_user);
                                Windows.login.DB.SaveChanges();
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