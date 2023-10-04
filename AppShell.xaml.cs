using FinecoBankMobile.View;

namespace FinecoBankMobile;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
		Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		Routing.RegisterRoute(nameof(OperationsPage), typeof(OperationsPage));
		Routing.RegisterRoute(nameof(RechargePage), typeof(RechargePage));
		Routing.RegisterRoute(nameof(TransferPage), typeof(TransferPage));
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));
	}
}
