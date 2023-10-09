using LocalHymns.Data;

namespace LocalHymns;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new MainPage();
	}
	protected override async void OnStart()
	{
        await Database.Initialize();
        base.OnStart();
	}
}
