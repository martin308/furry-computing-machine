using System;
using Xamarin.UITest;

namespace Tests
{
  public abstract class LoggedInScreen
  {
    protected IApp Application { get; set; }

    public ApplicationMenu ClickMenu ()
    {
      Application.Tap (q => q.Marked ("slideout"));

      return new ApplicationMenu (Application);
    }
  }
}

