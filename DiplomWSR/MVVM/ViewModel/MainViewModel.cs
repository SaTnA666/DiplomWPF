using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiplomWSR.Core;

namespace DiplomWSR.MVVM.ViewModel
{
     class MainViewModel : ObservableObject

     {
        public RelayCommand ProfileViewCommand { get; set; }
        public RelayCommand ProductsViewCommand { get; set; }
        public RelayCommand CalculationViewCommand { get; set; }
        public RelayCommand StatisticViewCommand { get; set; }
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutProgramViewCommand { get; set; }
        public ProfileViewModel Profile { get; set; }
        public ProductsViewModel Products { get; set; } 
        public AboutProgramViewModel AboutProgram { get; set; }
        public StatisticViewModel Statistic { get; set; }
        public CalculationViewModel Calculation { get; set; }
         public HomeViewModel HomeVM { get; set; }
         public object _currentView { get; set; }

         public object CurrentView
         {
             get { return _currentView;}
             set
             {
                 _currentView = value;
                 OnPropertyChanged();
             }
         }
        public MainViewModel()
        {

           

            //Первоначальное окно

            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;

            //Окна

            AboutProgram = new AboutProgramViewModel();
            Statistic = new StatisticViewModel();
            Calculation = new CalculationViewModel();
            Products = new ProductsViewModel();
            Profile = new ProfileViewModel();

            HomeViewCommand = new RelayCommand(o => 
            {
                CurrentView = HomeVM;
            });

            AboutProgramViewCommand = new RelayCommand(o =>
            {
                CurrentView = AboutProgram;
            });

            StatisticViewCommand = new RelayCommand(o => 
            {
                CurrentView = Statistic;
            });

            CalculationViewCommand = new RelayCommand(o =>
            {
                CurrentView = Calculation;
            });

            ProductsViewCommand = new RelayCommand(o =>
            {
                CurrentView = Products;
            });

            ProfileViewCommand = new RelayCommand(o =>
            {
                CurrentView = Profile;
            });

            

        }
    }
}
