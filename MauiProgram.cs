using FinecoBankMobile.View;
using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

namespace FinecoBankMobile;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient <RegisterPage>();
		

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
