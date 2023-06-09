namespace PoradnikBezrobotnego.MVVM.Views;

public partial class EmploymentAgencyView : ContentPage
{
    


    public EmploymentAgencyView()
    {
        InitializeComponent();
        
    }
    private void Button_RegisterView(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new RegistrationView());
    }


}