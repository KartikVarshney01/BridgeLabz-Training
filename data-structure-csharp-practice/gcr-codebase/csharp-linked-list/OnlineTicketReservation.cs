using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabzTraining.data_structure_csharp_practice.gcr_codebase.csharp_linked_list
{
    internal class OnlineTicketReservation
    {
        static void Main(String[] args)
        {
            TicketReservation system = new TicketReservation();

            system.AddTicket(1, "Aman", "KGF", "A6", DateTime.Now);
            system.AddTicket(2, "Arjun", "War", "B8", DateTime.Now);
            system.AddTicket(3, "Karan", "War2", "A2", DateTime.Now);

            system.DisplayTickets();
            system.SearchTicket("War2");
            system.RemoveTicket(2);
            system.CountTickets();
            system.DisplayTickets();
        }

    }
    class Ticket
    {
        public int TicketId;
        public string CustomerName;
        public string MovieName;
        public string SeatNumber;
        public DateTime BookingTime;
        public Ticket Next;

        public Ticket(int id, string customer, string movie, string seat, DateTime booking)
        {
            TicketId = id;
            CustomerName = customer;
            MovieName = movie;
            SeatNumber = seat;
            BookingTime = booking;
            Next = null;
        }
    }

    class TicketReservation
    {
        private Ticket head;

        // Add ticket at end
        public void AddTicket(int id, string customer, string movie, string seat, DateTime booking)
        {
            Ticket newTicket = new Ticket(id, customer, movie, seat, booking);

            if (head == null)
            {
                head = newTicket;
                newTicket.Next = head;
                return;
            }

            Ticket temp = head;
            while (temp.Next != head)
                temp = temp.Next;

            temp.Next = newTicket;
            newTicket.Next = head;
        }

        // Remove ticket by ID
        public void RemoveTicket(int id)
        {
            if (head == null) return;

            Ticket temp = head;
            Ticket prev = null;

            do
            {
                if (temp.TicketId == id)
                {
                    if (prev != null)
                        prev.Next = temp.Next;
                    else
                    {
                        // Remove head
                        Ticket last = head;
                        while (last.Next != head)
                            last = last.Next;
                        head = temp.Next;
                        last.Next = head;
                        if (head == temp) head = null; // only one ticket
                    }
                    Console.WriteLine("Ticket removed.");
                    return;
                }
                prev = temp;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine("Ticket not found.");
        }

        // Display all tickets
        public void DisplayTickets()
        {
            if (head == null)
            {
                Console.WriteLine("No tickets booked.");
                return;
            }

            Ticket temp = head;
            do
            {
                Console.WriteLine($"ID: {temp.TicketId}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Booking: {temp.BookingTime}");
                temp = temp.Next;
            } while (temp != head);
        }

        // Search by Customer or Movie Name
        public void SearchTicket(string query)
        {
            if (head == null) return;

            Ticket temp = head;
            bool found = false;
            do
            {
                if (temp.CustomerName.Equals(query, StringComparison.OrdinalIgnoreCase) ||
                    temp.MovieName.Equals(query, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"ID: {temp.TicketId}, Customer: {temp.CustomerName}, Movie: {temp.MovieName}, Seat: {temp.SeatNumber}, Booking: {temp.BookingTime}");
                    found = true;
                }
                temp = temp.Next;
            } while (temp != head);

            if (!found) Console.WriteLine("No tickets found for query.");
        }

        // Count total tickets
        public void CountTickets()
        {
            if (head == null)
            {
                Console.WriteLine("Total Tickets: 0");
                return;
            }

            int count = 0;
            Ticket temp = head;
            do
            {
                count++;
                temp = temp.Next;
            } while (temp != head);

            Console.WriteLine($"Total Tickets: {count}");
        }
    }

}
