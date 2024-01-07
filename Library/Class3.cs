using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class LibraryUser : Person
    {
        public string LibraryCardNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public int AmountMonthlySubscriptionFee { get; set; }

        public LibraryUser(string libraryCardNumber, DateTime issueDate, int amountMonthlySubscriptionFee,
            string firstName, string lastName, DateTime birthday)
        : base(firstName, lastName, birthday)
        {
            LibraryCardNumber = libraryCardNumber;
            IssueDate = issueDate;
            AmountMonthlySubscriptionFee = amountMonthlySubscriptionFee;
        }
        public override string ShowInfo()
        {
            return ($"{FirstName} {LastName} {Birthday} {LibraryCardNumber} {IssueDate} {AmountMonthlySubscriptionFee}");
        }
    }
}
