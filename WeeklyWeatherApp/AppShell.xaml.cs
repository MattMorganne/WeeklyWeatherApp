using WeeklyWeatherApp.Views;

namespace WeeklyWeatherApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailsPage), typeof(DetailsPage));
	}
}
