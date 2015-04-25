using System;
using Xamarin.UITest;

namespace Tests
{
  public class ApplicationMenu
  {
    private readonly IApp _app;

    public ApplicationMenu (IApp app)
    {
      _app = app;
    }

    public AccountsScreen NavigateToAccountsScreen ()
    {
      _app.Tap (q => q.Text ("Accounts"));

      return new AccountsScreen (_app);
    }

    public LeadsScreen NavigateToLeadsScreen ()
    {
      _app.Tap (q => q.Text ("Leads"));

      return new LeadsScreen (_app);
    }

    public ContactsScreen NavigateToContactsScreen ()
    {
      _app.Tap (q => q.Text ("Contacts"));

      return new ContactsScreen (_app);
    }
  }
}

