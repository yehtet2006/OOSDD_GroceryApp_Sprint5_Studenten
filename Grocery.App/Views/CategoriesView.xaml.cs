using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class CategoriesView : ContentPage
{
    public CategoriesView(CategoriesView viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}