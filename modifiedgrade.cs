using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5
{
    partial class Program
    {

        static void Main(string[] args)
        {

            var obj = new Student();
            obj.studentdata();

            obj.totalgrade();
            obj.subjectgrade();
        }
    }
}

namespace A5
{
    partial class Program
    {
        class Student
        {
            public string name;
            public int age;
            public double phy, chem, eng, math, his, obtd_marks, total_marks = 500, percentage;
            public double n;

            public Student()
            {


                name = "ANU";
                age = 23;
                phy = 97;
                eng = 90;
                math = 80;
                his = 50;
                chem = 76;



            }



            public void studentdata()
            {
                obtd_marks = phy + eng + math + his;
                Console.WriteLine("Name of the student:" + name);
                Console.WriteLine("Age of the student is" + age);
                Console.WriteLine("Total mark obtained=" + obtd_marks);

            }


            public void totalgrade()
            {

                if (obtd_marks >= 400 && obtd_marks <= 500)
                {
                    Console.WriteLine("Total:grade is A");
                }
                else if (obtd_marks >= 300 && obtd_marks < 400)
                {
                    Console.WriteLine("Total:grade is B");
                }
                else
                {
                    Console.WriteLine("Total:grade is C");
                }

                percentage = (obtd_marks / total_marks) * 100;
                Console.WriteLine("percentage is" + percentage);
            }
            public void grade(double n)
            {

                if (n >= 80 && n <= 100)
                {
                    Console.WriteLine("A Grade");
                }
                else if (n >= 60 && n < 80)
                {
                    Console.WriteLine("B Grade");
                }
                else
                {
                    Console.WriteLine("C Grade");
                }
            }
            public void subjectgrade()
            {
                Console.WriteLine("Physics");
                grade(phy);
                Console.WriteLine("Chemistry");
                grade(chem);
                Console.WriteLine("English");
                grade(eng);
                Console.WriteLine("Maths");
                grade(math);
                Console.WriteLine("History");
                grade(his);
            }
        }
    }
}

