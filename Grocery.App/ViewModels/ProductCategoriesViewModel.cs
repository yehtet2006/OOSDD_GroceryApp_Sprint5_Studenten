using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels
{
    [QueryProperty(nameof(Category), nameof(Category))]
    public partial class ProductCategoriesViewModel : BaseViewModel
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductService _productService;
        private string searchText = "";
        public ObservableCollection<ProductCategory> MyProductCategory{ get; set; } = [];
        public ObservableCollection<Product> AvailableProducts { get; set; } = [];

        [ObservableProperty] private Category category = new(0, "None");
        [ObservableProperty]
        string myMessage;
        
        public ProductCategoriesViewModel(IProductCategoryService productCategoryService, IProductService productService)
        {
            _productCategoryService = productCategoryService;
            _productService = productService;
            Load(category.Id);
        }

        private void Load(int id)
        {
            MyProductCategory.Clear();
            foreach (var item in _productCategoryService.GetAllOnCategoryId(id))
            {
                MyProductCategory.Add(item);
            }
            GetAvailableProducts();
        }

        private void GetAvailableProducts()
        {
            AvailableProducts.Clear();
            foreach (Product p in _productService.GetAll())
                if (MyProductCategory.FirstOrDefault(p => p.ProductId == p.Id) == null && p.Stock > 0 && (searchText == "" || p.Name.ToLower().Contains(searchText.ToLower())))
                    AvailableProducts.Add(p);
        }
        
        partial void OnCategoryChanged(Category value)
        {
            Load(value.Id);
        }
        
        [RelayCommand]
        public void AddProductToCategory(Product product)
        {
            if (product == null) return;
            ProductCategory item = new (0, Category.Id, product.Id);
            _productCategoryService.Add(item);
            item.Product = product;
            _productService.Update(product);
            MyProductCategory.Add(item);
            AvailableProducts.Remove(product);
            OnCategoryChanged(Category);
        }
        
        [RelayCommand]
        public void PerformSearch(string searchText)
        {
            this.searchText = searchText;
            GetAvailableProducts();
        }
    }
}

