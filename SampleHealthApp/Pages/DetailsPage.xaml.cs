using SampleHealthApp.ViewModels;

namespace SampleHealthApp.Pages;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(DetailsViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}