using System;

namespace ExempleDeClasse
{
    public class Personne
    {

        // Propri�t�s
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public int Age { get; set; }
        public int Breath { get; set; }

        // Constructeur
        public Personne(string prenom, string nom, int age)
        {

            Prenom = prenom;
            Nom = nom;
            Age = age;

        }

        // M�thode pour afficher les informations
        public void AfficherInfos()
        {
            Console.WriteLine($"Nom : {Nom}, Pr�nom : {Prenom}, �ge : {Age} ans.");
        }

        // M�thode pour savoir si la personne est majeure
        public bool EstMajeur()
        {
            return Age >= 18;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            // Cr�ation d'une instance de la classe Personne
            Personne personne = new Personne("Jean", "Dupont", 25);

            // Appel des m�thodes
            personne.AfficherInfos();
            Console.WriteLine($"Est majeur : {personne.EstMajeur()}");

        }
    }
}
