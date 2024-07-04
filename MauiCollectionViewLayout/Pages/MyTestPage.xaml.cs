using MauiCollectionViewLayout.PageViewModels;

namespace MauiCollectionViewLayout.Pages;

public partial class MyTestPage : ContentPage
{
	public MyTestPage(MyTestPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}