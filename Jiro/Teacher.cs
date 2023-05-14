using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jiro
{
    class Teachers : IUniversity
    {
        public void LessonWork()
        {
            List<string> academicRanks = new List<string>();
            academicRanks.Add(" Bachelor");
            academicRanks.Add(" Master");
            academicRanks.Add(" Professor");
            Console.WriteLine("Enter your academicRank between this academicRanks :");
            foreach (var item in academicRanks)
            {
                Console.Write(item);
            }
            Console.WriteLine(); 

            Console.WriteLine("Enter the academicRank : ");
            string academicRank = Console.ReadLine();

            if (academicRank.Equals("Bachelor"))
            {
                Console.WriteLine("The professor have 9 Unit.");
            }
            else if (academicRank.Equals("Master"))
            {
                Console.WriteLine("The master have 6 unit.");
            }
            else if (academicRank.Equals("Professor"))
            {
                Console.WriteLine("The Bachelor have 3 unit.");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }

        public void StudentWork()
        {
            string allStudent = File.ReadAllText("studentInfo.txt");
            Console.WriteLine(allStudent);
            var bssAverage = Convert.ToDouble(File.ReadAllText("bssAverage.txt"));
            var mssAverage = Convert.ToDouble(File.ReadAllText("mssAverage.txt"));
            var pssAverage = Convert.ToDouble(File.ReadAllText("pssAverage.txt"));
        }

        public void TeacherWork()
        {
            string name;
            Console.WriteLine("Enter the name : ");
            name = Console.ReadLine();
            Int64 personalityCode;
            Console.WriteLine("Enter the personalityCode : ");
            personalityCode = Convert.ToInt64(Console.ReadLine());

            List<string> academicRanks = new List<string>();
            academicRanks.Add(" Bachelor");
            academicRanks.Add(" Master");
            academicRanks.Add(" Professor");
            Console.WriteLine("Enter your academicRank between this academicRanks :");
            foreach (var item in academicRanks)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            string academicRank;
            academicRank = Console.ReadLine();

            List<string> ifBachelor = new List<string>();
            ifBachelor.Add(" Tarbiaat badani");
            ifBachelor.Add(" Az fizik");
            ifBachelor.Add(" Az computer");

            List<string> ifMasters = new List<string>();
            ifMasters.Add(" Anghlab");
            ifMasters.Add(" Zaban omomi");
            ifMasters.Add(" Danesh khanivada");

            List<string> ifProfessor = new List<string>();
            ifProfessor.Add("Mabani");
            ifProfessor.Add(" Fizik");
            ifProfessor.Add(" Riazi");

            Console.WriteLine("The lesson for you :");

            if (academicRank.Equals("Bachelor"))
            {
                foreach (var item in ifBachelor)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

                Console.Write("Enter the tarbiat badani scoure : ");
                double tbScoure = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the az fizik scoure : ");
                double afScoure = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the az computer scoure : ");
                double acScoure = Convert.ToDouble(Console.ReadLine());

                double bssAverage  = (tbScoure + afScoure + acScoure) / 3;
                Console.WriteLine("Practical lessons average : " + bssAverage);
                File.WriteAllText("bssAverage.txt", bssAverage.ToString());
            }
            else if (academicRank.Equals("Master"))
            {
                foreach (var item in ifMasters)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

                Console.Write("Enter the anghlab scoure : ");
                double aScoure = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the zaban omomi scoure : ");
                double zoScoure = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the danesh khanevadeh scoure : ");
                double dkScoure = Convert.ToDouble(Console.ReadLine());

                double mssAverage = (aScoure + zoScoure + dkScoure) / 3;
                Console.WriteLine("General lessons average : " + mssAverage);
                File.WriteAllText("mssAverage.txt", mssAverage.ToString());
            }
            else if (academicRank.Equals("Professor"))
            {
                foreach (var item in ifProfessor)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

                Console.Write("Enter the mabani scoure : ");
                double mScoure = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the fizik scoure : ");
                double fScoure = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the riazi scoure : ");
                double rScoure = Convert.ToDouble(Console.ReadLine());

                double pssAverage = (mScoure + fScoure + rScoure) / 3;
                Console.WriteLine("Specialized lessons average : " + pssAverage);
                File.WriteAllText("pssAverage.txt", pssAverage.ToString());
            }
            else
            {
                Console.WriteLine("Error");
            }
            string teacher =  "Name : " + name + " ,Personality code : " + personalityCode + " ,Academic rank : " + academicRank;
            File.WriteAllText("Teacher.txt", teacher);
        }
    }
}

