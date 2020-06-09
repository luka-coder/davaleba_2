using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._3
{
    class Train
    {
        private int carriage;
        private int passengers;
        public double price;
        public int ticket;
        public double cash;

        public void Tran1(int carriage, int passengers, double price, int ticket)
        {
            this.carriage = carriage;
            this.passengers = passengers;
            this.price = price;
            this.ticket = ticket;
        }
        public void Tran2()
        {
            Console.Write("Number of Carriage: ");
            carriage = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of passengers in 1 carriage: ");
            passengers = Convert.ToInt32(Console.ReadLine());
            Console.Write("Price of Ticket: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.Write("Amount of Sold Tickets: ");
            ticket = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number of Carriage: {carriage}");
            Console.WriteLine($"Number of passengers in 1 carriage: {passengers}");
            Console.WriteLine($"Price of Ticket: {price}");
            Console.WriteLine($"Amount of Sold Tickets: {ticket}");
        }
        public void Cash()
        {
            cash = price * ticket;
            Console.WriteLine($"Cash from sold tickets {cash}");
        }
    }
}
