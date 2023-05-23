using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Model
{
    public partial class Employess
    {
        public int EmployessId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string SurName { get; set; }

        public DateTime Birthday { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string Phone { get; set; }

        public string PalceRegistration { get; set; }

        public int SerilPassport {get; set; }

        public int NumPassport { get ; set; }

        public DateTime DateGet { get; set; }
        
        public string Mail { get; set; }

        public int TypeOfEmployessID { get; set; }

        public string login { get; set; }
        
        public string password { get; set; }
        public string image { get; set; }
    }
}
