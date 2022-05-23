namespace BLL
{
    public class Utilities
    {
        /// <summary>
        /// Format number with thousand separator
        /// </summary>
        /// <param name="number">Number</param>
        /// <param name="currencyUnit">Currency unit</param>
        /// <returns></returns>
        public static string FormatWithThousandSeparator(double number, string currencyUnit = null)
        {
            return string.Format("{0:#,##0}" + (string.IsNullOrEmpty(currencyUnit) ? string.Empty : " " + currencyUnit), number);
        }
    }
}