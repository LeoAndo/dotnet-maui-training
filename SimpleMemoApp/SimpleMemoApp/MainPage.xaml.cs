using System.Diagnostics;

namespace SimpleMemoApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void BtnRead_Clicked(System.Object sender, System.EventArgs e)
    {
        Debug.WriteLine("Call BtnRead_Clicked");
    }

    void BtnSave_Clicked(System.Object sender, System.EventArgs e)
    {
        Debug.WriteLine("Call BtnSave_Clicked");
    }
}


