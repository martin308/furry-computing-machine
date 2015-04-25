using System;
using Xamarin.UITest;

namespace Tests
{
  public class CreateContactScreen : LoggedInScreen
  {
    public CreateContactScreen (IApp app)
    {
      Application = app;
    }

    public ContactsScreen SaveChanges ()
    {
      Application.Tap (q => q.Marked ("Save"));

      return new ContactsScreen (Application);
    }
  }
}

