using PoradnikBezrobotnego.MVVM.Views;

namespace PoradnikBezrobotnego;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage( new MenuView());
	}
}
