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
        Memo memo = MemoHolder.Current.Memo;
        Date.Date = memo.Date;
        Subject.Text = memo.Subject;
        Text.Text = memo.Text;
    }

    void BtnSave_Clicked(System.Object sender, System.EventArgs e)
    {
        Debug.WriteLine("Call BtnSave_Clicked");
        MemoHolder.Current.Memo = new Memo()
        {
            Date = Date.Date,
            Subject = Subject.Text,
            Text = Text.Text,
        };
    }
}


