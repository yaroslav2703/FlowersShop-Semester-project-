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
    /// Логика взаимодействия для DeleteColor.xaml
    /// </summary>
    public partial class DeleteColor : Window
    {
        public DeleteColor()
        {
            InitializeComponent();
        }

        private void DeleteColor_Click(object sender, RoutedEventArgs e)
        {
            string content = colorname.Text;


            Color color = MainWindow.DB.Colors.FirstOrDefault(t => t.Name == content);
            if (color != null)
            {
                MainWindow.DB.Colors.Remove(color);
                MainWindow.DB.SaveChanges();
                ListBoxItem newtextBlock = new ListBoxItem();
                newtextBlock.Name = colorname.Text;
                Formalization.EX.ColorsList.Items.Remove(newtextBlock);
            }
            else
            {
                MessageBox.Show("Такого цветка нет в ассортименте");
            }
        }
    }
}
