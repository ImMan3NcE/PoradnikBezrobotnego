

using Mopups.Services;

namespace PoradnikBezrobotnego.MVVM.Views;

public partial class CVPopupView 
{
	public CVPopupView()
	{
		InitializeComponent();
	}

    private void ButtonClose_Clicked(object sender, EventArgs e)
    {
		MopupService.Instance.PopAsync();
    }
}