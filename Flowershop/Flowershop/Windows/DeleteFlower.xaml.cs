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
    /// Логика взаимодействия для DeleteFlower.xaml
    /// </summary>
    public partial class DeleteFlower : Window
    {
        public DeleteFlower()
        {
            InitializeComponent();
        }

        private void DeleteFlower_Click(object sender, RoutedEventArgs e)
        {
         

           string content = flowername.Text;

           
            Flower flower = MainWindow.DB.Flowers.FirstOrDefault(t=>t.Name==content);
            if (flower != null)
            {
               MainWindow.DB.Flowers.Remove(flower);
               MainWindow.DB.SaveChanges();
                ListBoxItem newtextBlock = new ListBoxItem();
                newtextBlock.Name = flowername.Text;
                Formalization.EX.FlowersList.Items.Remove(newtextBlock);
            }
            else
            {
                MessageBox.Show("Такого цветка нет в ассортименте");
            }
        }
    }
}
