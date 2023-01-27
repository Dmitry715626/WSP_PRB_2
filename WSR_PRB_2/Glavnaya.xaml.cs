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
    /// Логика взаимодействия для Glavnaya.xaml
    /// </summary>
    public partial class Glavnaya : Window
    {
        public Glavnaya()
        {
            InitializeComponent();
            Product product = new Product();
            product.GetProductVz(ListProd);
        }

        private void Butv_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.GetProductVz(ListProd);
        }

        private void Buty_Click(object sender, RoutedEventArgs e)
        {
            Product product = new Product();
            product.GetProductYb(ListProd);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Basket().ShowDialog();
        }

        private void Out_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Hide();
        }
    }
}
