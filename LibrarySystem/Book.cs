using System;
using System.Collections.Generic;
using System.Text;

namespace LibrarySystem
{
    class Book
    {
        public int BookID { get; private set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string BookName { get; set; }
        public string Publisher { get; set; }
        public DateTime PublicationDate { get; set; }
        public string Introduction { get; set; }
    }
}
    