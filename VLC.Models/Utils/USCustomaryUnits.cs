namespace VLC.Utils
{
    public static class USCustomaryUnits
    {
        // TODO: double check the math

        #region US customary volume ratio dictionaries
        public static Dictionary<string, int> OneGallon => new() { { "gallon", 1 }, { "quart", 4 }, { "pint", 8 }, { "cup", 16 }, { "ounce", 128 }, { "Tbsp", 256 }, { "tsp", 768 } };
        public static Dictionary<string, int> OneQuart => new() { { "gallon", 1 / 4 }, { "quart", 1 }, { "pint", 2 }, { "cup", 4 }, { "ounce", 32 }, { "Tbsp", 64 }, { "tsp", 192 } };
        public static Dictionary<string, int> OnePint => new() { { "gallon", 1 / 8 }, { "quart", 1 / 2 }, { "pint", 1 }, { "cup", 2 }, { "ounce", 16 }, { "Tbsp", 32 }, { "tsp", 96 } };
        public static Dictionary<string, int> OneCup => new() { { "gallon", 1 / 16 }, { "quart", 1 / 4 }, { "pint", 1 / 2 }, { "cup", 1 }, { "ounce", 8 }, { "Tbsp", 16 }, { "tsp", 48 } };
        public static Dictionary<string, int> OneOunce => new() { { "gallon", 1 / 128 }, { "quart", 1 / 32 }, { "pint", 1 / 16 }, { "cup", 1 / 8 }, { "ounce", 1 }, { "Tbsp", 2 }, { "tsp", 6 } };
        public static Dictionary<string, int> OneTablespoon => new() { { "gallon", 1 / 256 }, { "quart", 1 / 64 }, { "pint", 1 / 32 }, { "cup", 1 / 16 }, { "ounce", 1 / 2 }, { "Tbsp", 1 }, { "tsp", 3 } };
        public static Dictionary<string, int> OneTeaspoon => new() { { "gallon", 1 / 768 }, { "quart", 1 / 192 }, { "pint", 1 / 96 }, { "cup", 1 / 48 }, { "ounce", 1 / 6 }, { "Tbsp", 1 / 3 }, { "tsp", 1 } };
        #endregion

        #region Measurement System Conversions: Imperial => US customary
        public static double FluidOunce_To_FluidOunceUS(double imp_fl_oz) => imp_fl_oz * 0.96076187;
        public static double Pint_To_PintUS(double pt) => pt * 1.20095229;
        public static double Gallon_To_GallonUS(double gal) => gal * 1.20095223;
        #endregion

        #region Measurement System Conversions:  Metric => US customary
        public static double Milliliters_To_Teaspoons(double mL) => mL / 4.93;
        public static double Milliliters_To_Tablespoons(double mL) => mL / 14.79;
        public static double Milliliters_To_FluidOunces(double mL) => mL / 29.57;
        public static double Milliliters_To_Cups(double mL) => mL / 236.59;
        public static double Liters_To_Cups(double L) => L / 0.23659;
        public static double Milliliters_To_Pints(double mL) => mL / 473.18;
        public static double Liters_To_Pints(double L) => L / 0.47318;
        public static double Milliliters_To_Quarts(double mL) => mL / 946.36;
        public static double Liters_To_Quarts(double L) => L / 0.94636;
        public static double Milliliters_To_Gallons(double mL) => mL / 3.785;
        public static double Grams_To_Ounces(double g) => g / 28.35;
        public static double Grams_To_Pounds(double g) => g / 454;
        public static double Kilograms_To_Pounds(double kg) => kg / 0.454;
        public static double Centimeters_To_Inches(double cm) => cm / 2.54;
        public static double Millimeters_To_Inches(double mm) => mm / 25.4;
        public static double Celsius_To_Fahrenheit(double celsius) => (celsius * 1.8) + 32;
        #endregion

        #region Measurement System Conversions: US customary => Metric
        public static double Teaspoons_To_Milliliters(double tsp) => tsp * 4.93;
        public static double Tablespoons_To_Milliliters(double mL) => mL * 14.79;
        public static double FluidOunces_To_Milliliters(double fl_oz) => fl_oz * 29.57;
        public static double Cups_To_Milliliters(double C) => C * 236.59;
        public static double Cups_To_Liters(double C) => C * 0.236;
        public static double Pints_To_Milliliters(double pt) => pt * 473.18;
        public static double Pints_To_Liters(double pt) => pt * 0.47318;
        public static double Quarts_To_Milliliters(double qt) => qt * 946.36;
        public static double Quarts_To_Liters(double qt) => qt * 0.94636;
        public static double Gallons_To_Liters(double g) => g * 3.785;
        public static double Ounces_To_Grams(double oz) => oz * 28.35;
        public static double Pounds_To_Grams(double lbs) => lbs * 454;
        public static double Pounds_To_Kilograms(double lbs) => lbs * 0.454;
        public static double Inches_To_Centimeters(double inches) => inches * 2.54;
        public static double Inches_To_Millimeters(double inches) => inches * 25.4;
        public static double Fahrenheit_To_Celsius(double F) => (F - 32) / 1.8;
        #endregion

    }
}
