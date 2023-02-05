using Microsoft.Extensions.Configuration;
using SalaryConverter.API.Interfaces;
using SalaryConverter.API.Models;
using SalaryConverter.API.Services;

namespace SalaryCalculator_;

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

        SetupConfiguration(builder);
        ConfigureServices(builder);

		return builder.Build();
	}

    private static void SetupConfiguration(MauiAppBuilder builder)
    {
        var config = new ConfigurationBuilder()
                    .AddJsonFile("appsettings.json")
                    .Build();

        builder.Configuration.AddConfiguration(config);
    }

    private static void ConfigureServices(MauiAppBuilder builder)
    {
        var settingsApi = new SettingsAPI();
        builder.Configuration.GetSection(nameof(SettingsAPI)).Bind(settingsApi);

        builder.Services.AddTransient<MainPage>();
        builder.Services.AddTransient<IAlfaBankApiService, AlfaBankApiService>();
    }
}
