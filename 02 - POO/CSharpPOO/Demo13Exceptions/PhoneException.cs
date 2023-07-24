using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo13Exceptions
{
    internal class PhoneException :Exception
    {
        public PhoneException() : base("Erreur format téléphone")
        {

        }
    }
}
