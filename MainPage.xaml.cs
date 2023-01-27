namespace OPC__Inlämningsuppgift_3;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		counter.Text = $"{count}";

		SemanticScreenReader.Announce(counter.Text);
	}
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        count--;

        counter.Text = $"{count}";

        SemanticScreenReader.Announce(counter.Text);
    }
}

