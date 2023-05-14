using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiro
{
    class Lessons : IUniversity
    {
        public void LessonWork()
        {
            Console.WriteLine("Chose between this item : {1 unit} or {2 unit} or {3 unit}");
            int selectUnit = Convert.ToInt32(Console.ReadLine());

            List<string> oneUnitLesson = new List<string>();
            oneUnitLesson.Add(" Tarbiaat badani");
            oneUnitLesson.Add(" Az fizik"); 
            oneUnitLesson.Add(" Az computer");

            List<string> twoUnitLesson = new List<string>();
            twoUnitLesson.Add(" Anghlab");
            twoUnitLesson.Add(" Zaban omomi");
            twoUnitLesson.Add(" Danesh khanivada");

            List<string> threeUnitLesson = new List<string>();
            threeUnitLesson.Add(" Mabani");
            threeUnitLesson.Add(" Fizik");
            threeUnitLesson.Add(" Riazi");

            List<string> allLesson = new List<string>();
            allLesson.AddRange(oneUnitLesson);
            allLesson.AddRange(twoUnitLesson);
            allLesson.AddRange(threeUnitLesson);
            File.AppendAllLines("allLesson.txt", allLesson);
         
            if (selectUnit == 1)
            {
                foreach (var item in oneUnitLesson)
                {
                    Console.Write(item);
                }
            }
            else if (selectUnit == 2)
            {
                foreach (var item in twoUnitLesson)
                {
                    Console.Write(item);
                }
            }
            else
            {
                foreach (var item in threeUnitLesson)
                {
                    Console.Write(item);
                }
            }
            Console.WriteLine("\n");

            string name;
            Console.WriteLine("Chose the course with your selected unit : ");
            name = Console.ReadLine();

            Console.WriteLine("\n");


            int lessonCode;
            Console.WriteLine("Enter the course Lesson code : ");
            lessonCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            int lessonCapacity; //ظرفیت
            if (name.Equals("Tarbiaat badani"))
            {
                lessonCapacity = 60;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else if (name.Equals("Az fizik"))
            {
                lessonCapacity = 60;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else if (name.Equals("Az computer"))
            {
                lessonCapacity = 60;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else if(name.Equals("Anghlab"))
            {
                lessonCapacity = 40;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else if (name.Equals("Zaban omomi"))
            {
                lessonCapacity = 40;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else if (name.Equals("Danesh khanivade"))
            {
                lessonCapacity = 40;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else if(name.Equals("Mabani"))
            {
                lessonCapacity = 30;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else if (name.Equals("Fizik"))
            {
                lessonCapacity = 30;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else if (name.Equals("Riazi"))
            {
                lessonCapacity = 30;
                Console.WriteLine("Lesson capacity is " + lessonCapacity);
            }
            else
            {
                Console.WriteLine("Error");
            }
        }

        public void StudentWork()
        {
            
        }
      
        public void TeacherWork()
        {
            
        }
    }
}
