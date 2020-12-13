using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_DCWC5L.Entities
{
    public interface IRecipientManager
    {
        BindingList<Recipient> Recipients { get; }

        Recipient CreateRecipient(Recipient recipient);
    }
}
