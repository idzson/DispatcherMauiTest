namespace MauiDispatcherTest;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        Dispatcher.Dispatch(() =>
        {
            MainPage = new AppShell();
        });
        // MainThread.BeginInvokeOnMainThread(() =>
        // {
        //     MainPage = new AppShell();
        //});
    }
}