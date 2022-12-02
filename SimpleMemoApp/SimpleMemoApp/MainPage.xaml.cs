using System.Diagnostics;

namespace SimpleMemoApp;

public partial class MainPage : ContentPage
{
    private static string KEY_DATE = "pref_date";
    private static string KEY_SUBJECT = "pref_subject";
    private static string KEY_TEXT = "pref_text";

    public MainPage()
	{
		InitializeComponent();
	}

    void BtnRead_Clicked(System.Object sender, System.EventArgs e)
    {
        Debug.WriteLine("Call BtnRead_Clicked");
        /*
        Memo memo = MemoHolder.Current.Memo;
        Date.Date = memo.Date;
        Subject.Text = memo.Subject;
        Text.Text = memo.Text;
        */
        DateTime date = Preferences.Default.Get(KEY_DATE, DateTime.Now);
        string subject = Preferences.Default.Get(KEY_SUBJECT, "");
        string text = Preferences.Default.Get(KEY_TEXT, "");
        Date.Date = date;
        Subject.Text = subject;
        Text.Text = text;
    }

    void BtnSave_Clicked(System.Object sender, System.EventArgs e)
    {
        Debug.WriteLine("Call BtnSave_Clicked");
        /*
        MemoHolder.Current.Memo = new Memo()
        {
            Date = Date.Date,
            Subject = Subject.Text,
            Text = Text.Text,
        };
        */
        Preferences.Default.Set(KEY_DATE, Date.Date);
        Preferences.Default.Set(KEY_SUBJECT, Subject.Text);
        Preferences.Default.Set(KEY_TEXT, Text.Text);
    }
}


