namespace CSharpProject
{
    // Extends the base Food class to include information specific to a logged entry
    public class LoggedFood : Food
    {
        // The unique ID of this specific entry in the daily_log table
        public int Id { get; set; }

        // The weight of the food consumed, in grams
        public double Weight { get; set; }

        // A display-friendly string that includes the food name and weight
        // This will be used in the ListBox controls
        public string DisplayName => $"{FoodName} ({Weight}g)";
    }
}
