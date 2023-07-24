namespace Cozmo_And_Co;

public partial class NewPage1 : ContentPage
{
    string _fileName = Path.Combine(FileSystem.AppDataDirectory, "notes.txt");
    public NewPage1()
	{
		InitializeComponent();
		
	
	}
}