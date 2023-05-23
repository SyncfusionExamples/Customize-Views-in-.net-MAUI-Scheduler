namespace Maui_Scheduler;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MDAxQDMyMzEyZTMxMmUzMjM0RlRxZ0NURG8wT3NPRkNhbDQ1RE1aRERTWlVqTzFZOXZISGNUWnBDK2J4VT0=");
        MainPage = new AppShell();
	}
}
