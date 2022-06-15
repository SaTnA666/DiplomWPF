
using System.Windows;
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

            if (roleUser == "Логист")
            {
                statisticMenuButton.Visibility= Visibility.Collapsed;
                aboutMenuButton.Visibility= Visibility.Collapsed;
                exitMenuButton.Visibility= Visibility.Visible;

            }

            if(roleUser == "Директор")
            {
                calculateMenuButton.Visibility= Visibility.Collapsed;
                aboutMenuButton.Visibility = Visibility.Collapsed;
                profileMenuButton.Visibility= Visibility.Collapsed;
            }

            ProfileView pf = new ProfileView();
            pf.InitializationUser(idProfile);

            CalculationView cv = new CalculationView();
            cv.InitialUserId(idProfile);
        }

        public void testMethod()
        {
            exitMenuButton.Visibility = Visibility.Visible;
        }

        private void exitMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
