namespace VLC.Utils
{
    public partial class MealManagerUtility
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
