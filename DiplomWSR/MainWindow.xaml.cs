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
using System.Data.Entity;
using DiplomWSR.MVVM.Model;
using DiplomWSR.MVVM.View;
namespace DiplomWSR
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();

        }

        //Проверка роли пользователя и подстраивание меню под роль
        public void DetectUserRole(string roleUser, int idProfile)
        {
            if (roleUser == "Администратор")
            {
                
            }

            if (roleUser == "Работник")
            {
                statisticMenuButton.Visibility= Visibility.Collapsed;
                aboutMenuButton.Visibility= Visibility.Collapsed;

            }

            if(roleUser == "Директор")
            {
                calculateMenuButton.Visibility= Visibility.Collapsed;
                aboutMenuButton.Visibility = Visibility.Collapsed;
                profileMenuButton.Visibility= Visibility.Collapsed;
            }

            ProfileView pf = new ProfileView();
            pf.InitializationUser(idProfile);
        }


    }
}
