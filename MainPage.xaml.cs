using System.Diagnostics;

namespace Cozmo_And_Co;

public partial class MainPage : ContentPage
{
	float thingymabob = 0f;

	public MainPage()
	{
		InitializeComponent();
	}
	public void Onclicky()
	{
		thingymabob += 1f;

	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        thingymabob += 1f;
		Console.WriteLine(thingymabob);
		Debug.WriteLine(thingymabob);
    }
}

