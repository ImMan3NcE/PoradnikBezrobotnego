namespace PoradnikBezrobotnego.MVVM.Views;

public partial class RegistrationView : ContentPage
{
    List<string> instruction = new List<string>();

    int option = 0;
    int stepInstr = 0;


    public RegistrationView()
    {
        InitializeComponent();
        StepOfInstr(0);
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await LoadMauiAsset();
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

    private void Button_OnlineRegistration(object sender, TappedEventArgs e)
    {
        option = 1;
        StepOfInstr(0);
        btnPrevious.IsVisible = false;
        btnNext.IsVisible = true;
        stepInstr = 0;
        gridRegOnl.BackgroundColor = Colors.Wheat;
        gridReg.BackgroundColor = Colors.Beige;
    }
    private void Button_OnsiteRegistration(object sender, TappedEventArgs e)
    {
        option = 2;
        StepOfInstr(19);
        btnPrevious.IsVisible = false;
        btnNext.IsVisible = true;
        stepInstr = 19;
        gridRegOnl.BackgroundColor = Colors.Beige;
        gridReg.BackgroundColor = Colors.Wheat;
    }

    public void StepOfInstr(int counter)
    {
        //rejestracja online
        if (option == 1)
        {

            instrucionlbl.Text = instruction[counter];

        }
        // rejestracja w urzêdzie pracy na miejscu
        else if (option == 2)
        {
            instrucionlbl.Text = instruction[counter];
        }
        else
        {
            instrucionlbl.Text = "Wybierz rejestracje Online lub w Urzêdzie Pracy";
        }



    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (option == 1)
        {

            if (sender is Button button && button == btnNext)
            {
                stepInstr++;
            }
            else if (sender is Button button2 && button2 == btnPrevious)
            {
                stepInstr--;
            }

            if (stepInstr > 0)
            {
                btnPrevious.IsVisible = true;
            }
            else
            {
                btnPrevious.IsVisible = false;
            }

            if (stepInstr == 16) { stepInstr = 0; }
            StepOfInstr(stepInstr);
        }
        else if (option == 2)
        {

            if (sender is Button button && button == btnNext)
            {
                stepInstr++;
            }
            else if (sender is Button button2 && button2 == btnPrevious)
            {
                stepInstr--;
            }

            if (stepInstr > 19)
            {
                btnPrevious.IsVisible = true;
            }
            else if (stepInstr > 6 && stepInstr < 17)
            {
                btnPrevious.IsVisible = true;
            }
            else
            {
                btnPrevious.IsVisible = false;
            }

            if (stepInstr == 26)
            {

                stepInstr = 6;

            }
            else if (stepInstr == 17)
            {
                stepInstr = 19;
            }
            StepOfInstr(stepInstr);
        }
    }
}