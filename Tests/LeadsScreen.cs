using System;
using System.Linq;
using Xamarin.UITest;

namespace Tests
{
  public class LeadsScreen : LoggedInScreen
  {
    public LeadsScreen (IApp app)
    {
      Application = app;
    }

    public bool IsValid ()
    {
      // more things that this screen should display
      return Application.Query (q => q.Id("Leads")).Count() == 1;
    }
  }
}

