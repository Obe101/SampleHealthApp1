using Microsoft.Extensions.Logging;
using SampleHealthApp.Pages;
using SampleHealthApp.ViewModels;

namespace SampleHealthApp;

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
        builder.Services.AddSingleton<AccountPage>();
        builder.Services.AddSingleton<AccountViewModel>();

        builder.Services.AddTransient<DetailsPage>();
        builder.Services.AddTransient <DetailsViewModel>();
#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
