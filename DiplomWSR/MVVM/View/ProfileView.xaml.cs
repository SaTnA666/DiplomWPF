using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data.Entity;
using DiplomWSR.MVVM.Model;

namespace DiplomWSR.MVVM.View
{

    
    /// <summary>
    /// Логика взаимодействия для ProfileView.xaml
    /// </summary>
    public partial class ProfileView : UserControl
    {
        static int id;
        
        static string Name;
        static string Date;
        static string Patronomic;
        static string Surname;
        static string Post;

        public void InitializationUser(int IdProfile)
        {
            
            id = IdProfile;
            User authUser = null;
            using (UsersContext db = new UsersContext())
            {
                authUser = db.Users.Where(b => b.ID == id).FirstOrDefault();

                Name = authUser.Name;
                Surname = authUser.Surname;
                Patronomic = authUser.Patronymic;
                Date = Convert.ToString(authUser.Birthday);
                Post = authUser.Post;
            }
            //proIndex = Date.IndexOf(' ');
            //if(proIndex >= 0)
            //Date.Substring(0, proIndex + 1);

            Date = Date.Split(' ')[0];

            surnameUserText.Text = Surname;
        }

        public ProfileView()
        {
            InitializeComponent();

            surnameUserText.Text = Surname;
            nameUserText.Text = Name;

            
            dateUserText.Text = Date;
            patronomycUserText.Text = Patronomic;
            postUserText.Text = Post;
        }


    }
}
