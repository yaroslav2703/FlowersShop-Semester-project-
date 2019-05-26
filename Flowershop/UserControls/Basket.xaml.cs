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
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    /// 

    public partial class Basket : UserControl
    {
      
        static private Basket ex;

        static public Basket EX
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
        public Basket(MainWindow mainWindow)
        {
            InitializeComponent();
         
            EX = this;
            this.Loaded += Basket_Loaded;
        }

        private void Basket_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                var x = MainWindow.user.All_Orders.FirstOrDefault(t => t.Name == UserControls.CreateOrder.Name);

                foreach (Flower f in x.Flowers)
                {
                    ListBoxItem listBoxItems = new ListBoxItem();
                    listBoxItems.Content = "Выбран " + f.ITColor + " цветок " + f.Name + " стоимостью " + f.Cost;
                    basketList.Items.Add(listBoxItems);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не создан ни один заказ");
                
            }

        }

        private void Done_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                basketList.Items.Clear();
                CreateOrder.EX.Create.IsEnabled = false;
                CreateOrder.cansel = 1;
                CreateOrder.Name = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не создан ни один заказ");

            }
        }
    }
}
