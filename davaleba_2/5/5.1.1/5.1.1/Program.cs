using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bakis tevadoba: ");
                int capacity = int.Parse(Console.ReadLine());
                Console.Write("Mandzili romelsac 1 litrit gaivlis: ");
                int distance = int.Parse(Console.ReadLine());
                int Dist = distance * capacity;
                Console.Write("Mgzavrebis raodenoba: ");
                int passenger = int.Parse(Console.ReadLine());
                Console.Write("Gayiduli biletebis raodenoba: ");
                int ticket = int.Parse(Console.ReadLine());
                Plane p1 = new Plane();
                Console.WriteLine($"Bakis tevadoba: {capacity}");
                Console.WriteLine($"Mandzili romelsac 1 litrit gaivlis: {distance}");
                Console.WriteLine($"Mandzili romelsac savse bakit gaivlis: {Dist}");
                Console.WriteLine($"Mgzavrebis raodenoba: {passenger}");
                Console.WriteLine($"Gayiduli biletebis raodenoba: {ticket}");
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
                Console.ReadLine();
            }
        }
    }
}
