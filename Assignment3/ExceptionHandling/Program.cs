Create a console application to book train tickets. Create a Passanger class with (Name, Age) and write a function called TicketBooking(no_of_tickets) that takes no.of tickets to be booked. If the no of tickets is > 5 per booking, raise an user defined exception, and print "cannot book more than 2 tickets". Else Print  "Ticket Booked Successfully". Add a Test class to call TicketBooking method by accepting all required details.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class BookingException : ApplicationException
    {
        public BookingException(string msg) : base(msg)
        {
        }
    }

    class Passenger
    {
        string Name;
        int Age,tickets;

        public void TicketBooking()
        {
            Console.Write("Enter your name: ");
            Name = Console.ReadLine();
            Console.Write("Enter age: ");
            Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter no of tickets: ");
            tickets = Convert.ToInt32(Console.ReadLine());
            if (tickets > 2)
            {
                throw (new BookingException("Cannot book more than 2 tickets"));
            }
            else
            {
                Console.WriteLine("Tickets Booked Successfully");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Passenger bkng = new Passenger();
            try
            {
                bkng.TicketBooking();
            }
            catch(BookingException be)
            {
                Console.WriteLine(be.Message);
            }
        }
    }
}
