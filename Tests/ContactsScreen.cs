using System;
using System.Linq;
using Xamarin.UITest;

namespace Tests
{
  public class ContactsScreen : LoggedInScreen
  {
    public ContactsScreen (IApp app)
    {
      Application = app;
    }

    public bool IsValid ()
    {
      // more things that this screen should display
      return Application.Query (q => q.Id("Contacts")).Count() == 1;
    }

    public int NumberOfContacts ()
    {
      return Application.Query (q => q.Class ("Xamarin_Forms_Platform_iOS_CellTableViewCell")).Count ();
    }

    public CreateContactScreen CreateNewContact ()
    {
      Application.Tap (q => q.Marked ("Add"));

      return new CreateContactScreen (Application);
    }
  }
}

