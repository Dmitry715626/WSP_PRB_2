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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "Менеджер" && Password.Text == "Менеджер")
            {
                MessageBox.Show("Вы зашли как менеджер");
                new Manager().Show();
            }  
            else if (Login.Text == "Админ" && Password.Text == "Админ")
            {
                MessageBox.Show("Вы зашли как админ");
                new Admin().Show();
            }   
            else
            {
                MessageBox.Show("Под этим логином и паролем нет аккаунта!\nВы будете авторизированны как гость!");
                new Glavnaya().Show();
            }

            Hide();
        }
    }
}
