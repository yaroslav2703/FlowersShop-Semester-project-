using Flowershop.Classes;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
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

namespace Flowershop.UserControls
{
    /// <summary>
    /// Логика взаимодействия для Help.xaml
    /// </summary>
    public partial class Help : UserControl
    {
        public Help(MainWindow mainWindow)
        {
            InitializeComponent();
        }
        public void buttonmail_Click(object sender, RoutedEventArgs e)
        {
            // отправитель - устанавливаем адрес и отображаемое в письме имя
            MailAddress from = new MailAddress("somemail@gmail.com", "Tom");
            // кому отправляем
            MailAddress to = new MailAddress("kvantonydragon@gmail.com");
            // создаем объект сообщения
            MailMessage m = new MailMessage(from, to);
            // тема письма
            m.Subject = "Оформление заказа";
            // текст письма
            m.Body += "<h4>Примечание:</h4><p>" + Note.Text + "</p>";
            // письмо представляет код html
            m.IsBodyHtml = true;
            // адрес smtp-сервера и порт, с которого будем отправлять письмо
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            // логин и пароль которые пользователь введет сам
            //smtp.Credentials = new NetworkCredential(mail.Password, password.Password);
            smtp.EnableSsl = true;
            smtp.Send(m);
            Console.Read();
        }

        private void AddFile_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
            open.DefaultExt = ".cdr";
            Nullable<bool> result = open.ShowDialog();
            if (result == true)
                filename.Text = open.FileName;

        }
    }
}