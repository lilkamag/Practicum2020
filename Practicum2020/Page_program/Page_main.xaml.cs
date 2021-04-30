﻿using System;
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

namespace Practicum2020.Page_program
{
    /// <summary>
    /// Логика взаимодействия для Page_main.xaml
    /// </summary>
    public partial class Page_main : Page
    {
        public Page_main()
        {
            InitializeComponent();
            _search.Text = "Поиск";
        }

        private void _search_GotFocus(object sender, RoutedEventArgs e)
        {
            if(_search.Text == "Поиск")
            {
                _search.Text = String.Empty;
            }
        }

        private void _search_LostFocus(object sender, RoutedEventArgs e)
        {
            if(_search.Text == "")
            {
                _search.Text = "Поиск";
            }
        }
    }
}
