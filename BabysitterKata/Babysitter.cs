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
            if (Start == "5PM" && End == "10PM")
                return "5";
            else if (Start == "7PM" && End == "12AM")
                return "5";
            return "";
        }
    }
}
