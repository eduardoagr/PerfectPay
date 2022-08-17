

using Syncfusion.Licensing;

namespace PerfectPay;

public partial class App : Application
{
    const string KEY = "Njk5MjAxQDMyMzAyZTMyMmUzMEgzd2U2UnN5VEFtS0tLOUIwR25vTFpQTTZPS2IwZStKSkRLTXR4dVZ3cFk9";
    public App()
    {
        SyncfusionLicenseProvider.RegisterLicense(KEY);
        InitializeComponent();

        MainPage = new MainPage();
    }
}
