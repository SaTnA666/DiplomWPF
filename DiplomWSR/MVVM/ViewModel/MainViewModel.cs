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
        public RelayCommand CalculationViewCommand { get; set; }
        public RelayCommand StatisticViewCommand { get; set; }
        public RelayCommand HomeViewCommand { get; set; }
        public RelayCommand AboutProgramViewCommand { get; set; }
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
            //Start View
            HomeVM = new HomeViewModel();
            CurrentView = HomeVM;

            //Viewies
            AboutProgram = new AboutProgramViewModel();
            Statistic = new StatisticViewModel();
            Calculation = new CalculationViewModel();

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

        }
    }
}
