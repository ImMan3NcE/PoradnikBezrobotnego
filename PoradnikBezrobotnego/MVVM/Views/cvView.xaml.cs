

using Mopups.Services;
using System.Windows.Input;

namespace PoradnikBezrobotnego.MVVM.Views;

public partial class cvView : ContentPage
{
    

    List<string> instruction = new List<string>();
    public cvView()
	{
		InitializeComponent();
        BindingContext = this;
	}

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
        cvInformations();

    }

    async Task LoadMauiAsset()
    {
        using var stream = await FileSystem.OpenAppPackageFileAsync("instrukcjarejestracji.txt");
        using var reader = new StreamReader(stream);

        while (reader.Peek() != -1)
        {
            instruction.Add(reader.ReadLine());

        }

    }

    public void cvInformations()
	{
        cvStartTip.Text = instruction[29];
        cvMidTip.Text = instruction[30];
        cvEndTip.Text = instruction[31];
        cvCreatorslbl.Text = instruction[32];
    }

    private void btnExCVPopUp_Clicked(object sender, EventArgs e)
    {
        MopupService.Instance.PushAsync(new CVPopupView());
    }
}