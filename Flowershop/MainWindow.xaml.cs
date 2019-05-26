using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    
    public partial class MainWindow : Window
    {
       
        
        public static User user;

        public MainWindow()
        {
            InitializeComponent();
           

            this.Closing += MainWindow_Closing;
        }
        

       
        public MainWindow(User user)
        {
            MainWindow.user = user;
            InitializeComponent();
            this.Closing += MainWindow_Closing;
            GridMain.Children.Clear();
            GridMain.Children.Add(new UserControls.CreateOrder(this));
        }

      

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(50 + (150 * index), -500, 0, 0);

          
                switch (index)
                {
                    case 0:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new UserControls.CreateOrder(this));
                    break;
                    case 1:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new UserControls.Basket(this));
                    break;
                    case 2:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new UserControls.Orders(this));
                    break;
                    case 3:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new UserControls.Themes(this));
                    break;
                }
            
        }

        private void closeForm_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }


      private void exitUser_Click(object sender,RoutedEventArgs e)
        {
            Windows.login login = new Windows.login();
            login.Show();
            Close();
        }

        private void Theme1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GridMain.Children.Clear();
            GridMain.Children.Add(new ThemesUserControl.rose());
        }

        private void Theme2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GridMain.Children.Clear();
            GridMain.Children.Add(new ThemesUserControl.tulip());
        }

        private void Theme3_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GridMain.Children.Clear();
            GridMain.Children.Add(new ThemesUserControl.lily());
        }

        private void Theme4_MouseDown(object sender, MouseButtonEventArgs e)
        {
            GridMain.Children.Clear();
            GridMain.Children.Add(new ThemesUserControl.carnation());
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Windows.login.DB.Dispose();
        }

    }
}