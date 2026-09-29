namespace BigMamaPizza.Pages.UserStory
{
    public class Medarbejder
    {
        // instant felter
       private int _id;
        private string _name;
    
    public Medarbejder() 
        {
            _id = 0;
            _name = string.Empty;
        }
        public Medarbejder(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void SeAlleBookinger()
        {
            // Implement logic to retrieve and display all bookings for the employee
            Console.WriteLine($"Displaying all bookings for Medarbejder: {Name}, Id: {Id}");
        }
        public void TilDelBoord()
        {
            // Implement logic to assign a table to the employee
            Console.WriteLine($"Assigning a table to Medarbejder: {Name}, Id: {Id}");
        }

        public void CreateMedarbejder(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public void ReadMedarbejder()
        {
            Console.WriteLine($"Medarbejder: {Name}, Id: {Id}");
        }
        public void UpdateMedarbejder(int id, string name)
        {
            _id = id;
            _name = name;
        }
        public void DeleteMedarbejder()
        {
            _id = 0;
            _name = string.Empty;
        }
        public override string ToString()
        {
            return $"Medarbejder: {Name}, Id: {Id}";
        }
    }
}
