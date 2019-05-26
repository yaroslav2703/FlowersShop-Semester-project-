using MaterialDesignThemes.Wpf;
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
namespace Flowershop.UserControls
{
   
    /// <summary>
    /// Логика взаимодействия для CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : UserControl
    {
       
        Classes.Theme themeInBD = new Classes.Theme();//наименование
        Classes.Test testInBD = new Classes.Test();//цвет
        Classes.Question questionInDB = new Classes.Question();//пожелание
        private List<Classes.Answer> listAnswerInDB;
        public static List<String> orderList;
        public CreateOrder(MainWindow mainWindow, Classes.User user)
        {
            orderList = new List<String>();
            InitializeComponent();
      
        }
     
        private void btnAddTheme_Click(object sender, RoutedEventArgs e)
        {
            orderList.Add(txbTheme.Text);
            if (txbTheme.Text != String.Empty)
            {
                themeInBD.SomeTheme = txbTheme.Text;
                listThemes.Items.Add(txbTheme.Text);
                txbTheme.Text = "";
            }
        } 
        
    
        private void btnAddTest_Click(object sender, RoutedEventArgs e)
        {
 
                orderList.Add(txbTest.Text);
                if (txbTest.Text != String.Empty)
                {
                    testInBD.SomeTest = txbTest.Text;
                    listTests.Items.Add(txbTest.Text);
                    txbTest.Text = "";
                }
                else
                {
                    MessageBox.Show("Выберите цвет!");
                }
            
        }


        public string nomination;
        public string color;
        public string number;
        public string desire1;
        public string desire2;
        public string desire3;
        public void btnAddQuestion_Click(object sender, RoutedEventArgs e)
        {

       
            orderList.Add(txbQuestion.Text);
                if (txbQuestion.Text != String.Empty)
                {
                    questionInDB.SomeQuestion = txbQuestion.Text;
                    listQuestions.Items.Add(txbQuestion.Text);
                    txbQuestion.Text = "";
                }
                else
                {
                    MessageBox.Show("Введите количество!");
                }
          
        }

   
        private void btnAddAnswer_Click(object sender, RoutedEventArgs e)
        {
            
            orderList.Add(txbAnswer1.Text);

            orderList.Add(txbAnswer2.Text);

            orderList.Add(txbAnswer3.Text);

            listAnswerInDB = new List<Classes.Answer>();
            //если выбрал то количество для которого буду создавать пожелания
            if (listQuestions.SelectedIndex != 1)
            {
                if (txbAnswer1.Text != String.Empty && txbAnswer2.Text != String.Empty && txbAnswer3.Text != String.Empty)
                {
                    if (txbAnswer1.Text == txbAnswer2.Text || txbAnswer1.Text == txbAnswer3.Text || txbAnswer2.Text == txbAnswer1.Text || txbAnswer2.Text == txbAnswer3.Text || txbAnswer3.Text == txbAnswer1.Text || txbAnswer3.Text == txbAnswer2.Text)
                    {
                        MessageBox.Show("Пожелания повторяются, измените!");
                    }
                    else
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Classes.Answer answer = new Classes.Answer();
                            switch (i)
                            {
                                case 0:
                                    answer.SomeAnswer = txbAnswer1.Text;
                                    listAnswerInDB.Add(answer);
                                    break;
                                case 1:
                                    answer.SomeAnswer = txbAnswer2.Text;
                                    listAnswerInDB.Add(answer);
                                    break;
                                case 2:
                                    answer.SomeAnswer = txbAnswer3.Text;
                                    listAnswerInDB.Add(answer);
                                    break;
                            }
                        }
                        txbAnswer1.Text = "";
                        txbAnswer2.Text = "";
                        txbAnswer3.Text = "";
                        MessageBox.Show("Можете переходить к корзине !");
                    }
                }
                else
                {
                    MessageBox.Show("Введите все пожелания,пожалуйста!");
                }
            }
            else
            {
                MessageBox.Show("Выберите количество к которому создаете пожелания!");
            }
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            string ConnectionString = @"Data Source=ASUS\SQLEXPRESS;Initial Catalog=Flowershop;Integrated Security=True";
            using (SqlConnection cn = new SqlConnection(ConnectionString))
            {
                nomination = txbTheme.Text;
                color = txbTest.Text;
                number = txbQuestion.Text;
                desire1 = txbAnswer1.Text;
                desire2 = txbAnswer2.Text;
                desire3 = txbAnswer3.Text;
                cn.Open();
                SqlTransaction transaction = cn.BeginTransaction();
                SqlCommand command = cn.CreateCommand();
                command.Transaction = transaction;
                try
                {
                    command.CommandText = $"INSERT INTO Flo (Nomination,Color,Number,Desire1,Desire2,Desire3) VALUES ('{nomination}','{color}','{number}','{desire1}','{desire2}','{desire3}');";
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    MessageBox.Show("Объект занесен в базу данных");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }
    }
}
