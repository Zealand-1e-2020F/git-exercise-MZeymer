namespace GitExercise
{
    class myClass
    {
        private string _navn;
        private string _adresse;
        private int _postnummer;
        private string _by;
        #region Constructor
        public myClass(string navn, string adresse, int postnummer, string by)
        {
            _navn = navn;
            _adresse = adresse;       
            _postnummer = postnummer;
            _by = by;
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

        public string By {
        get { return _by; } 
        set { _by = value; }
        }

        

        #endregion



    }
}