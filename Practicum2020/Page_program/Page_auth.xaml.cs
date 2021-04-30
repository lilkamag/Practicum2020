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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static Practicum2020.Method_program.Class_auth;
using static Practicum2020.Class_program.Class_frame_mainwindows;
using static Practicum2020.Class_program.Class_page_object;

namespace Practicum2020.Page_program
{
    /// <summary>
    /// Логика взаимодействия для Page_auth.xaml
    /// </summary>
    public partial class Page_auth : Page
    {
        public Page_auth()
        {
            InitializeComponent();
            _login_user.Text = "Логин";
        }
        private void _enter_system_Click(object sender, RoutedEventArgs e)
        {
            Method_program.Class_auth.auth_user(_login_user.Text, _password_user.Password);
        }

        private void _exit_system_Click(object sender, RoutedEventArgs e)
        {
            var exit = MessageBox.Show("Вы действительно хотите выйти?", "Уведомление", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if(exit == MessageBoxResult.OK)
            {
                Environment.Exit(0);
            }
        }
        private void _param_system_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //var q = _param_system.SelectedItem;
            //switch (q)
            //{
            //    case 0:

            //        break;
            //    case 1:
            //        //Форма
            //        frame.Background = new SolidColorBrush(Colors.Black);
            //        _auth_grid.Background = new SolidColorBrush(Colors.Black);
            //        //Метки
            //        _login_label_.Foreground = new SolidColorBrush(Colors.Yellow);
            //        _pasword_label_.Foreground = new SolidColorBrush(Colors.Yellow);
            //        //Кнопки
            //        _enter_system.Background = new SolidColorBrush(Colors.Gray);
            //        _enter_system.Foreground = new SolidColorBrush(Colors.Yellow);
            //        _exit_system.Background = new SolidColorBrush(Colors.Gray);
            //        _exit_system.Foreground = new SolidColorBrush(Colors.Yellow);
            //        _param_system.Background = new SolidColorBrush(Colors.Gray);
            //        _param_system.Foreground = new SolidColorBrush(Colors.Yellow);
            //        //Вводные поля
            //        _login_user.Background = new SolidColorBrush(Colors.Gray);
            //        _login_user.Foreground = new SolidColorBrush(Colors.Yellow);
            //        _password_user.Background = new SolidColorBrush(Colors.Gray);
            //        _password_user.Foreground = new SolidColorBrush(Colors.Yellow);
            //        break;
            //}
            }

        private void _login_user_GotFocus(object sender, RoutedEventArgs e)
        {
            if (_login_user.Text == "Логин")
            {
                _login_user.Text = "";
                _login_user.Foreground = Brushes.Black;
            }
        }

        private void _login_user_LostFocus(object sender, RoutedEventArgs e)
        {
            if (_login_user.Text == "")
            {
                _login_user.Foreground = Brushes.Gray;
                _login_user.Text = "Логин";
            }
        }

        private void _password_user_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void _password_user_LostFocus(object sender, RoutedEventArgs e)
        {

        }
    }
}
