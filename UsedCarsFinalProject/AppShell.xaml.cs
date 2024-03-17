using UsedCarsFinalProject.ViewModels;

namespace UsedCarsFinalProject
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            BindingContext = new VehicleViewModel();

            Routing.RegisterRoute(nameof(DirectionPage), typeof(DirectionPage));
            Routing.RegisterRoute(nameof(InventoryPage), typeof(InventoryPage));
            Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
        }
    }
}
