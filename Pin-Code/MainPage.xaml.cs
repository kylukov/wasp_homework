namespace wasp1;

public partial class MainPage : ContentPage
{
	private string _pass;
	private string _password = "1237";
	public MainPage()
	{
		InitializeComponent();
	}
	private void DigitClicked(object sender, EventArgs e)
	{
		_pass += (sender as Button).Text;
		DisplayLabel.Text += "*";
	}
	private void DelClicked(object sender, EventArgs e)
	{
		_pass = _pass.Substring(0, _pass.Length - 1);
		DisplayLabel.Text = new string('*', _pass.Length);
	}
    private void DoneClicked(object sender, EventArgs e)
	{
		if (_pass == _password)
		{
			DisplayLabel.Text = "TRUE";

		}
		else
		{
			DisplayLabel.Text = "FALSE";
			_pass = " ";
		}
	}
}


