using System;
using Xamarin.UITest;
using System.Linq;

namespace Tests
{
  public class LoginScreen
  {
    private readonly IApp _app;

    public LoginScreen(IApp app)
    {
      _app = app;
    }

    public SalesDashboard Login()
    {
      _app.Tap (c => c.Marked ("Login"));

      _app.WaitForElement (c => c.Css ("#cred_userid_inputtext"));

      var previouslyLoggedIn = _app.Query (q => q.Css ("#sally_xamcrm_onmicrosoft_com_link")).Any();

      if (previouslyLoggedIn) {
        _app.Tap (q => q.Css ("#sally_xamcrm_onmicrosoft_com_link")); 
      } else {
        _app.Tap (c => c.Css ("#cred_userid_inputtext"));

        _app.EnterText ("sally@xamcrm.onmicrosoft.com");
      }

      _app.Tap (c => c.Css ("#cred_password_inputtext"));

      _app.EnterText ("P@ssword");

      _app.PressEnter ();

      _app.WaitForElement (q => q.Id ("Sales Dashboard"));

      return new SalesDashboard (_app);
    }
  }
}

