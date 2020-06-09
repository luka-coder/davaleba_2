using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Studentis saxeli: ");
                string first = string.Format(Console.ReadLine());
                Console.Write("Studentis gvari: ");
                string last = string.Format(Console.ReadLine());
                Console.Write("Studentis asaki: ");
                int age = int.Parse(Console.ReadLine());
                Console.Write("Universitetis saxeli: ");
                string uname = string.Format(Console.ReadLine());
                Console.Write("Kursi: ");
                int course = int.Parse(Console.ReadLine());
                Student S1 = new Student();
                Console.WriteLine($"Studentis saxeli: {first}");
                Console.WriteLine($"Studentis gvari: {last}");
                Console.WriteLine($"Studentis asaki: {age}");
                Console.WriteLine($"Universitetis saxeli: {uname}");
                Console.WriteLine($"Kursi: {course}");
            }
            catch (ArgumentNullException EX)
            {
                Console.WriteLine(EX.Message);
            }
            catch (FormatException EX)
            {
                Console.WriteLine(EX.Message);
            }
            catch (OverflowException EX)
            {
                Console.WriteLine(EX.Message);
            }
            catch (Exception EX)
            {
                Console.WriteLine(EX.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
