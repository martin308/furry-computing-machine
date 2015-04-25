using System;
using Xamarin.UITest;

namespace Tests
{
  public class iOSCRMApplication
  {
    private readonly IApp _app;

    public iOSCRMApplication ()
    {
      _app = ConfigureApp.iOS.AppBundle("../../../MobileCRM.app").StartApp ();
    }

    public LoginScreen Launch ()
    {
      return new LoginScreen (_app);
    }

    public IApp Application { get { return _app; } }
  }
}

