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

namespace Flowershop
{
    /// <summary>
    /// Логика взаимодействия для Formalization.xaml
    /// </summary>
    public partial class Formalization : UserControl
    {
        static private Formalization ex;
        public Formalization()
        {
            InitializeComponent();
            EX = this;
        }

        static public Formalization EX
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

        private void AddFlowerClick(object sender, RoutedEventArgs e)
        {
            AddFlower addFlower = new AddFlower();
            addFlower.Show();
        }

        private void AddColorClick(object sender, RoutedEventArgs e)
        {
            AddColor addColor = new AddColor();
            addColor.Show();
        }

        private void DeleteColorClick(object sender, RoutedEventArgs e)
        {
            DeleteColor deleteColor = new DeleteColor();
            deleteColor.Show();
        }

        private void DeleteFlowerClick(object sender, RoutedEventArgs e)
        {
            DeleteFlower deleteFlower = new DeleteFlower();
            deleteFlower.Show();
        }
    }
}