using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonMvvm
{
    public class ConfigurationHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["TS"].ConnectionString;
        }
    }
}
