using Coffee_Machine_MenuDisplay.Models;

namespace Coffee_Machine_MenuDisplay.Contracts
{
    public interface IRecipientRepository
    {
        IEnumerable<Recipient> GetRecipients();
    }
}
