using Microsoft.Extensions.Logging;
using UsedCarsFinalProject.ViewModels;

namespace UsedCarsFinalProject
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            // register pages
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<InventoryPage>();
            builder.Services.AddSingleton<DetailsPage>();

            //register view models
            builder.Services.AddSingleton<VehicleViewModel>();
            builder.Services.AddSingleton<VehicleDataViewModel>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
