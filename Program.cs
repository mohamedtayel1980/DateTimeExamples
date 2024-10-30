﻿namespace DateTimeExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // #region Creating and Manipulating DateTime
            #region Creating and Manipulating DateTime
            DateTime hireDate = new DateTime(2023, 10, 15, 9, 45, 0);  // October 15, 2023 at 9:45 AM
            Console.WriteLine($"Hire Date: {hireDate}");

            DateTime eventDate = new DateTime(2024, 5, 25);  // May 25, 2024
            Console.WriteLine($"Event Date: {eventDate}");
            #endregion

            // #region Performing Date Calculations with DateTime
            #region Performing Date Calculations with DateTime
            DateTime today = DateTime.Now;
            DateTime deadline = today.AddDays(10);  // Adding 10 days
            Console.WriteLine($"\nToday's Date: {today}");
            Console.WriteLine($"Deadline (10 days from today): {deadline}");

            DateTime earlierTime = today.AddHours(-5);  // Subtracting 5 hours
            Console.WriteLine($"5 Hours Ago: {earlierTime}");
            #endregion

            // #region Working with DateOnly
            #region Working with DateOnly
            DateOnly projectDueDate = new DateOnly(2023, 12, 31);  // December 31, 2023
            Console.WriteLine($"\nProject Due Date: {projectDueDate}");

            DateOnly meetingDate = new DateOnly(2023, 11, 15);
            DateOnly reminderDate = meetingDate.AddDays(-7);  // Reminder 7 days before meeting
            Console.WriteLine($"Meeting Date: {meetingDate}");
            Console.WriteLine($"Reminder Date (7 days before meeting): {reminderDate}");
            #endregion

            // #region Formatting DateTime and DateOnly
            #region Formatting DateTime and DateOnly
            DateTime appointmentDate = new DateTime(2024, 4, 15, 14, 30, 0);  // April 15, 2024 at 2:30 PM
            Console.WriteLine($"\nAppointment Date (Long Format): {appointmentDate.ToLongDateString()}");
            Console.WriteLine($"Appointment Time (Short Format): {appointmentDate.ToShortTimeString()}");

            DateOnly holiday = new DateOnly(2023, 12, 25);  // Christmas Day 2023
            Console.WriteLine($"Holiday (Formatted): {holiday.ToString("MMMM dd, yyyy")}");
            #endregion

            // #region Working with TimeSpan
            #region Working with TimeSpan
            DateTime startHour = DateTime.Now;
            TimeSpan workDuration = new TimeSpan(8, 0, 0);  // 8-hour workday
            DateTime endHour = startHour.Add(workDuration);

            Console.WriteLine($"\nStart Time: {startHour}");
            Console.WriteLine($"End Time after 8 hours: {endHour}");
            #endregion

            // #region Validating Dates
            #region Validating Dates
            try
            {
                // Attempting to create an invalid date (13th month)
                DateOnly invalidDate = new DateOnly(2023, 13, 5);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"\nError: {ex.Message}");
            }
            #endregion

            // #region Additional Examples for Practice
            #region Additional Examples for Practice

            // Easy: Add 30 days to today's date
            DateTime futureDate = today.AddDays(30);
            Console.WriteLine($"\nFuture Date (30 days from today): {futureDate}");

            // Medium: Calculate difference between two dates using TimeSpan
            DateTime startDate = new DateTime(2023, 1, 1);
            DateTime endDate = new DateTime(2023, 12, 31);
            TimeSpan dateDifference = endDate - startDate;
            Console.WriteLine($"Difference between {startDate} and {endDate}: {dateDifference.Days} days");

            // Difficult: Convert a user-input date string to DateOnly safely
            Console.WriteLine("\nEnter a date (yyyy-MM-dd):");
            string userInput = Console.ReadLine();

            try
            {
                DateOnly parsedDate = DateOnly.Parse(userInput);
                Console.WriteLine($"Parsed Date: {parsedDate}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid date format. Please enter a valid date in the format yyyy-MM-dd.");
            }

            #endregion
        }
    }
}