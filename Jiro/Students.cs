using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiro
{
    class Students : IUniversity
    {
        public void LessonWork()
        {
            Console.WriteLine("All lesson for student in this course : ");
            string allLessonForStudent = File.ReadAllText("allLesson.txt");
            Console.WriteLine(allLessonForStudent);
        }

        public void TeacherWork()
        {
            Console.WriteLine();
            Console.WriteLine("Student's teacher information : ");
            string StudentTeacher = File.ReadAllText("Teacher.txt");
            Console.WriteLine(StudentTeacher);
        }

        public void StudentWork()
        {
            string name = "Mohammad";
            string lastName = "Jahanbakhsh";
            string fullName = name + " " + lastName;
            Console.WriteLine(fullName);
            Int64 nationalCode = 3721040996;
            Int64 studentNumber = 40018090092;
            DateTime dateTime = new DateTime();
            string day = Convert.ToString(dateTime.AddDays(1));
            string month = Convert.ToString(dateTime.AddMonths(7));
            string year = Convert.ToString(dateTime.AddYears(1400));
            string dateAprove = year + "/" + month + "/" + day;

            string studentInfo = "Full name : " + fullName + ", nationalCode : " + nationalCode + ", studentNumber : " + studentNumber
                + "Date time : " + dateAprove;
            File.WriteAllText("studentInfo.txt", studentInfo);

            double totalAverage;
            var bssAverage = Convert.ToDouble(File.ReadAllText("bssAverage.txt"));
            var mssAverage = Convert.ToDouble(File.ReadAllText("mssAverage.txt"));
            var pssAverage = Convert.ToDouble(File.ReadAllText("pssAverage.txt"));
            totalAverage = (bssAverage + mssAverage + pssAverage) / 3;
            Console.Write("Total average = ");
            Console.WriteLine(totalAverage);
        }
    }
}
