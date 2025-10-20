namespace EmprestimoLivros.Helper
{
    public static class DataHelper
    {
        public static DateTime ToDateTimeBrasilia(this DateTime data)
        {
            TimeZoneInfo hrBrasilia = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");

            return TimeZoneInfo.ConvertTimeFromUtc(data, hrBrasilia);
        }
    }
}
