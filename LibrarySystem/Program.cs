using System;

namespace LibrarySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            var r1 = Library.CreateReader("name1", "id1", "drivers license", "test1@test.com", "425-2222222", "first reader account");
            var r2 = Library.CreateReader("name2", "id2", "passport", "test2.test.com", "206-1111111", "second reader account");

            Console.WriteLine($"Name:{r1.Name}, ID:{r1.ID},IDT:{r1.IDType}, EA:{r1.EmailAddress}, PN:{r1.PhoneNumber}, CD:{r1.CreatedDate}, TB:{r1.TotalOfBorrowed}");
            Console.WriteLine($"Name:{r2.Name}, ID:{r2.ID},IDT:{r2.IDType}, EA:{r2.EmailAddress}, PN:{r2.PhoneNumber}, CD:{r2.CreatedDate}, TB:{r2.TotalOfBorrowed}");
        }
    }
}
