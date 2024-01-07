using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
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
        public override string ShowInfo()
        {
            return ($"{FirstName} {LastName} {Birthday} {NumberEITPoints} {NumberPointsEducationalDocument} " +
                $"{NameGeneralEducationInstitution}");
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
        public override string ShowInfo()
        {
            return ($"{FirstName} {LastName} {Birthday} {NumberEITPoints} {NumberPointsEducationalDocument} " +
                $"{NameGeneralEducationInstitution} {Course} {Group} {Faculty} {HigherEducationInstitution}");
        }
    }
}
