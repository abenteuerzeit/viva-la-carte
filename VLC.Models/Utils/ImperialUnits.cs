using System.Data;

namespace VLC.Utils
{
    public static class ImperialUnits
    {
        // TODO: check conversions for correctness, copied from US system

        // Common ratios
        // 1 pt = 20 fl oz = 0.568L
        // 1 gal =  8 pt = 4.5461L


        #region Measurement System Conversions: Imperial => US customary
        public static double FluidOunceUS_To_FluidOunceImp(double us_fl_oz) => us_fl_oz * 1.04084064;
        public static double PintUS_To_PintImp(double pt) => pt * 0.832672547;
        public static double GallonUS_To_GallonImp(double gal) => gal * 0.832672584;

        #endregion

        #region Measurement System Conversions:  Metric => British Imperial
        public static double Millilitres_To_Teaspoons(double mL) => mL / 4.93;
        public static double Millilitres_To_Tablespoons(double mL) => mL / 14.79;
        public static double Millilitres_To_FluidOunces(double mL) => mL / 28.41;
        public static double Millilitres_To_Cups(double mL) => mL / 236.59;
        public static double Litres_To_Cups(double L) => L / 0.23659;
        public static double Millilitres_To_Pints(double mL) => mL / 568.26;
        public static double Litres_To_Pints(double L) => L / 0.56826;
        public static double Millilitres_To_Quarts(double mL) => mL / 1137;
        public static double Litres_To_Quarts(double L) => L / 1.137;
        public static double Grams_To_Ounces(double g) => g / 28.35;
        public static double Grams_To_Pounds(double g) => g / 454;
        public static double Kilograms_To_Pounds(double kg) => kg / 0.454;
        public static double Centimeters_To_Inches(double cm) => cm / 2.54;
        public static double Millimeters_To_Inches(double mL) => mL / 25.4;
        public static double Celsius_To_Fahrenheit(double celsius) => (celsius * 1.8) + 32;

        #endregion

        #region Imperial => Other Imperial Units Conversions
        public static double Stones_To_Pounds(double stone) => stone * 14;
        public static double Pounds_To_Stones(double lbs) => lbs / 14;
        #endregion

        #region Measurement System Conversions: British Imperial => Metric
        public static double Teaspoons_To_Millilitres(double tsp) => tsp * 4.93;
        public static double Tablespoons_To_Millilitres(double tbsp) => tbsp * 14.79;
        public static double FluidOunces_To_Millilitres(double fl_oz) => fl_oz * 28.413;
        public static double Cups_To_Millilitres(double C) => C * 236.59;
        public static double Cups_To_Litres(double C) => C * 0.236;
        public static double Pints_To_Millilitres(double pt) => pt * 568.26;
        public static double Pints_To_Litres(double pt) => pt * 0.56826;
        public static double Quarts_To_Millilitres(double qt) => qt * 1137;
        public static double Quarts_To_Litres(double qt) => qt * 1.137;
        public static double Gallons_To_Litres(double g) => g * 4.546;
        public static double Ounces_To_Grams(double oz) => oz * 28.35;
        public static double Pounds_To_Grams(double lbs) => lbs * 454;
        public static double Pounds_To_Kilograms(double lbs) => lbs * 0.454;
        public static double Stones_To_Kilograms(double stone) => stone * 6.3503;
        public static double Inches_To_Centimeters(double inches) => inches * 2.54;
        public static double Inches_To_Millimeters(double inches) => inches * 25.4;
        public static double Fahrenheit_To_Celsius(double F) => (F - 32) / 1.8;
        #endregion



        #region Baking temperature gas marks  
        public static int GasMarkQuarterInCelsius => 110;
        public static int GasMarkHalfInCelsius => 130;
        public static int GasMarkOneInCelsius => 140;
        public static int GasMarkTwoInCelsius => 150;
        public static int GasMarkThreeInCelsius => 170;
        public static int GasMarkFourInCelsius => 180;
        public static int GasMarkFiveInCelsius => 190;
        public static int GasMarkSixInCelsius => 200;
        public static int GasMarkSevenInCelsius => 230;
        public static int GasMarkEightInCelsius => 240;
        #endregion
    }
}
