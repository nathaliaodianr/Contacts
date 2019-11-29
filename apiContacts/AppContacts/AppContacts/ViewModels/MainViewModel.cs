namespace AppContacts.ViewModels
{
    using AppContacts.Models;
    using System.Collections.Generic;
    public class MainViewModel
    {
        #region Properties
        public List<Contacts> ListContacts { get; set; }
        #endregion

        #region ViewModels
        public ContactsViewModel contactsViewModel { get; set; }
        #endregion

        #region Constructor
        public MainViewModel()
        {
            instance = this;
            contactsViewModel = new ContactsViewModel();
        } 
        #endregion

        #region Singleton
        private static MainViewModel instance;
        public static MainViewModel GetInstance()
        {
           if (instance == null)
            {
                instance = new MainViewModel();
            }
            return (instance);
        }
        #endregion
    }
}
