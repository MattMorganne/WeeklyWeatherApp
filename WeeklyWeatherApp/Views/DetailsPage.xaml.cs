 

namespace WeeklyWeatherApp.Views;

public partial class DetailsPage : ContentPage
{
	public DetailsPage()
	{
		InitializeComponent();
	}

    public string SelectedDay { get; internal set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();

        if (!string.IsNullOrEmpty(SelectedDay))
        {
            // Use the SelectedDay to display relevant data
            dayLabel.Text = SelectedDay;
        }
    }
}