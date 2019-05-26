using System;
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Collections.Generic;

namespace Flowershop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для DialogWindow.xaml
    /// </summary>
    public partial class DialogWindow : UserControl
    {

        public DialogWindow(Classes.User user)
        {
            InitializeComponent();
        }

        public DialogWindow(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
        }

        string connectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=Flowershop;Integrated Security=True";
        private MainWindow mainWindow;

        
        private void Show_Button_Click(object sender, RoutedEventArgs e)
        {
           

            string sqlExpression = "Select * from Flo";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand(sqlExpression, connection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                if (sqlDataReader.HasRows)
                {
                    List<Classes.Basket> listProducts = new List<Classes.Basket>();
                    while (sqlDataReader.Read())
                    {
                        Classes.Basket product = new Classes.Basket()
                        {
                            Name = sqlDataReader.GetValue(0),
                            Color = sqlDataReader.GetValue(1),
                            Number = sqlDataReader.GetValue(2),
                            Desire1 = sqlDataReader.GetValue(3),
                            Desire2 = sqlDataReader.GetValue(4),
                            Desire3 = sqlDataReader.GetValue(5)
                        };
                        listProducts.Add(product);

                    }
                    User_Grid.ItemsSource = listProducts;
                }
                else
                {
                    MessageBox.Show("No strings!");
                }
            }


            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

