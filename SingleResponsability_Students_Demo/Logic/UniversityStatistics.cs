using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Students_Demo.Logic
{
    public class UniversityStatistics
    {
        University university;

        public UniversityStatistics(University university)
        {
            this.university = university;
        }

        #region Statistics

        public double MinAdmissionMark
        {
            get { return university.Students.Min(student => student.AdmissionMark); }
        }

        public double MaxAdmissionMark
        {
            get { return university.Students.Max(student => student.AdmissionMark); }
        }

        #endregion
    }
}
