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
using static Practicum2020.Class_program.Class_frame_mainwindows;
using static Practicum2020.Class_program.Class_personal_identification;
using static Practicum2020.Class_program.Class_page_object;


namespace Practicum2020.Page_program
{
    /// <summary>
    /// Логика взаимодействия для Page_menu_user.xaml
    /// </summary>
    public partial class Page_menu_user : Page
    {
        public Page_menu_user()
        {
            InitializeComponent();
            frame1 = _frame_menu;
        }

        private void _exit_Click(object sender, RoutedEventArgs e)
        {
            var exit = MessageBox.Show("Вы действительно хотите выйти?", "Уведомление", MessageBoxButton.OKCancel, MessageBoxImage.Question);
            if (exit == MessageBoxResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void _local_room_Click(object sender, RoutedEventArgs e)
        {
            _frame_menu.Navigate(_Local_Room);
        }

        private void _Main_Click(object sender, RoutedEventArgs e)
        {
            _frame_menu.Navigate(_main);
        }
    }
}
