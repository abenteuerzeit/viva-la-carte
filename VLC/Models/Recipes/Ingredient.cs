using System.ComponentModel.DataAnnotations.Schema;

namespace VLC.Models.Recipes
{
    public class Ingredient
    {
        // Examples: 0: Egg, 1: Pepsi, 2: Pasta 3: Pasta Sauce 4: Rice
        // Add 1 egg(s); Add 1/2 cup of Pepsi; Add 100g of Pasta ; Add 10oz Pasta Sauce ; Add 0.25 kg Rice

        public int Id { get; set; } // 0, 1, 2, 3, 4

        [ForeignKey("Product")]
        public int ProductId { get; set; } // Id from product to be purchased
        public double IngredientUnitValue { get; set; } // float
        public double IsProductUnitOfMeasruement { get; set; } // ? egg : () => GetUnitOfMeasurement()
        public bool IsInFoodMeasurementUnits { get; set; } // ? cup : () => GetUnitOfMeasurement()
        public bool IsInMetricUnits { get; set; } // mg
        //public MetricPrefix MetricPrefix { get; set; } // m-
        //public MetricUnit MetricUnit { get; set; } // -g
        //public FoodMeasurementUnit FoodMeasurementUnit { get; set; }
        //public ImperialLengthUnit ImperialLengthUnit { get; set; }
        //public ImperialMassUnit ImperialMassUnit { get; set; }

    }
}
