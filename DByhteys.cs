using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Lisätty "referenssi"
using System.Configuration;

namespace Ravintolatilaus
{
    class DByhteys
    {
        internal static string GetConnectionString()
        {
            String returnValue = null;

            ConnectionStringSettings settings =
            ConfigurationManager.ConnectionStrings["Ravintolatilaus.Properties.Settings.RavintolaConnectionStringLocalDB"];

            if (settings != null)
                returnValue = settings.ConnectionString;

            return returnValue;
        }
    }
}
