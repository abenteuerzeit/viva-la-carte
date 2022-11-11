using Humanizer;
using System.Reflection.Metadata;

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

        //public enum ProteinPlan
        //{
        //    A, B, C, D
        //}

        public static double ConvertInchesToCm(double inches) => inches * 2.64;
        public static double ConvertFtToCm(double ft) => ft * 30.48;


        /// <summary>
        /// Use a space to seperate feet and inches. For example: 5' 11".
        /// </summary>
        /// <param name="feetAndInches"></param>
        /// <returns></returns>
        public static double ConvertHeightToCm(string feetAndInches)
        {
            var result = feetAndInches.Split(' ');
            bool isFeetParsed = int.TryParse(result[0].Replace("'", "").Trim(), out int feet);
            bool isInchesParsed = int.TryParse(result[1].Replace("\"", "").Trim(), out int inches);
            if (!isFeetParsed || !isInchesParsed)
            {
                throw new ArgumentOutOfRangeException();
            }
            return ConvertFtToCm(feet) + ConvertInchesToCm(inches);
        }

    }
}
