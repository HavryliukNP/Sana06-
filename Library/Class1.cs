using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Person(string firstName, string lastName, DateTime birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }
        public virtual string ShowInfo()
        {
            return ($"{FirstName} {LastName} {Birthday}");
        }
    }
    public class Applicant : Person
    {
        public double NumberEITPoints { get; set; }
        public double NumberPointsEducationalDocument { get; set; }
        public string NameGeneralEducationInstitution { get; set; }

        public Applicant(double numberEITPoints, double numberPointsEducationalDocument,
            string nameGeneralEducationInstitution, string firstName, string lastName, DateTime birthday)
            : base(firstName, lastName, birthday)
        {
            NumberEITPoints = numberEITPoints;
            NumberPointsEducationalDocument = numberPointsEducationalDocument;
            NameGeneralEducationInstitution = nameGeneralEducationInstitution;
        }
    }
    public class Student : Applicant
    {
        public int Course { get; set; }
        public string Group { get; set; }
        public string Faculty { get; set; }
        public string HigherEducationInstitution { get; set; }

        public Student(int course, string group, string faculty, string higherEducationInstitution,
            double numberEITPoints, double numberPointsEducationalDocument, string nameGeneralEducationInstitution,
            string firstName, string lastName, DateTime birthday) : base
            (numberEITPoints, numberPointsEducationalDocument, nameGeneralEducationInstitution, firstName, lastName, birthday)
        {
            Course = course;
            Group = group;
            Faculty = faculty;
            HigherEducationInstitution = higherEducationInstitution;
        }
    }
    public class Teacher : Person
    {
        public string Position { get; set; }
        public string Department { get; set; }
        public string HigherEducationInstitution { get; set; }

        public Teacher(string position, string department, string higherEducationInstitution,
            string firstName, string lastName, DateTime birthday)
        : base(firstName, lastName, birthday)
        {
            Position = position;
            Department = department;
            HigherEducationInstitution = higherEducationInstitution;
        }
    }
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
    }
}
