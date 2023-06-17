namespace ElectronikSearch.View;

public partial class MainPage : ContentPage
{
	ProductsViewModel viewModel;

	public MainPage(ProductsViewModel viewModel)
	{
		InitializeComponent();

		this.viewModel = viewModel;

		BindingContext = viewModel;
	}

    protected override async void OnAppearing()
	{

        productsCollection.ItemsSource = viewModel.Products;

        if (viewModel.FirstRun && viewModel.GetRandomProductsCommand.CanExecute(null))
        {
            await viewModel.GetRandomProductsCommand.ExecuteAsync(null);
            viewModel.FirstRun = false;
        }

        base.OnAppearing();
    }

}

