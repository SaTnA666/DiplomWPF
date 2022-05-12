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
using DiplomWSR.MVVM.Model;

namespace DiplomWSR
{
    /// <summary>
    /// Логика взаимодействия для LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Authorization_Click(object sender, RoutedEventArgs e)
        {
            string login = loginViewBox.Text.Trim();
            string password = passwordViewBox.passwordBox.Password;

            //Проверка на корректный ввод

            if (login.Length < 5)
            {
                
                loginViewBox.title.Text = "Не верно введен логин";
                loginViewBox.title.Foreground = Brushes.Red;

            }

            else if (password.Length < 2)
            {

                passwordViewBox.title.Text = "Не корректно введен пароль";
                passwordViewBox.title.Foreground = Brushes.Red;

            }

            else
            {

                //Поиск пользователя в базе данных

                Profile authorizationUser = null;
                using (ProfileContext db = new ProfileContext())
                {
                    authorizationUser = db.Profiles.Where(b => b.Login == login &&
                    b.Password == password).FirstOrDefault();


                    //Запуск окна с параметрами

                    if (authorizationUser != null)
                    {
                        string roleUser = authorizationUser.Role;
                        MainWindow mw = new MainWindow();
                        mw.DetectUserRole(roleUser);
                        mw.Show();
                        this.Hide();
                        
                    }
                    else
                        MessageBox.Show("Логин или пароль не найден");
                }
            }
            
        }
    }
}
