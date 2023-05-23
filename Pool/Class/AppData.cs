using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pool.Class
{
     class AppData
    {
        public static Api.ApiControler Context { get; set; } = new Api.ApiControler();

        public static void updateContext()
        {
            Context = new Api.ApiControler();
        }

    
    }
}
