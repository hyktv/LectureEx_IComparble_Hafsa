using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureEx_IComparble_Hafsa
{
    internal class Student
    {
        //feilds
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;
        Random random = new Random();
        
        //constructor
        public Student(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = random.NextDouble() * 100;
            _genEdGrade = random.NextDouble() * 100;
        }

        //properties 
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public double CSIGrade
        {
            get { return _csiGrade; }
            set { _csiGrade = value; }
        }

        public double GenEdGrade
        {
            get { return _genEdGrade; }
            set { _genEdGrade = value; }
        }

        //method
        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName}, CSI Grade: {_csiGrade}, Gen Ed Grade: {_genEdGrade}";
        }

    }
}
