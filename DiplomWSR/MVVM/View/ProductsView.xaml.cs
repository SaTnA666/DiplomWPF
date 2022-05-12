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
using DiplomWSR.MVVM.Model;
using System.Data.Entity;

namespace DiplomWSR.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для ProductsView.xaml
    /// </summary>
    public partial class ProductsView : Page
    {

        

        ProductsContext db;

        public ProductsView()
        {
            InitializeComponent();

            db = new ProductsContext();
            db.Products.Load();
            productsDg.ItemsSource = db.Products.Local.ToBindingList();
        }
    }
}
