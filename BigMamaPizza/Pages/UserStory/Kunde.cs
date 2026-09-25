using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace BigMamaPizza.Pages.UserStory
{
    public class Kunde
    {
        //instant felter
        private string _fornavn;
        private string _efternavn;
        private int telefonnummer;
        private string _email;
        //properties
        public string Fornavn
        {
            get { return _fornavn; }
            set { _fornavn = value; }
        }
        public string Efternavn
        {
            get { return _efternavn; }
            set { _efternavn = value; }
        }
        public int Telefonnummer
        {
            get { return telefonnummer; }
            set { telefonnummer = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        //konstruktør
        public Kunde(string fornavn, string efternavn, int telefonnummer, string email)
        {
            _fornavn = fornavn;
            _efternavn = efternavn;
            this.telefonnummer = telefonnummer;
            _email = email;
        }
        public override string ToString()
        {
            return $"Kunde: {Fornavn} {Efternavn}, Telefonnummer: {Telefonnummer}, Email: {Email}";
        }

        //Crud metoder
        public void CreateKunde(string fornavn, string efternavn, int telefonnummer, string email)
        {
           
        }
        public void ReadKunde()
        {
            
        }
        public void UpdateKunde(string fornavn, string efternavn, int telefonnummer, string email)
        {
            
        }
        public void DeleteKunde( string email, string efternavn, string fornavn, int telefonnummer)
        {
          
        }
    }
}




