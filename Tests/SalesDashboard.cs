using System;
using Xamarin.UITest;
using System.Linq;

namespace Tests
{
  public class SalesDashboard : LoggedInScreen
  {
    public SalesDashboard(IApp app)
    {
      Application = app;
    }

    public bool IsValid ()
    {
      // more things that this screen should display
      return Application.Query (q => q.Id ("Sales Dashboard")).Count() == 1;
    }
  }
}

