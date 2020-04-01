namespace GitExercise
{
    class myClass
    {
        private string _navn;
        private string _adresse;
        private int _postnummer;

        #region Constructor
        public myClass(string navn, string adresse, int postnummer)
        {
            _navn = navn;
            _adresse = adresse;       
            _postnummer = postnummer;
        }
        
        #endregion

        #region Properties
        public string Navn {
        get { return _navn; } 
        set { _navn = value; }
        }

         public string Adresse {
         get { return _adresse; } 
         set { _adresse = value; }
        }
        public int Postnummer {
        get { return _postnummer; } 
        set { _postnummer = value; }
        }

        #endregion



    }
}