namespace VLC.Utils
{
    public class MealManagerUtility
    {        /*
         
        Current diet type: 
        I want to: Lose weight, maintain, build muscle
        Units of Measruement: US, UK, Metric
        GenderOption: Male Female
        Height:
        Weight: 
        Age: 
        Bodyfat: <14%, 14% - 22%, 22%< 
        ActivityLevel: Sedentary, Lightly, Moderately, Very, Extremely
        isWeightGoalSet: ye/no
        WeightGoal: kgs
        Weight Change Rate: double Lose X kgs per week
         
         */
        public enum Rating
        {
            reject, dislike, like, love, favorite
        }

        public enum WeightGoal
        {
            Lose,
            Maintain,
            Gain
        }

        public enum MeasurementSystem
        {
            Metric,
            US_Customary,
            British_Imperial
        }

        public enum Gender
        {
            Male,
            Female
        }

        public enum BodyFat
        {
            Low,
            Medium,
            High
        }
        public enum ACE_BodyFat
        {
            EssentialFat, //Lean, // Low,
            Atheles, //Slim, //Healthy,
            Fitness, //Fit, //Fair,
            Average, //High,
            Obese, //VeryHigh

        }

        public enum ActivityLevel
        {
            Sedentary, Lightly, Moderately, Very, Extremely
        }

        public enum Diets
        {
            Whatever, Paleo, Vegetarian, Vegan, Keto, Mediterranean
        }

    }
}
