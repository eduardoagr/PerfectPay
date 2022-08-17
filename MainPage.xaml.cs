using Syncfusion.Maui.Sliders;

namespace PerfectPay;

public partial class MainPage : ContentPage
{
    decimal bill;
    int NumberaPeople = 1;
    int tip;

    public MainPage()
    {
        InitializeComponent();
        TotalBillContaner.IsVisible = false;
    }

    private void Add_Remove_Clicked(object sender, EventArgs e)
    {

    }

    private void Percentage_Button_clicked(object sender, EventArgs e)
    {

    }

    private void Entrybill_Completed(object sender, EventArgs e)
    {
        if (decimal.TryParse(entrybill.Text, out var val))
        {
            bill = val;
        }
        CalculateTotlal();
    }

    private void CalculateTotlal()
    {
    }

    private void PercentageSlider_ValueChanged(object sender, SliderValueChangedEventArgs e)
    {
        // if I assign the value here, I get the error
    }
}

