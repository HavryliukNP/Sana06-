using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
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
        public override string ShowInfo()
        {
            return ($"{FirstName} {LastName} {Birthday} {Position} {Department} {HigherEducationInstitution}");
        }
    }
}
