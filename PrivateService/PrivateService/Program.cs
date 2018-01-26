using System;
using System.Collections.Generic;
using Service;
using System.Collections;
using System.Linq;
using Microsoft.Data.Sqlite;
using ClientP;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace PrivateService
{
    class Program
    {
        public static void creationCompte()
        {
            using (var context = new DatabaseContext())
            {
                int id = 4;
                System.Console.WriteLine("Veuillez entrer votre nom:");
                String tempNom = Console.ReadLine();
                System.Console.WriteLine("Veuillez entrer votre mot de passe:");
                String tempMpd = Console.ReadLine();
                System.Console.WriteLine("Veuillez entrer la somme disponible sur votre compte:");
                int tempCompte = Convert.ToInt32(Console.ReadLine());
                //System.Console.WriteLine($"Votre id est: {database.Client.idClient}");
                //var noClient = new Client.Client (4, tempNom, tempMpd, tempCompte);

                var newClient = context.Set<Clients>();
                context.Client.Add(new Clients { idClient = id, nom = tempNom, motDePasse = tempMpd, compte = tempCompte });
                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static void vTerre(Clients client)
        {
            using (var context = new DatabaseContext2())
            {
                
            }
        }

        public static void vAir(Clients client)
        {
            using (var context = new DatabaseContext2())
            {

            }
        }

        public static void vMer(Clients client)
        {
            using (var context = new DatabaseContext2())
            {

            }
        }

        public static void sEscort(Clients client)
        {
            using (var context = new DatabaseContext2())
            {

            }
        }

        public static void sHotel(Clients client)
        {
            using (var context = new DatabaseContext2())
            {

            }
        }

        public static void fonctionnement()
        {
            using (var context = new DatabaseContext())
            {
                var quit = 0;

                System.Console.WriteLine("Veuillez indiquez votre id:");
                int tempId = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Veuillez indiquez votre mot de passe:");
                String tempMdp = Console.ReadLine();
                var idenCli = context.Client.Where(idClient => client.idClient == tempId);
                if (idenCli.motDePasse == tempMdp)
                {
                    while (quit != 0)
                    {

                        Console.WriteLine("Dans quel service voulez-vous entrer ?\n1.Vehicule terrestre\n2.Vehicule aerien\n3.Vehicule maritime\n4.Escort\n5.Hotel\n0pour quitter");
                        quit = Convert.ToInt32(Console.ReadLine());
                        if (quit == 1)
                            vTerre(idenCli);
                        else if (quit == 2)
                            vAir(idenCli);
                        else if (quit == 3)
                            vMer(idenCli);
                        else if (quit == 4)
                            sEscort(idenCli);
                        else if (quit == 5)
                            sHotel(idenCli);
                    }
                }
            }
        }

        public static void Main(string[] args)
        {

            var choix = "K";

            System.Console.WriteLine("Bonjour, avez vous déjà un compte client ?\nO/N");
            choix = Console.ReadLine();
            if (choix == "N")
            {
                creationCompte();
                fonctionnement();
            }
            else
                Console.WriteLine("A");
                fonctionnement();
        }
    }
}