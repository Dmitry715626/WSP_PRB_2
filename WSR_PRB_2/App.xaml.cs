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

namespace WSR_PRB_2
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар добавлен в корзину");
            Grid grid = (Grid)((Button)sender).Parent;
            Label label = (Label)grid.Children.OfType<Label>().First();
            AddInBasket(int.Parse(label.Content.ToString()));
        }

        private void AddInBasket(int id)
        {
            Product.AddBasket(id);
        }

        private void AddBtn_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Товар удален!");
            Grid grid = (Grid)((Button)sender).Parent;
            Label label = (Label)grid.Children.OfType<Label>().First();
            DellInBase(int.Parse(label.Content.ToString()));
        }

        private void DellInBase(int id)
        {
            Product.DellInBase(id);
        }
    }
}
