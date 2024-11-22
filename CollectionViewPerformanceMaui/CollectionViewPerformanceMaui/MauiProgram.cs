using CollectionViewPerformanceMaui.Services;
using CollectionViewPerformanceMaui.ViewModels;
using CollectionViewPerformanceMaui.Views;

#if ANDROID
using CollectionViewPerformanceMaui.Controls;
using CollectionViewPerformanceMaui.Platforms.Android.Handlers;
#endif

namespace CollectionViewPerformanceMaui
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
					fonts.AddFont("FontAwesomeBrands.otf", "FA-B");
                })
				.ConfigureMauiHandlers(handlers =>
				{
#if ANDROID
					handlers.AddHandler<Card, CardHandler>();

					CardHandler.SetupMapper();
#endif
                })
				.RegisterServices()
				.RegisterViewModels()
				.RegisterViews();

			return builder.Build();
		}

		public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
		{
			mauiAppBuilder.Services.AddSingleton<IDataService, DataService>();

			return mauiAppBuilder;
		}

		public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
		{
			mauiAppBuilder.Services.AddSingleton<DataViewModel>();

			return mauiAppBuilder;
		}

		public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
		{
			mauiAppBuilder.Services.AddSingleton<DataView>();

			return mauiAppBuilder;
		}
    }
}
