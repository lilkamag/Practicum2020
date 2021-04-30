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
using static Practicum2020.Class_program.Class_personal_identification;
using static Practicum2020.Class_program.Class_model_entity;

namespace Practicum2020.Page_program
{
    /// <summary>
    /// Логика взаимодействия для Page_local_room.xaml
    /// </summary>
    public partial class Page_local_room : Page
    {
        public Page_local_room()
        {
            InitializeComponent();
        }
        public void personaldata()
        {
            var b = context.TB_USERS.Find(identification);
            _name.Content = b.U_NAME;
            _surname.Content = b.U_SURNAME;
            _middlename.Content = b.U_MIDDLENAME;
            _telephone.Content = b.U_PHONE;
        }
    }
}
