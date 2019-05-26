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
    /// Логика взаимодействия для AddColor.xaml
    /// </summary>
    public partial class AddColor : Window
    {
        public AddColor()
        {
            InitializeComponent();
        }

        private void AddColor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Color newcolor = new Color();
            newcolor.Name = colorname.Text;
           

            ListBoxItem newtextBlock = new ListBoxItem();
            newtextBlock.Name = colorname.Text;
            newtextBlock.Content = "цвет " + newcolor.Name;

            Formalization.EX.ColorsList.Items.Add(newtextBlock);
          
            Windows.login.DB.Colors.Add(newcolor);
            Windows.login.DB.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверные данные");
            }
        }
    }
}
