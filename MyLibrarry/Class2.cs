using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrarry
{
    public class Class2
    {
        public string Identity(Client client, DateTime dateTime)
        {
            string text = "";
            text= client.FirstName.Substring(0, 1).ToUpper() + 
                client.FirstName.Substring(1, client.FirstName.Length - 1).ToLower() + "_" + 
                client.LastName.Substring(0, 1).ToUpper() +
                 "." + client.Polynomic.Substring(0, 1).ToUpper() + "._" 
                 + dateTime.ToString("MM.dd.yyyy_H_mm");
            return text;

        }

    }
}
