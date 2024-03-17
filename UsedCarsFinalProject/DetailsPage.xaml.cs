using UsedCarsFinalProject.ViewModels;

namespace UsedCarsFinalProject;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(VehicleDataViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
    }
}