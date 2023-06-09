using Mopups.Services;

namespace PoradnikBezrobotnego.MVVM.Views;

public partial class SearchJobView : ContentPage
{

    List<string> instruction = new List<string>();


    public SearchJobView()
	{
		InitializeComponent();
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
        jobStartlbl.Text = instruction[35];
        jobMidlbl.Text = instruction[36];
        jobEndlbl.Text = instruction[37];
        
    }

    

}