using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodgotovkaDll
{
    public class FormatDate
    {
        public string comparingDate(DateTime date1, DateTime date2)
        {

            if (date1 == null)
            {
                Debug.WriteLine("date1 is Null");
                throw new ArgumentNullException("date1");
            }
            if (date2 == null) {
                Debug.WriteLine("date2 is Null");
                throw new ArgumentNullException("date2");
            }
            
            DateTime maxDate = date1;
            DateTime minDate = date2;
            if (date1 < date2) {
                maxDate = date2;
                minDate = date1;
            }
            
            return $"{maxDate} > {minDate}";
        }

        public string formatDate(DateTime date)
        {


            return "";
        }


        public TimeSpan substrationDate(DateTime date1, DateTime date2) { 
            return date1 - date2;
        }

    }
}
