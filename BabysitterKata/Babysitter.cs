using System;

namespace BabysitterKata
{
    public class Babysitter
    {
        static void Main(string[] args)
        {
            
        }

        public string CalculateDifferenceBetweenTwoHours(string Start, string End)
        {
            int startTime = Int32.Parse(Start.Replace("AM","").Replace("PM",""));
            int endTime = Int32.Parse(End.Replace("AM","").Replace("PM",""));

            if (End.Contains("AM") && endTime < 12)
                endTime += 12;

            return (endTime - startTime).ToString();
        }

        public string CalculatePay(string Start, string End, string Family)
        {
            int totalHours = 0;
            int startTime = Int32.Parse(Start.Replace("AM","").Replace("PM",""));
            int endTime = Int32.Parse(End.Replace("AM","").Replace("PM",""));
            int hoursForFirstRate = 0;
            int hoursForSecondRate = 0;
            totalHours = Int32.Parse(CalculateDifferenceBetweenTwoHours(Start, End));
            if (Family == "A")
            {
                hoursForFirstRate = 11 - startTime;
                hoursForSecondRate = endTime - 11;
                return ((hoursForFirstRate * 15) + (hoursForSecondRate * 20)).ToString();
            }
            else if (Family == "B")
                return (totalHours * 12).ToString();
            else if (Family == "C")
                return (totalHours * 21).ToString();
            else
                return "";
        }
    }
}
