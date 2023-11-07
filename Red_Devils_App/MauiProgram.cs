using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Red_Devils_App.Repository;
using Red_Devils_App.Services;
using Red_Devils_App.VieuwModels;
using Red_Devils_App.Vieuws;

namespace Red_Devils_App;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        builder.UseMauiCommunityToolkit();
        builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.Services.AddSingleton<TeamViewModel>();
		builder.Services.AddSingleton<IPlayerRepo, PlayerFakeRepo>();
		builder.Services.AddTransient<PlayerPage>();
		builder.Services.AddTransient<TeamPage>();
		builder.Services.AddTransient<PlayerViewModel>();
		builder.Services.AddSingleton<INavigationService, MauiNavigationService>();
		builder.Services.AddSingleton<IDialogService, MauiDialogServices>();
#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
