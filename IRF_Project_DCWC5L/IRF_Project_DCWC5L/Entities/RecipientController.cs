using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IRF_Project_DCWC5L.Entities
{
    public class RecipientController
    {
        public IRecipientManager RecipientManager { get; set; }

        public RecipientController()
        {
            RecipientManager = new RecipientManager();
        }

        public Recipient Register(string fullname, string shortname, string email)
        {
            if (!ValidateFullName(fullname))
                throw new ValidationException(
                    "A megadott teljes név nem megfelelő! (Ne használj ékezeteket! A keresztnév és a vezetéknév is nagy betűvel kezdődjön, és legyen közöttük szóköz!)");

            if (!ValidateShortName(shortname))
                throw new ValidationException(
                    "A megadott becenév nem megfelelő! (Kérlek, ne használj ékezeteket, csak az angol ABC beűtit! A becenév egyetlen rövid szóból állhat!)");


            if (!ValidateEmail(email))
                throw new ValidationException(
                    "A megadott account nem megfelelő! (Kérlek, valid e-mail címet használj!)");

            var recipient = new Recipient()
            {
                TeljesNev = fullname,
                BeceNev = shortname,
                Email = email,

            };

            var newRecipient = RecipientManager.CreateRecipient(recipient);

            return newRecipient;

        }
        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(
                email,
                @"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
        }

        public bool ValidateFullName(string fullname)
        {
            return Regex.IsMatch(
                fullname, @"^[A-Z][a-z]{3,}\s[A-Z][a-z]{3,}$");
        }

        public bool ValidateShortName(string shortname)
        {
            return Regex.IsMatch(
                shortname, @"^[a-zA-Z]{3,}$");
        }
    }
}
