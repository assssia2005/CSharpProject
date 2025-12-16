namespace CSharpProject
{
    public enum Gender { Male, Female }
    public enum ActivityLevel { Sedentary, LightlyActive, ModeratelyActive, VeryActive, ExtraActive }

    public static class CalorieCalculator
    {
        // Activity multipliers for TDEE calculation
        private static readonly Dictionary<ActivityLevel, double> ActivityMultipliers = new Dictionary<ActivityLevel, double>
        {
            { ActivityLevel.Sedentary, 1.2 },
            { ActivityLevel.LightlyActive, 1.375 },
            { ActivityLevel.ModeratelyActive, 1.55 },
            { ActivityLevel.VeryActive, 1.725 },
            { ActivityLevel.ExtraActive, 1.9 }
        };

        // Calculates Basal Metabolic Rate (BMR) using the Mifflin-St Jeor formula
        public static double CalculateMifflinStJeorBMR(Gender gender, double weightKg, double heightCm, int age)
        {
            if (gender == Gender.Male)
            {
                return (10 * weightKg) + (6.25 * heightCm) - (5 * age) + 5;
            }
            else
            {
                return (10 * weightKg) + (6.25 * heightCm) - (5 * age) - 161;
            }
        }

        // Calculates Basal Metabolic Rate (BMR) using the Revised Harris-Benedict formula
        public static double CalculateRevisedHarrisBenedictBMR(Gender gender, double weightKg, double heightCm, int age)
        {
            if (gender == Gender.Male)
            {
                return 88.362 + (13.397 * weightKg) + (4.799 * heightCm) - (5.677 * age);
            }
            else
            {
                return 447.593 + (9.247 * weightKg) + (3.098 * heightCm) - (4.330 * age);
            }
        }

        // Calculates Basal Metabolic Rate (BMR) using the Katch-McArdle formula
        public static double CalculateKatchMcArdleBMR(double weightKg, double bodyFatPercentage)
        {
            double leanBodyMass = weightKg * (1 - (bodyFatPercentage / 100.0));
            return 370 + (21.6 * leanBodyMass);
        }

        // Calculates Total Daily Energy Expenditure (TDEE)
        public static double CalculateTDEE(double bmr, ActivityLevel activityLevel)
        {
            return bmr * ActivityMultipliers[activityLevel];
        }
    }
}
