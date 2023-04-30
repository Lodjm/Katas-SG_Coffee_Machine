using Coffee_Machine_MenuDisplay.Contracts;
using Coffee_Machine_MenuDisplay.Models;

namespace Coffee_Machine_Menu.DataAccess
{
    public class RecipientRepository : BaseRepository, IRecipientRepository
    {
        public RecipientRepository() : base("Recipients.json", "_data")
        {
        }

        public IEnumerable<Recipient> GetRecipients()
        {
            return GetData<Recipient>();
        }
    }
}
