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

namespace WSR_PRB_2
{
    /// <summary>
    /// Логика взаимодействия для Basket.xaml
    /// </summary>
    public partial class Basket : Window
    {
        public Basket()
        {
            InitializeComponent();
            ListProd.ItemsSource = Product.basket;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ оформлен!");
            ListProd.ItemsSource = null;
            Product.ClearBasket();
           // ListProd.ItemsSource = Product.basket;
        }
    }
}
