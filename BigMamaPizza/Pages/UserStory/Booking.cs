using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace BigMamaPizza.Pages.UserStory
{
  
    public class Booking
    {
        // instans variabler
        private List<Booking> _bookings;
        private int _bookingId;
        private string _customerName;
        // constructor
        public Booking(int bookingId, string customerName)
        {
            _bookingId = bookingId;
            _customerName = customerName;
            _bookings = new List<Booking>();
        }
        // properties
        public int BookingId
        {
            get { return _bookingId; }
            set { _bookingId = value; }
        }
        public string CustomerName
        {
            get { return _customerName; }
            set { _customerName = value; }
        }
        public List<Booking> Bookings
        {
            get { return _bookings; }
            set { _bookings = value; }
        }


        // CRUD methods
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



        // override ToString method

        public override string ToString()
        {
            return $"BookingId: {_bookingId}, CustomerName: {_customerName}";
        }
    }   
}
