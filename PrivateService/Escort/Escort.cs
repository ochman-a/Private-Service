using System;
using Interface;
using Service;

namespace Escort
{
    class Escort :Service.Service, IReservable, ILouable
    {
        private int age;
        private String origine;
        private String[] langue;

        public Escort(String name, int id, int prixLocation, Boolean reservable, String typeService, int age, String origine, String[] langue) :base(name, id, prixLocation, reservable, typeService)
        {
            this.age        = age;
            this.origine    = origine;
            this.langue     = langue;
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
            if (reservable == true)
                return Irent(reservable);
            else
                return false;
        }

        public int Age
        {
            get
            {
                return age;
            }
        }

        public String Origine
        {
            get
            {
                return origine;
            }
        }

        public String[] Langue
        {
            get
            {
                return langue;
            }
        }

    }
}
