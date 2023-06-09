using PoradnikBezrobotnego.MVVM.ViewModels;
namespace PoradnikBezrobotnego.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	}

    private void Button_EmploymentAgency(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new EmploymentAgencyView());
    }
    private void Button_cvView(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new cvView());
    }
}