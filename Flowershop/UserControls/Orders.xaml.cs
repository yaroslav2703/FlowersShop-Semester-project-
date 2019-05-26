using System;
using System.Collections.Generic;
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

namespace Flowershop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для DialogWindow.xaml
    /// </summary>
    public partial class Orders : UserControl
    {

        static private Orders ex;

        static public Orders EX
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
        public Orders(MainWindow mainWindow)
        {
            InitializeComponent();

            EX = this;
            this.Loaded += Orders_Loaded;
        }

        private void Orders_Loaded(object sender, RoutedEventArgs e)
        {
            var x = MainWindow.user.All_Orders;
          
            foreach (Order f in x)
            {
                
                  
                ListBoxItem listBoxItems = new ListBoxItem();
                listBoxItems.Selected += ListBoxItems_Selected;
                listBoxItems.HorizontalAlignment = HorizontalAlignment.Center;
                listBoxItems.Content = "Заказ " +f.Name;
                AllOrders.Items.Add(listBoxItems);

            }
           

        }

        private void ListBoxItems_Selected(object sender, RoutedEventArgs e)
        {
           
            ListBoxItem listBoxItem = (ListBoxItem)e.Source;
           string vr = (string)listBoxItem.Content;
           string  first = vr.Substring(6);
           Order game = MainWindow.user.All_Orders.FirstOrDefault(t => t.Name == first);
            ALLOrders aLLOrders = new ALLOrders(game);
            aLLOrders.Show();

        }
    }  
}

