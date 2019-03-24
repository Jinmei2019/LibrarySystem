using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class Reader
    {
        #region static viarables
        private int lastAccountNumber=0;
    
        #endregion

        #region properties

        public int AccountNumber { get; private set; }
        public string Name { get; set; }
        public string ID { get; set; }
        public string IDType { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime CreatedDate{ get; private set; }
        public int TotalOfBorrowed { get;private set; }
        public decimal Fine { get;private set; }
        public string Notes { get; set; }

        #endregion
        #region constructor
        public Reader()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }
        #endregion

        #region Methods

        public void BorrowBook (int BookID)
        {
            TotalOfBorrowed += 1;
        }

        public void ReturnBook (int BookID)
        {
            TotalOfBorrowed -= 1;
        }

        #endregion
    }
}
