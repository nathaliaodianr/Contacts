using System.Data.Entity;
namespace apiContacts.Models
{
    public class DataContext: DbContext
    {
        public DataContext(): base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiContacts.Models.Contacts> Contacts { get; set; }
    }
}