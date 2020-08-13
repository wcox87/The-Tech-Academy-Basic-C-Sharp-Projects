using System;

namespace studentDailyReport
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("");
            Console.WriteLine("Press the enter key to begin...");
            Console.ReadLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("");
            
            Console.WriteLine("What is your name?");
            string studentName = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("What Course are you on?");
            string currentCourse = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("What page number?");
            string pageNumber = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumber);
            Console.WriteLine("");

            Console.WriteLine("Do you need help with anything? Please enter \"true\" or \"false\".");
            string needHelp = Console.ReadLine();
            bool needsHelp = Convert.ToBoolean(needHelp);
            Console.WriteLine("");

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string studentExperience = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string studentFeedback = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            byte hoursStudied = Convert.ToByte(studyHours);
            Console.WriteLine("");

            Console.WriteLine("Press the enter key to review your report...");
            Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Student: " + studentName);
            Console.WriteLine("Current Course: " + currentCourse);
            Console.WriteLine("Current Page: " + pageNum);
            Console.WriteLine("Student Needs Assistance: " + needsHelp);
            Console.WriteLine("Student's Positive Comments: " + studentExperience);
            Console.WriteLine("Student Feedback: " + studentFeedback);
            Console.WriteLine("Hours Studied: " + hoursStudied);
            Console.WriteLine("");
            Console.WriteLine("Pres the enter key to submit your report...");
            Console.ReadLine();
            Console.WriteLine("**************************************");
            Console.WriteLine("");

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
