using Android.App;
using Android.Runtime;

namespace FinecoBankMobile.Platforms.Android;

[Application(Icon = "@mipmap/logo", RoundIcon = "@mipmap/logo")]
public class MainApplication : MauiApplication
{
    public MainApplication(nint handle, JniHandleOwnership ownership)
        : base(handle, ownership)
    {
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}
