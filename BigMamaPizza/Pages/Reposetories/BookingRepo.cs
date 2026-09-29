using System;
using BigMamaPizza.Pages.UserStory;


namespace BigMamaPizza.Pages.Reposetories
{
    public class BookingRepo
    {
        private List<Booking> _bookings;

        public BookingRepo()
        {
            _bookings = new List<Booking>();
        }
        public void CreateBooking(int bookingId, string customerName)
        {
            var booking = new Booking(bookingId, customerName);
            _bookings.Add(booking);
        }
        public void ReadBooking(int bookingId)
        {
            var booking = _bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking != null)
            {
                Console.WriteLine(booking);
            }
            else
            {
                Console.WriteLine("Booking not found.");
            }
        }
        public void UpdateBooking(int bookingId, string customerName)
        {
            var booking = _bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking != null)
            {
                booking.CustomerName = customerName;
            }
            else
            {
                Console.WriteLine("Booking not found.");
            }
        }
        public void DeleteBooking(int bookingId)
        {
            var booking = _bookings.FirstOrDefault(b => b.BookingId == bookingId);
            if (booking != null)
            {
                _bookings.Remove(booking);
            }
            else
            {
                Console.WriteLine("Booking not found.");
            }
        }
        public List<Booking> GetAllBookings()
        {
            return _bookings;
        }
        public Booking GetBookingById(int bookingId)
        {
            return _bookings.FirstOrDefault(b => b.BookingId == bookingId);
        }
        public void DisplayAllBookings()
        {
            foreach (var booking in _bookings)
            {
                Console.WriteLine(booking);
            }
        }
        public override string ToString()
        {
            return $"BookingRepo: {_bookings.Count} bookings";
        }
    }
}
