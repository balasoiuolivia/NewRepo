using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsability_Students_Demo.Logic
{
    public class UniversityToFile
    {
        public void SaveStudentsToFile(University university, string fullFilePath)
        {
            using (var writer = new StreamWriter(fullFilePath))
            {
                foreach (var s in university.Students)
                {
                    writer.WriteLine($"{s.Id},{s.FirstName},{s.LastName},{s.AdmissionMark.ToString(CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
