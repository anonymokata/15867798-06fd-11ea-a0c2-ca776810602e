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

            return (endTime - startTime).ToString();
        }
    }
}
