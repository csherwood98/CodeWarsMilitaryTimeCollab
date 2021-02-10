using System;

namespace CodeWarsNotesIFormatProvider
{
    class Program
    {
        //the goal is to write the time below in military time

        static void Main()
        {
            string time = "24:72:91";

            time = Correct(time);

            Console.WriteLine(time);

        }
        public static string Correct(string timeString)
        {

            //null and empty cover
            //
            if (timeString == "" || timeString == null)
                return timeString;

            //array split

            var timeArray = timeString.Split(":");
            int[] intTimeArray = new int[3];

            //convert time parts into integers

            foreach (string item in timeArray)
            {
                Console.WriteLine(item);
                int i = 0;
                intTimeArray[i] = Convert.ToInt32(item);
                i++;
            }

            //apply rules to integers

            if (intTimeArray[2] >= 60)
            {
                Console.WriteLine(intTimeArray[2]);
                intTimeArray[1] += 1;
                intTimeArray[2] = intTimeArray[2] % 60;
            }
            if (intTimeArray[1] >= 60)
            {
                Console.WriteLine(intTimeArray[1]);
                intTimeArray[0] += 1;
                intTimeArray[1] = intTimeArray[1] % 60;

            }
            if (intTimeArray[0] >= 24)
            {
                Console.WriteLine(intTimeArray[0]);
                intTimeArray[0] = intTimeArray[0] % 24;

            }


            //convert back to string

            foreach (int item in intTimeArray)
            {
                Console.WriteLine(item);
                int i = 0;
                timeArray[i] = Convert.ToString(item);
                i++;
            }


            timeString = $"{timeArray[0]}:{timeArray[1]}:{timeArray[2]}";
            return timeString;
        }
    }
}
