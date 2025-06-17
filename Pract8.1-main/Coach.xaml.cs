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

namespace Практическая_Работа_8._1_РКИС
{
    /// <summary>
    /// Логика взаимодействия для Coach.xaml
    /// </summary>
    public partial class Coach : Window
    {
        public Coach()
        {
            InitializeComponent();
        }
       

        private List<String> coach = new List<String>();

        private void Button_Click(object sender, RoutedEventArgs e)//поиск!!!!
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Coach_Closed(this, new EventArgs());
        }

        private void Coach_Closed(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)//ТУТ ТРЕНИ
        {
            List<String> trainingSchedule = new List<String>();
            trainingSchedule.Add("Бокс");
            trainingSchedule.Add("Пилатес");
            trainingSchedule.Add("Фитнес");
            trainingSchedule.Add("Тяжёлая атлетика");
            trainingSchedule.Add("Плаванье");
        }
        private void TBanswer_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)//тренере
        {
         List<String> coach = new List<String>();
         coach.Add("");
         coach.Add("");
         coach.Add("");
         coach.Add("");
         coach.Add("");
         coach.Add("");
        }
    }
}
