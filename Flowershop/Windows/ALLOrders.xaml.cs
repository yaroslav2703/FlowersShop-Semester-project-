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

namespace Flowershop
{
    /// <summary>
    /// Логика взаимодействия для ALLOrders.xaml
    /// </summary>
    public partial class ALLOrders : Window
    {
        static public Order order;
        public ALLOrders(Order order)
        {
            InitializeComponent();
            this.Loaded += ALLOrders_Loaded;
            ALLOrders.order = order;
        }

        private void ALLOrders_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (Flower flower in order.Flowers)
            {
                ListBoxItem listBoxItem = new ListBoxItem();
                listBoxItem.Content = flower.ITColor + " цветок " + flower.Name + " стоимостью " + flower.Cost;
                all.Items.Add(listBoxItem);


            }
        }
    }
}
