using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMX_Production.Controllers
{
    class Helper
    {
        public static string CnnVal (string name) {
            string cnS= ConfigurationManager.ConnectionStrings[name].ConnectionString.ToString();
            return cnS;
        }


    }
}
