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
    /// Логика взаимодействия для Manager.xaml
    /// </summary>
    public partial class Manager : Window
    {
        Product product = new Product();
        public Manager()
        {
            InitializeComponent();
            product.GetProductVz(ListProd);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            product.GetProductYb(ListProd);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            product.GetProductVz(ListProd);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            new Order().ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            Hide();
        }
    }
}
