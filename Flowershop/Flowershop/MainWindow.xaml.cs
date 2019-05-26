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
        static private Context db;
        bool isAdmin = false;
        Classes.User user;

        public MainWindow()
        {
            InitializeComponent();
            Context db1 = new Context();
            db1.Shops.Load();
            db1.Users.Load();        
            db1.Orders.Load();
            db1.Flowers.Load();
            db1.Colors.Load();
            DB = db1;

            this.Closing += MainWindow_Closing;
        }
        

        static public Context DB
        {
            get
            {
                return db;
            }

            set
            {
                db = value;
            }
        }
        public MainWindow(Classes.User user)
        {
            this.user = user;
            InitializeComponent();
        }

        Classes.Admin admin;
        public MainWindow(Classes.Admin admin)
        {
            this.admin = admin;
            InitializeComponent();

            GridCursor.Margin = new Thickness(50 + 150, -500, 0, 0);

            GridMain.Children.Clear();
            GridMain.Children.Add(new Formalization());

            isAdmin = true;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(50 + (150 * index), -500, 0, 0);

            if (isAdmin)
            {
                switch (index)
                {
                   case 0:
                        MessageBox.Show("Эта вкладка только для авторизированного пользователя!");

                        GridCursor.Margin = new Thickness(50 + 150, -500, 0, 0);
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new Formalization());
                        break;
                    case 1:
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new Formalization());
                        break;
                    case 2:
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControlsForAdmin.Information(admin));
                        break;
                    case 3:
                        MessageBox.Show("Эта вкладка только для авторизированного пользователя!");

                        GridCursor.Margin = new Thickness(50 + 150, -500, 0, 0);
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new Formalization());
                        break;
                }
            }

            else
            {
                switch (index)
                {
                    case 0:
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControls.Themes(this));
                        break;
                    case 1:
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControls.CreateOrder(this,user));
                        break;
                    case 2:
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControls.DialogWindow(user));
                        break;
                    case 3:
                        GridMain.Children.Clear();
                        GridMain.Children.Add(new UserControls.Help(this));
                        break;
                }
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
            DB.Dispose();
        }

    }
}