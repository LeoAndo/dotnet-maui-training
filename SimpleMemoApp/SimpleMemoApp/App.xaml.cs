using System.Diagnostics;

namespace SimpleMemoApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}

    protected override Window CreateWindow(IActivationState activationState)
    {
        Window window = base.CreateWindow(activationState);

        // Androidで例えると、
        window.Created += (s, e) =>
        {
            // OnPostCreate
            Debug.WriteLine("onCreate!");
        };

        window.Activated += (s, e) =>
        {
            // onResume
            Debug.WriteLine("Activated!");
        };
        window.Deactivated += (s, e) =>
        {
            // onPause
            Debug.WriteLine("Deactivated!");
        };
        window.Stopped += (s, e) =>
        {
            // onStop
            Debug.WriteLine("onStop!");
        };
        window.Resumed += (s, e) =>
        {
            // onReStart
            Debug.WriteLine("onReStart!");
        };
        window.Destroying += (s, e) =>
        {
            // onDestroy
            Debug.WriteLine("onDestroy!");
        };
        return window;
    }
}

