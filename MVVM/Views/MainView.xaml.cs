using RESTDemo.MVVM.ViewModels;

namespace RESTDemo.MVVM.Views;

public partial class MainView : ContentPage
{
	public MainView()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}