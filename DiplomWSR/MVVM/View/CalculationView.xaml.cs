using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using Delivery.Api;
using Delivery.Models;
using DiplomWSR.MVVM.Model;
using DiplomWSR.MVVM.View;

namespace DiplomWSR.MVVM.View
{
    /// <summary>
    /// Логика взаимодействия для CalculationView.xaml
    /// </summary>
    public partial class CalculationView : UserControl
    {
        static int countCalc; //Счетчик расчетов
        static int userId; //Айди пользователя
        static DateTime nowTime = DateTime.Now; //Дата начала смены

        public CalculationView()
        {

            InitializeComponent();

        }

        public void InitialUserId(int userid)
        {
            userId = userid;
        }

        private void CalculationsClickButton(object sender, RoutedEventArgs e)
        {
            countCalc++;//Добавление счетчика расчетов

            

            string weightProduct = tbxWeight.Text;
            string heightProduct = tbxHeight.Text;
            string lenghProduct = tbxLeightf.Text;
            string widthProduct = tbxWidth.Text;
            string cityFrom = tbxFrom.Text;
            string cityWhere = tbxWhere.Text;
            int countProduct = Convert.ToInt32(tbxCount.Text);
            string goodsIdProduct = "1";

            GoodsInCalc product = new GoodsInCalc()
            {
                goodsId = goodsIdProduct,
                weight = weightProduct,
                height = heightProduct,
                lengh = lenghProduct,
                width = widthProduct

            };

            //Обращение к апи

            List<CostDelivery> delivery = new DeliveryResponse(cityFrom, cityWhere, product, countProduct).CalculatedDeliveries;
            calculationDg.ItemsSource = delivery; //Загрузка данных из api в таблицу

        }

        public void SaveStatisticUser(object sender, RoutedEventArgs e)
        {

            using(Model.DbContextStatistict db = new DbContextStatistict())
            {
                Statistics result = new Statistics
                {

                    LoginTime = nowTime,
                    ReleaseTime = DateTime.Now,
                    CalculationsCarried = countCalc,
                    UserID = userId,
                    Efficiency = 100

                };

                db.Statistics.Add(result);

                db.SaveChanges();
            }

            //using (DbContextStatistic db = new DbContextStatistic())
            //{



            //}
            //DataContext = null;
            //DataContext = new ProductsView();
        }
    }
}
