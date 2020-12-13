using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IRF_Project_DCWC5L.Entities
{
    public class RecipientManager : IRecipientManager
    {
        public BindingList<Recipient> Recipients { get; } = new BindingList<Recipient>();

        public Recipient CreateRecipient(Recipient recipient)
        {
            var existingRecipient = (from r in Recipients
                              where r.Email.Equals(recipient.Email)
                              select r).FirstOrDefault();

            if (existingRecipient != null)
                throw new ApplicationException(
                    "Már létezik felhasználó ilyen iTunes fiókkal!");

            Recipients.Add(recipient);

            return recipient;
        }
    }
}
