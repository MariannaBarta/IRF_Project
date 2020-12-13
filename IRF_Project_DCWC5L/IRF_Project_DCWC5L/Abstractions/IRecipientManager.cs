using System.ComponentModel;

namespace IRF_Project_DCWC5L.Entities
{
    public interface IRecipientManager
    {
        BindingList<Recipient> Recipients { get; }

        Recipient CreateRecipient(Recipient recipient);
    }
}
