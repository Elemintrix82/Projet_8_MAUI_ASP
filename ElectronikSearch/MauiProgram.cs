using Microsoft.Extensions.Logging;

namespace ElectronikSearch;

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

        builder.Services.AddSingleton<ProductService>();

        builder.Services.AddSingleton<ProductsViewModel>();

        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddTransient<ProductDetailsViewModel>();

        builder.Services.AddTransient<DetailsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
