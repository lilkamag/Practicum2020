using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using static Practicum2020.Class_program.Class_frame_mainwindows;
using static Practicum2020.Class_program.Class_page_object;
using static Practicum2020.Class_program.Class_model_entity;
using static Practicum2020.Class_program.Class_personal_identification;

namespace Practicum2020.Method_program
{
    class Class_auth
    {
        public static void auth_user(string x, string y)
        {
            var qwerty = from auth in context.TB_USERS
                         join pd in context.TB_ROLE on auth.ID_USERS equals pd.ID_ROLE into gj
                         from asd in gj.DefaultIfEmpty()
                         select new {asd.ID_ROLE, asd.ROLE, auth.ID_USERS, auth.U_LOGIN, auth.U_PASS, auth.U_PHONE};
            string c = EncriptionChar2(y);//Pass
            string v = EncriptionChar1(x);//login
            try
            {
                //var au = qwerty.Where(i => i.U_LOGIN == v && i.U_PASS == c).ToList();
                var a = context.TB_USERS.Where(i => i.U_LOGIN == v && i.U_PASS == c).ToList();
                var b = context.TB_USERS.Where(i => i.U_LOGIN == v && i.U_PASS == c).FirstOrDefault();
                if (a.Count > 0)
                {
                    int identification = b.ID_USERS;
                    local(identification);
                    frame.Navigate(_Menu_User);
                    frame1.Navigate(_main);
                    c = String.Empty;
                    v = String.Empty;
                    x = String.Empty;
                    y = String.Empty;
                    _Auth._login_user.Text = "Логин";
                    _Auth._password_user.Password = String.Empty;
                }
                else
                {
                    var erauth = MessageBox.Show("Проверте логин или пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    if(erauth == MessageBoxResult.OK)
                    {
                        c = String.Empty;
                        v = String.Empty;
                        x = String.Empty;
                        y = String.Empty;
                        _Auth._login_user.Text = "Логин";
                        _Auth._password_user.Password = String.Empty;
                    }
                }
            }
            catch(Exception e)
            {
                var exc = MessageBox.Show($"Наименование ошибки: {e}\nПосле закрытия данного окна закроется программа","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
                if (exc == MessageBoxResult.OK)
                {
                    Environment.Exit(0);
                }
            }
        }
        public static void local(int id)
        {
            try
            {
                var qwer_0 = context.TB_USERS.Find(id);
                _Local_Room._name.Content = qwer_0.U_NAME;
                _Local_Room._surname.Content = qwer_0.U_SURNAME;
                _Local_Room._middlename.Content = qwer_0.U_MIDDLENAME;
                _Local_Room._telephone.Content = qwer_0.U_PHONE;
                _Local_Room._role.Content = qwer_0.U_ROLE;
                //_Local_Room._email.Content = qwer_0.
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка базы");
            }
        }
            private static string EncriptionChar2(string y)
        {
            string temp = String.Empty;
            foreach (var x in y)
            {
                temp = temp += Convert.ToString((char)((int)(x) ^ 2));
            }
            return temp;
        }

        private static string EncriptionChar1(string x)
        {
            string temp = String.Empty;
            foreach (var y in x)
            {
                temp = temp += Convert.ToString((char)((int)(y) ^ 2));
            }
            return temp;
        }
    }
}
