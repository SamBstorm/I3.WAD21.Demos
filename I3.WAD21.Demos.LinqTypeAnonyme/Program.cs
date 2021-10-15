using System;
using System.Collections.Generic;

namespace I3.WAD21.Demos.LinqTypeAnonyme
{
    class Program
    {
        static void Main(string[] args)
        {
            UserProfile profile = new UserProfile() {
                Id = 1,
                Email = "samuel.legrain@bstorm.be",
                MotDePasse = "test1234=",
                Nom = "Legrain",
                Prenom = "Samuel",
                StatusCivil = "Célibataire",
                Ville = "Charleroi",
                CodePostal = "6000",
                Rue = "Avenue des cerisiers",
                Numero = "2B",
                Pays = "BELGIQUE",
                DateNaissance = new DateTime(1987,9,27)
            };

            var infoUser = new { 
                NomDeFamille = profile.Nom,
                profile.Prenom
            };

            var inforUser2 = new
            {
                NomDeFamille = "Willis",
                Prenom = "Bruce",
                DateNaissance = new DateTime(1955,5,19)
            };

            infoUser = inforUser2;
            //Impossible car pas la même structure

            List<string> listOfNom = new List<string>{ "Sam", "Michael", "Piu", "Jérôme" };
            listOfNom.Add("Sam");

            var users = new List<???>();
            // Impossible sans LinQ
            
            Console.WriteLine(infoUser.Prenom);
        }
    }
}
