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
using System.Data.Entity;


namespace Flowershop.Windows
{
    /// <summary>
    /// Логика взаимодействия для login.xaml
    /// </summary>
    /// 
   
   
    public partial class login : Window
    {
        static private Context db;
        public login()
        {
            InitializeComponent();
            Context db1 = new Context();
            db1.Templates.Load();
            db1.Users.Load();
            db1.Orders.Load();
            db1.Flowers.Load();
            db1.Colors.Load();
            DB = db1;
        }

        static public Context DB
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
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
           
            if (txbLogin.Text == "admin" && txbPassword.Password == "admin")
            {
                Formalization AdminWindow = new Formalization();
                AdminWindow.Show();
                Close();
                return;
            }
            try
            {
             
                    if (txbLogin.Text != String.Empty)
                    {


                      User new_user = new User();
                      new_user.Type = "User";
                      new_user.Login = txbLogin.Text;
                      new_user.Password = txbPassword.Password;

                       User user1 = null;
                       user1 = Windows.login.DB.Users.FirstOrDefault(t => t.Login == new_user.Login);

                            if (user1 != null)
                            {

                               if(user1.Password != new_user.Password)
                               {
                                MessageBox.Show("Такого пользователя нет!");
                                txbPassword.Password = "";
                                return;
                               }

                               
                                MainWindow mainWindow = new MainWindow(user1);
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
                    else
                    {
                        MessageBox.Show("Введите корректные данные!");
                        txbLogin.Text = "";
                        txbPassword.Password = "";
                    }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}