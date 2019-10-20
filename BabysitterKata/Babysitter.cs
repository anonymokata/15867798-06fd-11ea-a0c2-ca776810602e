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
            int startTime = GetStartTime(Start);
            int endTime = GetEndTime(End);
            int hoursForFirstRate = 0;
            int hoursForSecondRate = 0;
            int hoursForThirdRate = 0;
            totalHours = Int32.Parse(CalculateDifferenceBetweenTwoHours(Start, End));
            if (Family == "A")
            {
                if (endTime > 11)
                {
                    hoursForFirstRate = 11 - startTime;
                    hoursForSecondRate = endTime - 11;
                }
                else
                    hoursForFirstRate = totalHours;
                return ((hoursForFirstRate * 15) + (hoursForSecondRate * 20)).ToString();
            }
            else if (Family == "B")
            {
                if (endTime > 12)
                {
                    hoursForFirstRate = 10 - startTime;
                    hoursForSecondRate = 2;
                    hoursForThirdRate = endTime - 12;
                }
                else if (endTime > 10)
                {
                    hoursForFirstRate = 10 - startTime;
                    hoursForSecondRate = endTime - 10;
                }
                else
                    hoursForFirstRate = totalHours;
                return ((hoursForFirstRate * 12) + (hoursForSecondRate * 8) + (hoursForThirdRate * 16)).ToString();
            }
            else if (Family == "C")
                return (totalHours * 21).ToString();
            else
                return "";
        }

        public int GetStartTime(string Start)
        {
            int startTime = Int32.Parse(Start.Replace("AM","").Replace("PM",""));
            if (Start.Contains("AM") && startTime < 12)
                startTime += 12;
            return startTime;
        }

        public int GetEndTime(string End)
        {
            int endTime = Int32.Parse(End.Replace("AM","").Replace("PM",""));
            if (End.Contains("AM") && endTime < 12)
                endTime += 12;
            return endTime;
        }
    }
}
