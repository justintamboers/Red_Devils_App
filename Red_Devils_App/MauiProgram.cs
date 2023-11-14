using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using Red_Devils_App.Repository;
using Red_Devils_App.Services;
using Red_Devils_App.VieuwModels;
using Red_Devils_App.Vieuws;
using SQLite;

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
		builder.Services.AddTransient<PlayerPage>();
		builder.Services.AddTransient<TeamPage>();
		builder.Services.AddTransient<PlayerViewModel>();

        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginViewModel>();

        builder.Services.AddSingleton<INavigationService, MauiNavigationService>();
		builder.Services.AddSingleton<IDialogService, MauiDialogServices>();
		builder.Services.AddSingleton<ILocalStorageService, LocalStorageService>();
		builder.Services.AddSingleton<IPlayerRepository, PlayerDbRepo>();

		var connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.Current.AppDataDirectory, "devils.db3"));
		builder.Services.AddSingleton<SQLiteAsyncConnection>(connection);

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
