using MaterialDesignThemes.Wpf;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
namespace Flowershop.UserControls
{
   
    /// <summary>
    /// Логика взаимодействия для CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : UserControl
    {
        static public string Name=null;

        static public int cansel=1;

        static private CreateOrder ex;

        static public CreateOrder EX
        {
            get
            {
                return ex;
            }

            set
            {
                ex = value;
            }
        }
        public CreateOrder(MainWindow mainWindow)
        {
          
            InitializeComponent();
            
            EX = this;
            this.Loaded += CreateOrder_Loaded;

            
           


        }

        private void CreateOrder_Loaded(object sender, RoutedEventArgs e)
        {
            if (Name == null)
            {
                CreateOrder.EX.Create.IsEnabled = false;
            }
           
            if (cansel != 1)
            {
                NameOrder.IsEnabled = false;
                createOrder.IsEnabled = false;

            }
            var g = Windows.login.DB.Flowers;
            foreach(var v in g)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = v.Name;
                comboBoxItem.Tag = v.Cost;
                flawer.Items.Add(comboBoxItem);
            }

            var g2 = Windows.login.DB.Colors;
            foreach (var v2 in g2)
            {
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem.Content = v2.Name;
                color.Items.Add(comboBoxItem);
            }

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Flower flower = new Flower();
                ComboBoxItem comboBoxItem = new ComboBoxItem();
                comboBoxItem = (ComboBoxItem)flawer.SelectedItem;
                flower.Name = (string)comboBoxItem.Content;
                flower.Cost = (string)comboBoxItem.Tag;
                ComboBoxItem comboBoxItem2 = new ComboBoxItem();
                comboBoxItem2 = (ComboBoxItem)color.SelectedItem;
                flower.ITColor = (string)comboBoxItem2.Content;
                MainWindow.user.All_Orders.FirstOrDefault(t => t.Name == Name).Flowers.Add(flower);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не все данные введены");
            }


        }

        private void CreateOrderClick(object sender, RoutedEventArgs e)
        {
            
                NameOrder.IsEnabled = false;
                createOrder.IsEnabled = false;
                 
            
                
            Order order = new Order();
            order.Name = NameOrder.Text;
            cansel = 0;
            Name = order.Name;
            MainWindow.user.All_Orders.Add(order);
            CreateOrder.EX.Create.IsEnabled = true;
        }
    }

        
}

 
     


