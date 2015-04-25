using System;
using NUnit.Framework;

namespace Tests
{
  [TestFixture]
  public class While_Navigating_The_Application
  {
    [Test]
    [Ignore]
    public void Repl ()
    {
      var application = new iOSCRMApplication ();

      application.Application.Repl ();
    }

    [Test]
    [Ignore]
    public void The_Sales_Dashboard_Is_The_First_Screen_Shown ()
    {
      var application = new iOSCRMApplication ();

      var loginScreen = application.Launch();

      var dashboard = loginScreen.Login ();

      Assert.True (dashboard.IsValid ());
    }

    [Test]
    [Ignore]
    public void From_The_Sales_Dashboard_Navigating_To_The_Accounts_Screen_Is_Successful ()
    {
      var application = new iOSCRMApplication ();

      var loginScreen = application.Launch();

      var dashboard = loginScreen.Login ();

      var menu = dashboard.ClickMenu ();

      var accountsScreen = menu.NavigateToAccountsScreen ();

      Assert.True (accountsScreen.IsValid ());
    }

    [Test]
    [Ignore]
    public void From_The_Sales_Dashboard_Navigating_To_The_Leads_Screen_Is_Successful ()
    {
      var application = new iOSCRMApplication ();

      var loginScreen = application.Launch();

      var dashboard = loginScreen.Login ();

      var menu = dashboard.ClickMenu ();

      var leadsScreen = menu.NavigateToLeadsScreen ();

      Assert.True (leadsScreen.IsValid ());
    }

    [Test]
    [Ignore]
    public void From_The_Sales_Dashboard_Navigating_To_The_Contacts_Screen_Is_Successful ()
    {
      var application = new iOSCRMApplication ();

      var loginScreen = application.Launch();

      var dashboard = loginScreen.Login ();

      var menu = dashboard.ClickMenu ();

      var contactsScreen = menu.NavigateToContactsScreen ();

      Assert.True (contactsScreen.IsValid ());
    }
  }

  [TestFixture]
  public class When_Editing_Contacts
  {
    private ContactsScreen _contactsScreen;

    [Test]
    [Ignore("Incomplete")]
    public void Cannot_Create_An_Empty_Contact ()
    {
      var application = new iOSCRMApplication ();

      var loginScreen = application.Launch();

      var dashboard = loginScreen.Login ();

      var menu = dashboard.ClickMenu ();

      _contactsScreen = menu.NavigateToContactsScreen ();

      var numberOfContacts = _contactsScreen.NumberOfContacts ();

      var createContactScreen = _contactsScreen.CreateNewContact ();

      createContactScreen.SaveChanges ();

      var newNumberOfContacts = _contactsScreen.NumberOfContacts ();

      // no new contact should be added to the list as all the fields are empty
      Assert.That (numberOfContacts, Is.EqualTo (newNumberOfContacts));
    }
  }
}

