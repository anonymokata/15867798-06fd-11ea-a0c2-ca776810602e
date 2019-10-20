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
            totalHours = Int32.Parse(CalculateDifferenceBetweenTwoHours(Start, End));
            return (totalHours * 15).ToString();
        }
    }
}
