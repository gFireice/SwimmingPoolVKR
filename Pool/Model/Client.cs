using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Model
{
    public class Client
    {

        public int ClientID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SurName { get; set; }

        public DateTime BirthDay { get; set; }

        public DateTime RegistraarionDate { get; set; }

        public string Phone { get; set; }

        public string PlaceRegistration { get; set; }

        public Nullable<int> SerialPassport { get; set; }

        public Nullable<int> NumPassport { get; set; }

        public Nullable<DateTime> DateGet { get; set; }

        public string Mail { get; set; }
    }
}
