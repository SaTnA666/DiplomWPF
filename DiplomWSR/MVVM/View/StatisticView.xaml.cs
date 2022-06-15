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

namespace DiplomWSR.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для StatisticView.xaml
    /// </summary>
    public partial class StatisticView : UserControl
    {

        static int id;

        DbContextStatistict db;
        public StatisticView()
        {
            InitializeComponent();

            id = 1;
            User authUser = null;
            using (UsersContext db = new UsersContext())
            {
                authUser = db.Users.Where(b => b.ID == id).FirstOrDefault();

                Name = authUser.Surname;
            }

            db = new DbContextStatistict();
            db.Statistics.Load();
            string Surname = Name;
            statisticsGrid.ItemsSource = db.Statistics.Local.ToBindingList();
        }
    }
}
