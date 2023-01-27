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
    public class Product
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Price { get; set; }
        public string Vendor { get; set; }
        public string SkidkaSize { get; set; }
        public string Photo { get; set; }

        public static List<Product> products = new List<Product>();
        public static List<Product> basket = new List<Product>();
        public static List<Product> Order = new List<Product>();
        public static ListBox admin = new ListBox();

        public void GetProductVz(ListBox list)
        {
            list.ItemsSource = null;
            SetProductList();
            list.ItemsSource = products;
        }

        public void GetProductYb(ListBox list)
        {
            list.ItemsSource = null;
            SetProductListYb();
            list.ItemsSource = products;
        }

        private void SetProductList()
        {
            products.Clear();
            for(int i = 0; i < 10; i++)
            {
                Product product = new Product();
                product.id = i;
                product.Name = "Имя: " + i;
                product.Desc = "Описание: " + i;
                product.Price = "Цена: " + (1000 + i);
                product.Vendor = "Производитель: " + i;
                product.SkidkaSize = "Размер скидки: " + i;
                product.Photo = "/logo.png";
                products.Add(product);
            }
        }

        private void SetProductListYb()
        {

            products.Clear();
            for (int i = 10; i > 0; i--)
            {
                Product product = new Product();
                product.Name = "Имя: " + i;
                product.Desc = "Описание: " + i;
                product.Price = "Цена: " + (1000 + i);
                product.Vendor = "Производитель: " + i;
                product.SkidkaSize = "Размер скидки: " + i;
                product.Photo = "/logo.png";
                products.Add(product);
            }
        }

        public static void AddBasket(int id)
        {
            foreach(Product pr in products)
            {
                if(pr.id == id)
                {
                    basket.Add(pr);
                }
            }
        }

        public static void DellInBase(int id)
        {
            foreach (Product pr in products)
            {
                if (pr.id == id)
                {
                    products.Remove(pr);
                    break;
                }
            }

            admin.ItemsSource = null;
            admin.ItemsSource = products;
        }

        public static void ClearBasket()
        {
            basket.Clear();
        }

    }
}
