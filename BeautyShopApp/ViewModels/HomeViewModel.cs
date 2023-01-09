using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BeautyShopApp.Models;
using BeautyShopApp.Services;
using System.Collections.ObjectModel;
using BeautyShopApp.ViewModels.Base;


namespace BeautyShopApp.ViewModels
{
    public class HomeViewModel 
    {
        ObservableCollection<Product> _products;

        public HomeViewModel()
        {
            LoadData();
        }
        public ObservableCollection<Product> Products
        {
            get { return _products; }
            set
            {
                _products = value;
              
            }
        }

 

        private void LoadData()
        {
            Products = new ObservableCollection<Product>();

            // Add first fake item
            Products.Add(new Product());

            foreach (var product in ProductService.Instance.GetProducts())
                Products.Add(product);
        }

    }
}
