using Microsoft.Extensions.Logging;
using Bibliotech0.Data;
using Bibliotech0.Services;
using Bibliotech0.Database;
using SQLite;

namespace Bibliotech0;

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
			});

		builder.Services.AddMauiBlazorWebView();


#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
        builder.Services.AddSingleton<FindBookService>();
#endif
        // Add the path to your SQLite database here
        var databasePath = Path.Combine(new DirectoryInfo(AppContext.BaseDirectory).Parent.Parent.Parent.Parent.Parent.FullName, "Database", "LibraryDatabase.db");
        var db = new SQLiteAsyncConnection(databasePath);
        builder.Services.AddSingleton(db);

		return builder.Build();

	}
}
