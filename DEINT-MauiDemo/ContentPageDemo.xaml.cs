namespace DEINT_MauiDemo;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

	private void btn_Clicked(object sender, EventArgs e)
	{
		DisplayAlert("Pulsa btn", "Has pulsado el btn", "OK");
	}

	private void RadioButton_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		
	}

	private void SwipeItem_Invoked(object sender, EventArgs e)
	{

	}

	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{

	}

	private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		//lblStepper.Text = stepper.Value.ToString();
	}

	private void Entry_Completed(object sender, EventArgs e)
	{

	}
}