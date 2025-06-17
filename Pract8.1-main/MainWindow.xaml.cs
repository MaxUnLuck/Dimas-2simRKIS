using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
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

namespace Практическая_Работа_8._1_РКИС
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int fail = 0;
        DateTime? lastAttemptTime = null;
        readonly TimeSpan minDelay = TimeSpan.FromSeconds(1);
        readonly TimeSpan maxDelay = TimeSpan.FromMinutes(5);
        readonly double delayMultiplier = 2.0;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnAutorisation_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (lastAttemptTime.HasValue)
                {
                    TimeSpan timeSinceLastAttempt = DateTime.Now - lastAttemptTime.Value;
                    TimeSpan currentDelay = CalculateDelay();

                    if (timeSinceLastAttempt < currentDelay)
                    {
                        TimeSpan remainingTime = currentDelay - timeSinceLastAttempt;
                        TBTime.Text = $"Попробуйте снова через {remainingTime.Seconds} секунд.";
                        return;
                    }
                }
                string login = TBlog.Text;
                string password = TBPsswd.Password;
                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
                {
                    TBTime.Text ="Введите логин и пароль!";
                    return;
                }
                if (login == "Admin" && password == "1loveRKIS")
                {
                    MessageBox.Show("Всё отлично щас войдём!");
                    Admin admin = new Admin();
                    admin.Show();
                    mainWindow_Closed(this, new EventArgs());
                }
                if (login == "CoachBox" && password == "Box123987")
                {
                    MessageBox.Show("Всё отлично щас войдём!");
                    Coach coach = new Coach();
                    coach.Show();
                    mainWindow_Closed(this, new EventArgs());
                }
                else
                {
                    fail++;
                    lastAttemptTime = DateTime.Now;
                    TimeSpan curDelay = CalculateDelay();
                    TBTime.Text = $"Неверный логин или пароль, след попытка {curDelay.Seconds}";
                }
            }
            catch
            {
                TBTime.Text = "Какая то ошибочка вышла";
            }
        }
        private void mainWindow_Closed(object sender, EventArgs e)
        {
            this.Close();
        }
        private TimeSpan CalculateDelay()
        {
            double delaySeconds = minDelay.TotalSeconds * Math.Pow(delayMultiplier, fail - 1);
            TimeSpan calcdDelay = TimeSpan.FromSeconds(delaySeconds);
            return calcdDelay > maxDelay ? maxDelay : calcdDelay;
        }
    }
}
