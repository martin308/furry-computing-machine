using System;
using System.Linq;
using Xamarin.UITest;

namespace Tests
{
  public class AccountsScreen : LoggedInScreen
  {
    public AccountsScreen (IApp app)
    {
      Application = app;
    }

    public bool IsValid ()
    {
      // more things that this screen should display
      return Application.Query (q => q.Id("Accounts")).Count() == 1;
    }
  }
}

