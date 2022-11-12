using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.ComponentModel;

namespace VLC.Utils
{
    public static class CookingWeightsAndMeasures
    {

        public static Dictionary<string, string> CommonVolumeMeasuresInMilliliters => new()
        {
            { "Teaspoon",       "5:mL" },
            { "Dessertspoon",   "10:mL" },
            { "Tablespoon",     "15:mL" },
            { "Fluid Ounce",    "30:mL"},
            { "Cup:US",         "240:mL" },
            { "Pint:US",        "473.18:mL" },
            { "Quart:US",       "946.35:mL" },
            { "Gallon:US",      "3785.41:mL" },
            { "Cup:Imp",         "250:mL" },
            { "Pint:Imp",        "568.26:mL" },
            { "Quart:Imp",       "1136.52:mL" },
            { "Gallon:Imp",      "4546.09:mL" }
        };

        public static Dictionary<string, double> CommonIngredientsDensityGramsPerMilliliter => new()
        {
            {"Sugar", 0.8 },
            {"Flour", 0.7 },
            {"Salt", 1.2 },
            {"Butter", 0.9}
        };

        #region Dry and Fluid Measures

        //
        // Suffixed asterisks on some of the "tsp" units in the "Defined" key value indicate that the teaspoon units are defined as 1⁄8 fl oz (4 fl dram),
        // the old 4 tsp = 1 tbsp amount, instead of 1⁄6 fl oz. This definition fits with "barkeepers' teaspoon", and is used in many cocktail recipe books;
        // generally the subdivisions are not so explicitly defined nor named below 1⁄4 tsp in general culinary.
        // This can be verified by comparing the associated values in the "fl oz" column.
        // All other "tsp" units in the "Defined" column are indeed defined as 1⁄6 fl oz, the current 3 tsp = 1 tbsp amount. 
        //

        public static Dictionary<string, string> Drop => new() { { "name", "drop" }, { "abbreviations", "dr. gt. gtt." }, { "defined", "1/96 tsp" }, { "fl oz", "1/576" }, { "mL", "0.0513429" }, { "binary submultiples", "" } };
        public static Dictionary<string, string> Smidgen => new() { { "name", "smidgen" }, { "abbreviations", "smdg. smi." }, { "defined", "1/32 tsp*" }, { "fl oz", "1/256" }, { "mL", "0.115522" }, { "binary submultiples", "2 smidgens = 1 pinch" } };
        public static Dictionary<string, string> Pinch => new() { { "name", "pinch" }, { "abbreviations", "pn." }, { "defined", "1/16 tsp*" }, { "fl oz", "1/128" }, { "mL", "0.231043" }, { "binary submultiples", "2 pinches = 1 dash" } };
        public static Dictionary<string, string> Dash => new() { { "name", "dash" }, { "abbreviations", "ds." }, { "defined", "1/8 tsp*" }, { "fl oz", "1/64" }, { "mL", "0.462086" }, { "binary submultiples", "2 dashes = 1 saltspoon" } };
        public static Dictionary<string, string> Scruple => Saltspoon;
        public static Dictionary<string, string> Saltspoon => new() { { "name", "saltspoon/scruple" }, { "abbreviations", "ssp." }, { "defined", "1/4 tsp*" }, { "fl oz", "1/32" }, { "mL", "0.924173" }, { "binary submultiples", "2 saltspoons = 1 coffeespoon" } };
        public static Dictionary<string, string> Coffeespoon => new() { { "name", "coffeespoon" }, { "abbreviations", "csp." }, { "defined", "1/2 tsp*" }, { "fl oz", "1/16" }, { "mL", "1.84835" }, { "binary submultiples", "2 coffeespoons = 1 teaspoon" } };
        public static Dictionary<string, string> FluidDram => new() { { "name", "fluid dram" }, { "abbreviations", "fl.dr." }, { "defined", "3/4 tsp" }, { "fl oz", "1/8" }, { "mL", "3.69669" }, { "binary submultiples", "" } };
        public static Dictionary<string, string> Teaspoon => new() { { "name", "teaspoon (culinary)" }, { "abbreviations", "tsp. t." }, { "defined", "1/3 tsp" }, { "fl oz", "1/6" }, { "mL", "4.92892" }, { "binary submultiples", " 2 teaspoons = 1 dessertspoon" } };
        public static Dictionary<string, string> Dessertspoon => new() { { "name", "dessertspoon" }, { "abbreviations", "dsp. dssp. dstspn." }, { "defined", "2 tsp" }, { "fl oz", "1/3" }, { "mL", "9.85784" }, { "binary submultiples", "" } };
        public static Dictionary<string, string> Tablespoon => new() { { "name", "tablespoon" }, { "abbreviations", "tbsp. T." }, { "defined", "1/16 C" }, { "fl oz", "1/2" }, { "mL", "14.7868" }, { "binary submultiples", "2 tablespoons = 1 fluid ounce " } };
        public static Dictionary<string, string> FluidOunce => new() { { "name", "fliud ounce" }, { "abbreviations", "fl.oz. oz." }, { "defined", "1/8 C" }, { "fl oz", "1" }, { "mL", "29.5735" }, { "binary submultiples", "2 fluid ounce = 1 wineglass" } };
        public static Dictionary<string, string> Wineglass => new() { { "name", "wineglass" }, { "abbreviations", "wgf." }, { "defined", "1/4 C" }, { "fl oz", "2" }, { "mL", "59.1471" }, { "binary submultiples", "2 wineglasses = 1 teacup" } };
        public static Dictionary<string, string> Gill => Teacup;
        public static Dictionary<string, string> Teacup => new() { { "name", "teacup/gill" }, { "abbreviations", "tcf." }, { "defined", "1/2 C" }, { "fl oz", "4" }, { "mL", "118.294" }, { "binary submultiples", "2 teacups = 1 cup" } };
        public static Dictionary<string, string> Cup => new() { { "name", "cup" }, { "abbreviations", "C" }, { "defined", "1/2 pt" }, { "fl oz", "8" }, { "mL", "236.588" }, { "binary submultiples", "2 cups = 1 pint" } };
        public static Dictionary<string, string> Pint => new() { { "name", "pint" }, { "abbreviations", "pt." }, { "defined", "1/2 qt" }, { "fl oz", "16" }, { "mL", "473.176" }, { "binary submultiples", "2 pints = 1 quart" } };
        public static Dictionary<string, string> Quart => new() { { "name", "quart" }, { "abbreviations", "qt." }, { "defined", "1/4 gal" }, { "fl oz", "32" }, { "mL", "946.353" }, { "binary submultiples", "" } };
        public static Dictionary<string, string> Gallon => new() { { "name", "gallon" }, { "abbreviations", "gal." }, { "defined", "231 cubic inches" }, { "fl oz", "128" }, { "mL", "3785.41" }, { "binary submultiples", "4 quarts = 1 gal" } };

        #endregion 

    }
    public enum ImpUSMassUnit
    {
        oz,
        lb,
    }

    public enum ImpUSLengthUnit
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
        kilo
    }

    public enum MetricUnit
    {
        liter,
        gram,
        meter,
    }
}
