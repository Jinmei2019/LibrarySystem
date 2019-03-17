using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class Reader
    {
        #region properties

        public int AccountNumber { get; set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string IDType { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate{ get; set; }
        public int TotalOfBorrowed { get; set; }
        public decimal Fine { get; set; }
        public string Notes { get; set; }

        #endregion

        #region Methods

        public int BorrowBook (int BookID)
        {
            TotalOfBorrowed += 1;
        }

        public int ReturnBook (int BookID)
        {
            TotalOfBorrowed -= 1;
        }

        #endregion
    }
}
