using System;
using System.Collections.Generic;
using System.Data;
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
            if (date == null)
            {
                Debug.WriteLine("date is Null");
                throw new ArgumentNullException("date");
            }

            string result = "";
            try
            {
                result = date.ToString("dd.MMMM.yy");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
          
            if(result == "")
            {
                throw new ArgumentNullException("result is Null");
            }

            return result;
        }


        public TimeSpan substrationDate(DateTime date1, DateTime date2) {
            if (date1 == null)
            {
                Debug.WriteLine("date1 is Null");
                throw new ArgumentNullException("date1");
            }
            if (date2 == null)
            {
                Debug.WriteLine("date2 is Null");
                throw new ArgumentNullException("date2");
            }

            TimeSpan rezult = TimeSpan.MinValue;

            try
            {
                if (date1 < date2)
                {
                    rezult = date2 - date1;
                }
                else
                {
                    rezult = date1 - date2;
                }
            }
            catch (Exception ex) {
                Debug.WriteLine($"Error substration Date {date1} and {date2} - {ex.Message}");
            }

            if (rezult == TimeSpan.MinValue) {
                throw new ArgumentException("rezult is fail");
            }

            return rezult;
        }

    }
}
