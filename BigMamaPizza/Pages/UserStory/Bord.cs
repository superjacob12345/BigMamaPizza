namespace BigMamaPizza.Pages.UserStory
{
    public class Bord
    {
        //instant felter
        private int _BordId;
        private int _Nummer;
        private int _AntalPladser;
        private bool _ErOptaget;
        //properties
        public int BordId
        {
            get { return _BordId; }
            set { _BordId = value; }
        }
        public int Nummer
        {
            get { return _Nummer; }
            set { _Nummer = value; }
        }
        public int AntalPladser
        {
            get { return _AntalPladser; }
            set { _AntalPladser = value; }
        }
        public bool ErOptaget
        {
            get { return _ErOptaget; }
            set { _ErOptaget = value; }
        }
        //Konstruktør
        public Bord(int bordId, int nummer, int antalPladser, bool erOptaget)
        {
            _BordId = bordId;
            _Nummer = nummer;
            _AntalPladser = antalPladser;
            _ErOptaget = erOptaget;
        }
        public override string ToString()
        {
            return $"Bord: {Nummer}, Antal Pladser: {AntalPladser}, Er Optaget: {ErOptaget}";
        }
    }
    }

