using System.Globalization;

namespace DemoSite.Utilities
{
    public class DatesUtilities
    {

        /// <summary>
        /// Constrains an integer value within a specified range.
        /// </summary>
        /// <param name="input">The input value to be clamped.</param>
        /// <param name="min">The minimum value of the range.</param>
        /// <param name="max">The maximum value of the range.</param>
        /// <returns>
        /// The clamped value:
        /// - If input is less than min, returns min.
        /// - If input is greater than max, returns max.
        /// - Otherwise, returns the original input value.
        /// </returns>
        public static int ClampValue(int input, int min, int max)
        {
            if (input < min) return min;
            if (input > max) return max;
            return input;
        }

        /// <summary>
        /// Calculates and returns the date of the Monday for the current week.
        /// </summary>
        /// <remarks>
        /// This method works by subtracting the appropriate number of days from the current date
        /// to reach the Monday of the same week. It correctly handles the case where the current
        /// day is Sunday by subtracting an additional week.
        /// </remarks>
        /// <returns>A DateOnly representing the Monday of the current week, regardless of the current day.</returns>
        public static DateOnly GetMondayOfCurrentWeek()
        {
            return DateOnly.FromDateTime(DateTime.Today).AddDays(DayOfWeek.Monday - DateTime.Today.DayOfWeek - 7);
        }

        public static DateOnly GetMondayOfWeek(DateOnly date)
        {
            int diff = (7 + (date.DayOfWeek - DayOfWeek.Monday)) % 7;
            return date.AddDays(-1 * diff);
        }

        /// <summary>
        /// Gets the week number of the year for a given date.
        /// </summary>
        /// <param name="date">The date for which to determine the week number.</param>
        /// <returns>An integer representing the week number of the year.</returns>
        public static int GetWeekOfYear(DateOnly date)
        {
            // Create a DateTime from the DateOnly
            DateTime dateTime = date.ToDateTime(TimeOnly.MinValue);

            // Use the current culture's calendar
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;

            // Get the week number
            return calendar.GetWeekOfYear(dateTime, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }


    }
}
