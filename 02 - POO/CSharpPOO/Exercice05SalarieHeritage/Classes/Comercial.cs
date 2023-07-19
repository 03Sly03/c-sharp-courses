using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice05SalarieHeritage.Classes
{
    internal class Comercial : Salarie
    {
        public decimal ChiffreDAffaire { get; set; }
        public decimal CommissionPct { get; set; }
        public Comercial() : base()
        {
            Nom = "Commercial par défaut";
            ChiffreDAffaire = 0;
            CommissionPct = 0;
        }
        public Comercial(string matricule, string nom, string service, string categorie, decimal salaire, decimal chiffreDAffaire, decimal commissionPct) : base(matricule, nom, service, categorie, salaire)
        {
            ChiffreDAffaire = chiffreDAffaire;
            CommissionPct = commissionPct;
        }

        public override void AfficherSalaire()
        {

            if (this.GetType().Name == "Comercial")
                Console.WriteLine("Je suis un comercial :");

            base.AfficherSalaire();
            Console.WriteLine($"Le salaire avec commission de {Nom} est de {Salaire + (ChiffreDAffaire * CommissionPct / 100)} euros");
        }

        public override string ToString()
        {
            return base.ToString() + $", ChiffreDAffaire = {ChiffreDAffaire}, CommissionPct = {CommissionPct}";
        }
    }
}
