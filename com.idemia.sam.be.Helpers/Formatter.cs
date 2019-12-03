using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.idemia.sam.be.Helpers
{
    public class Formatter
    {
        public static string formatDatetoString(DateTime Date)
        {
            string output = string.Empty;//default(string);
            try
            {
                //output = Date.Day.ToString("D2") + "-" + Date.Month.ToString("D2") + "-" + Date.Year.ToString("D2") + " " 
                //    + Date.Hour.ToString("D2") + ":" + Date.Minute.ToString("D2") + ":" + Date.Second.ToString("D2");

                output = Date.Day.ToString("D2") + "/" + Date.Month.ToString("D2") + "/" + Date.Year.ToString("D4");
                   // + " "
                   // + Date.Hour.ToString("D2") + ":" + Date.Minute.ToString("D2") + ":" + Date.Second.ToString("D2");
            }
            catch (Exception)
            {
            }

            return output;
        }

        public static DateTime formatStringtoDate(string String)
        {
            DateTime output = default(DateTime);
            try
            {
                if (!string.IsNullOrWhiteSpace(String))
                    //output = DateTime.ParseExact(String, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                    output = DateTime.ParseExact(String, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                throw;
            }

            return output;
        }
    }
}
