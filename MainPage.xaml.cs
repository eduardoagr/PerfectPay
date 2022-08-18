using System.Diagnostics;

using Syncfusion.Maui.Sliders;

namespace PerfectPay;

public partial class MainPage : ContentPage
{
    decimal bill;
    private int NumberPeople = 1;
    int tip;

    public MainPage()
    {
        InitializeComponent();
    }

    private void Add_Remove_Clicked(object sender, EventArgs e)
    {
        if (sender is Button)
        {
            var bton = sender as Button;
            switch (bton.Text)
            {
                case "-":
                    if (NumberPeople > 1)
                    {
                        NumberPeople--;
                    }
                    lblNumberPerson.Text = NumberPeople.ToString();
                    CalculateTotlal();
                    break;
                case "+":
                    NumberPeople++;
                    lblNumberPerson.Text = NumberPeople.ToString();
                    CalculateTotlal();
                    break;
                default:
                    Debug.WriteLine("This should never happen");
                    break;
            }
        }
    }

    private void Percentage_Button_clicked(object sender, EventArgs e)
    {
        if (sender is Button)
        {
            var btn = sender as Button;
            var percentage = int.Parse(btn.Text.Replace("%", " "));
            PercentageSlider.Value = percentage;
        }

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
        //Total tip
        var totaltip = (bill * tip) / 100;

        //Tip per person
        var tipPerson = (totaltip / NumberPeople);
        lblTip.Text = $"{tipPerson:C}";

        //Subtotal
        var subtotal = (bill / NumberPeople);
        lblSub.Text = $"{subtotal:C}";

        var total = (bill + totaltip) / NumberPeople;
        lblBill.Text = $"{total:C}";
    }

    private void PercentageSlider_ValueChanged(object sender, SliderValueChangedEventArgs e)
    {
        var slider = (SfSlider)sender;
        tip = (int)slider.Value;
        CalculateTotlal();
    }
}

