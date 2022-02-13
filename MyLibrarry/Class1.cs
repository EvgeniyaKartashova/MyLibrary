using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrarry
{ 
    public static class Calc
    {
        /// <summary>
        /// Метод возвращает сумму двух чисел
        /// </summary>
        /// <param name="firstValue"></param>
        /// <param name="SekondValue"></param>
        /// <returns></returns>
        public static double Add(double firstValue, double SekondValue)
        {
            return firstValue + SekondValue;
        }
        public static double Substract(double firstValue, double SekondValue)
        {
            return firstValue - SekondValue;
        }
        public static double Multiplay(double firstValue, double SekondValue)
        {
            return firstValue * SekondValue;
        }
        public static double Divide(double firstValue, double SekondValue)
        {
            if (SekondValue != 0)
                return firstValue + SekondValue;
            else return 0;
        }

    }
    public class Student
    {
      public  string firstName { get; set; }
      public  string secondName { get; set; }
      public  int adg { get; set; }
    }
    public class Calcstudent
    {
      //  public List<Student> students = new List<Student>();
        public double avg(List<Student> students)
        {
            if (students?.Any() == true)
            {
                double sum = 0;
                foreach (Student item in students)
                {
                    sum += item.adg;
                }
                return sum / students.Count;
            }
            else return 0;
        }
    }
   
}
