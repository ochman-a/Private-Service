using System;
using Service;
using Interface;

namespace Hotel
{
    class Hotel : Service.Service, IReservable, ILouable
    {
        String localisation;

        public Hotel(String name, int id, int prixLocation, Boolean reservable, String typeService, String localisation) :base(name, id, prixLocation, reservable, typeService)
        {
            this.localisation = localisation;
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

        public String Localisation
        {
            get
            {
                return localisation;
            }
        }

    }
}
