namespace VLC.Models.Recipes
{
    public static class Utils
    {
        public enum ImperialMassUnit
        {
            oz,
            lb,
        }

        public enum ImperialLengthUnit
        {
            inch,
            foot,
            yard
        }

        public enum TemperatureUnit
        {
            C,
            F
        }

        public enum FoodMeasurementUnit
        {
            pinch,
            dash,
            teaspoon,
            tablespoon,
            fluidOunce,
            cup,
            pint,
            quart,
            gallon
        }

        public enum PanType
        {
            cake,
            baking,
            loaf,
            casserole
        }

        public enum MetricPrefix
        {
            milla,
            centi,
            deci,
            hecto,
            kilog
        }

        public enum MetricUnit
        {
            liter,
            gram,
            meter,
        }
    }
}
