using BigMamaPizza.Pages.UserStory;

namespace BigMamaPizza.Pages.Reposetories
{
    public class BordRepo
    {
        private List<Bord> _bord;

        public BordRepo()
        {
            _bord = new List<Bord>();
        }
        public void CreateBord(int bordId, int nummer, int antalPladser, bool erOptaget)
        {
            var bord = new Bord(bordId, nummer, antalPladser, erOptaget);
            _bord.Add(bord);
        }
        public void ReadBord(int bordId)
        {
            var bord = _bord.FirstOrDefault(b => b.BordId == bordId);
            if (bord != null)
            {
                Console.WriteLine(bord);
            }
            else
            {
                Console.WriteLine("Bord not found.");
            }
        }
        public void UpdateBord(int bordId, int nummer, int antalPladser, bool erOptaget)
        {
            var bord = _bord.FirstOrDefault(b => b.BordId == bordId);
            if (bord != null)
            {
                bord.Nummer = nummer;
                bord.AntalPladser = antalPladser;
                bord.ErOptaget = erOptaget;
            }
            else
            {
                Console.WriteLine("Bord not found.");
            }
        }
        public void DeleteBord(int bordId)
        {
            var bord = _bord.FirstOrDefault(b => b.BordId == bordId);
            if (bord != null)
            {
                _bord.Remove(bord);
            }
            else
            {
                Console.WriteLine("Bord not found.");
            }
        }
        public List<Bord> GetAllBord() { return _bord; }
        public Bord GetBordById(int bordId)
        {
            return _bord.FirstOrDefault(b => b.BordId == bordId);
        }
        public void SeAlleBorde()
        {
            foreach (var bord in _bord)
            {
                Console.WriteLine(bord);
            }
        }
       
        }
    }


