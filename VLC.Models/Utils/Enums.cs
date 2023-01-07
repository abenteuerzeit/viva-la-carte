using System;
namespace VLC.Utils.Enums
{
    public enum Diets
    {
        Whatever, Paleo, Vegetarian, Vegan, Keto, Mediterranean
    }

    public enum ActivityLevel
    {
        Sedentary, Lightly, Moderately, Very, Extremely
    }

    public enum Difficulty
    {
        easy, normal, hard
    }

    public enum Rating
    {
        none, reject, dislike, like, love, favorite
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
}

