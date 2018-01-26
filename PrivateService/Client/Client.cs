using System;
namespace ClientP
{
    public class Clients
    {
        public int idClient;
        public String nom;
        public String motDePasse;
        public int compte;

        public Clients(int idClient, String nom, String motDePasse, int compte)
        {
            this.idClient = idClient;
            this.nom = nom;
            this.compte = compte;
            this.motDePasse = motDePasse;
        }

        public int IdClient
        {
            get { return idClient; }
        }

        public String Nom
        {
            get { return nom; }
        }

        public int Compte
        {
            get { return compte; }
        }

        public String MotDePasse
        {
            get { return motDePasse; }
        }
    }
}
