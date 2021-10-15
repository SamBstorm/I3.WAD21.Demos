using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I3.WAD21.Demos.LinqTypeAnonyme
{
    class UserProfile
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string MotDePasse { get; set; }

        public DateTime DateNaissance { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public string StatusCivil { get; set; }

        public string Ville { get; set; }
        public string Rue { get; set; }
        public string Numero { get; set; }
        public string CodePostal { get; set; }
        public string Pays { get; set; }
    }
}
