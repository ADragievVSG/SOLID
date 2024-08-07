namespace DependencyExample.Classes
{
    public class Promotion
    {
        public string GetPromotion()
        {
            DateTime today = DateTime.Now;

            if (today.DayOfWeek == DayOfWeek.Friday)
            {
                return "Happy Friday Promotion";
            }
            else if (today.DayOfWeek == DayOfWeek.Saturday || today.DayOfWeek == DayOfWeek.Sunday)
            {
                return "Weekend Promotion";
            }
            return "No Promotion";
        }
    }
}
