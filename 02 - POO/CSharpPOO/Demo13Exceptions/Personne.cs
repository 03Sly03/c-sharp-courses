using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13Exceptions
{
    internal class Personne
    {
        private List<string> _adresses;

        private int _age;
        private string _telephone;

        public List<string> Adresses { get => _adresses; set => _adresses = value; }
        public int Age
        {
            get => _age;
            set
            {
                if (value > 0 && value < 200)
                    _age = value;
                else
                    //throw new Exception("Erreur dans la valeur d'age");
                    throw new AgeException();
            }
        }

        public string Telephone
        {
            get => _telephone;
            set
            {
                if (!value.StartsWith("0") || value.Length != 10)
                    throw new PhoneException();
                _telephone = value;
            }
        }

    }
}
