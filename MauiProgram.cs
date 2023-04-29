using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui;
using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;
using Bibliotech0.Data;
using Bibliotech0.Services;
using Bibliotech0.Database;
<<<<<<< Updated upstream
using SQLite;
=======
using Bibliotech0.Interface;
using SQLite;
using System.IO;
using Microsoft.Extensions.Logging;
>>>>>>> Stashed changes

namespace Bibliotech0
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
				});

<<<<<<< Updated upstream

#if DEBUG
        builder.Services.AddBlazorWebViewDeveloperTools();
		builder.Logging.AddDebug();
        builder.Services.AddSingleton<FindBookService>();
#endif
        // Add the path to your SQLite database here
        var databasePath = Path.Combine(new DirectoryInfo(AppContext.BaseDirectory).Parent.Parent.Parent.Parent.Parent.FullName, "Database", "LibraryDatabase.db");
        var db = new SQLiteAsyncConnection(databasePath);
        builder.Services.AddSingleton(db);

<<<<<<< HEAD
<<<<<<< Updated upstream
=======
		//builder.Services.AddSingleton<WeatherForecastService>();

>>>>>>> 6a19cba319f8dfdb174b43832bf319ec976a00a6
		return builder.Build();
=======
        return builder.Build();
>>>>>>> Stashed changes
=======
			builder.Services.AddBlazorWebView();
#if DEBUG
			builder.Services.AddBlazorWebViewDeveloperTools();
			builder.Logging.AddDebug();
			builder.Services.AddSingleton<FindBookService>();
#endif
			// Add the path to your SQLite database here
			var databasePath = Path.Combine(new DirectoryInfo(AppContext.BaseDirectory).Parent.Parent.Parent.Parent.Parent.FullName, "Database", "LibraryDatabase.db");
			var db = new SQLiteAsyncConnection(databasePath);
			builder.Services.AddSingleton(db);

			builder.Services.AddMauiBlazorWebView();
			builder.Services.AddSingleton<IBookService, BookService>();
			return builder.Build();
		}
>>>>>>> Stashed changes
	}
}
