using System;
using Service;
using Interface;

namespace Transport
{
    public class Transport : Service.Service, IAchetable, ILouable, IReservable
    {
        
        Boolean achetable;
        int prixAchat;
        int nbPassager;
        char permis;
        String typeVehicule;


        public Transport(String name, int id, int prixLocation, Boolean reservable, String typeService, Boolean achetable, int prixAchat, int nbPassager, char permis, String typeVehicule) :base(name, id, prixLocation, reservable, typeService)
        {
            this.achetable      = achetable;
            this.prixAchat      = prixAchat;
            this.nbPassager     = nbPassager;
            this.permis         = permis;
            this.typeVehicule   = typeVehicule;
        }

        public void Ibuy(Boolean achetable)
        {
            String choix;

            Console.WriteLine("Voulez-vous acheter ce véhicule ?\n");
            choix = Console.ReadLine();
        }

        public Boolean Irent(Boolean reservable)
        {
            String choix;

            Console.WriteLine($"Voulez-vous louer: {base.Name} ?\nO/N");
            choix = Console.ReadLine();
            if (choix == "O")
                return false;
            else
                return true; 
        }

        public Boolean Ireserv(Boolean reservable)
        {
            if (reservable)
                return Irent(reservable);
            else
                return false;   
        }
    }
}
