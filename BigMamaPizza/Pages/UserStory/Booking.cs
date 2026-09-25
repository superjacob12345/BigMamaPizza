using System.Reflection.Metadata.Ecma335;

namespace BigMamaPizza.Pages.UserStory
{
  
    public class Booking
    {
        // instans variabler
        private int _bookingId;
        private string _customerName;
        // constructor
        public Booking(int bookingId, string customerName)
        {
            _bookingId = bookingId;
            _customerName = customerName;
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

        // CRUD methods
        public void CreateBooking(int bookingId, string customerName)
        {
            // code to create a booking
            

        }
        public void ReadBooking(int bookingId)
        {
            // code to read a booking
        }
        public void UpdateBooking(int bookingId, string customerName)
        {
            // code to update a booking
        }
        public void DeleteBooking(int bookingId)
        {
            // code to delete a booking
        }



        // override ToString method

        public override string ToString()
        {
            return $"BookingId: {_bookingId}, CustomerName: {_customerName}";
        }
    }   
}
