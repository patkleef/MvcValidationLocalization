using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Business.Localization
{
    public class CustomLocalizationProvider
    {
        public static string FirstName
        {
            get
            {
                //TODO get localization label from SiteCore context
                return "Voornaam is verplicht";
            }
        }

        public static string LastName
        {
            get
            {
                //TODO get localization label from SiteCore context
                return "Achternaam is verplicht";
            }
        }
    }
}