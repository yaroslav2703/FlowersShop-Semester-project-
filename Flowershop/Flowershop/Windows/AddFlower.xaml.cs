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
    /// Логика взаимодействия для AddFlower.xaml
    /// </summary>
    public partial class AddFlower : Window
    {
        public AddFlower()
        {
            InitializeComponent();
        }

        private void Addflower_Click(object sender, RoutedEventArgs e)
        {
            Flower newflower = new Flower();
            newflower.Name = flowername.Text;
            newflower.Cost = flowercost.Text;

            ListBoxItem newtextBlock = new ListBoxItem();
            newtextBlock.Name = flowername.Text;
            newtextBlock.Content = "цветок " +newflower.Name + "стоимостью "+ newflower.Cost;

            Formalization.EX.FlowersList.Items.Add(newtextBlock);

            MainWindow.DB.Flowers.Add(newflower);
            MainWindow.DB.SaveChanges();
            

        }
    }
}
