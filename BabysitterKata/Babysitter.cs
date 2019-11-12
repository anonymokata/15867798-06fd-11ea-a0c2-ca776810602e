using System;

namespace BabysitterKata
{
    public class Babysitter
    {
        static void Main(string[] args)
        {
            Babysitter babysitter = new Babysitter();
            bool endApp = false;
            string message = 
            "------------------\n" +
            "Hourly Pay Calculator\n" +
            "------------------\n";

            Console.WriteLine(message);

            while (!endApp)
            {

                message =
                "1. Calculate Pay\n" +
                "2. View Family Payrates\n" +
                "3. Exit Application";

                Console.WriteLine(message);

                switch(Console.ReadLine())
                {
                    case "1":
                        babysitter.RunCalculatePay();
                        break;
                    case "2":
                        babysitter.ViewFamilies();
                        break;
                    case "3":
                        endApp = true;
                        break;
                }
            }
        }

        public string CalculateDifferenceBetweenTwoHours(string Start, string End)
        {
            int startTime = Int32.Parse(Start.ToUpper().Replace("AM","").Replace("PM",""));
            int endTime = Int32.Parse(End.ToUpper().Replace("AM","").Replace("PM",""));

            if (End.ToUpper().Contains("AM") && endTime < 12)
                endTime += 12;

            return (endTime - startTime).ToString();
        }

        public string CalculatePay(string Start, string End, string Family)
        {
            int totalHours = 0;
            int startTime = 0;
            int endTime = 0;
            try
            {
                startTime = GetStartTime(Start);
                endTime = GetEndTime(End);
            }
            catch(System.FormatException ex)
            {
                return "\nError: Time entered was an ivalid format.\n" +
                "Please enter a time such as 6PM.\n";
            }

            if (startTime > endTime)
                return "\nError: Starting time can't be later than the ending time.\n";
            
            int hoursForFirstRate = 0;
            int hoursForSecondRate = 0;
            int hoursForThirdRate = 0;

            if (startTime < 5)
            {
                return "Error: Can't start working before 5PM";
            }
            else if (endTime > 16)
            {
                return "Error: Can't leave after 4AM";
            }

            totalHours = Int32.Parse(CalculateDifferenceBetweenTwoHours(Start, End));

            if (Family.ToUpper() == "A")
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
            else if (Family.ToUpper() == "B")
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
            else if (Family.ToUpper() == "C")
            {
                if (endTime > 9)
                {
                    hoursForFirstRate = 9 - startTime;
                    hoursForSecondRate = endTime - 9;
                }
                else
                    hoursForFirstRate = totalHours;
                return ((hoursForFirstRate * 21) + (hoursForSecondRate * 15)).ToString();
            }
            else
                return "Error: Invalid family entered.";
        }

        public int GetStartTime(string Start)
        {
            int startTime = Int32.Parse(Start.ToUpper().Replace("AM","").Replace("PM",""));
            if (Start.ToUpper().Contains("AM") && startTime < 12)
                startTime += 12;
            return startTime;
        }

        public int GetEndTime(string End)
        {
            int endTime = Int32.Parse(End.ToUpper().Replace("AM","").Replace("PM",""));
            if (End.ToUpper().Contains("AM") && endTime < 12)
                endTime += 12;
            return endTime;
        }

        public void RunCalculatePay()
        {
            string startTime = "";
            string endTime = "";
            string family = "";

            Console.Write("\nPlease enter the starting time. e.g. 5PM. ");
            startTime = Console.ReadLine();

            Console.Write("Please enter the ending time. e.g. 9PM. ");
            endTime = Console.ReadLine();

            Console.Write("Please enter a family (A-C). ");
            family = Console.ReadLine();

            Console.WriteLine(CalculatePay(startTime, endTime, family));
        }

        public void ViewFamilies()
        {
            string message = 
            "\nFamily A: $15 per hour before 11PM, $20 per hour after 11PM.\n" +
            "Family B: $12 per hour before 10PM, $8 per hour between 10PM and 12AM, $16 per hour after 12AM.\n" +
            "Family C: $21 per hour before 9PM, $15 per hour after 9PM.\n";

            Console.WriteLine(message);
        }
    }
}
