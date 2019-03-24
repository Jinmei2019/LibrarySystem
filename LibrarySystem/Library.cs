using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    static class Library
    {
        static public Reader CreateReader
            (string name, string id, string idType, string emailAddress, string phoneNumber, string notes)
        {
            var r1 = new Reader()
            {
                Name = name,
                ID = id,
                IDType = idType,
                EmailAddress = emailAddress,
                PhoneNumber = phoneNumber,
                Notes = notes
            };
            return r1;
        }
    }
}
