using System;

namespace Service
{
    public class Service
    {
        private String  name;
        private int  id;
        private int     prixLocation;
        private Boolean reservable;
        private String typeService;

        public Service(String name, int id, int prixLocation, Boolean reservable, String typeService)
        {
            this.name         = name;
            this.id           = id;
            this.prixLocation = prixLocation;
            this.reservable   = reservable;
            this.typeService  = typeService;
        }

        public String Name
        {
            get
            {
                return name;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }

        public int PrixLocation
        {
            get
            {
                return prixLocation;
            }
        }

        public Boolean Reservable
        {
            get
            {
                return reservable;
            }
        }

        public String TypeService
        {
            get
            {
                return typeService;
            }
        }

    }
}
