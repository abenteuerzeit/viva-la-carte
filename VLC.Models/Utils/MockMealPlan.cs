using System;
using VLC.Utils.Enums;

namespace VLC.Utils
{
    public static class MockMealPlan
    {
        public static int TotalCalories => 1000;
        public static int MealCount => 2;
        public static Diets Diet => Diets.Mediterranean;
        public static WeightGoal Goals => WeightGoal.Gain;
        public static MeasurementSystem MeasurementSystem => MeasurementSystem.US_Customary;
        public static Gender Gender => Gender.Female;
        public static double Height => 170;
        public static double Weight => 75;
        public static int Age => 18;
        public static BodyFat Bodyfat => BodyFat.High;
        public static ActivityLevel ActivityLevel => ActivityLevel.Very;


    }
}

