using System.Web.Helpers;

namespace VLC.BussinessLogic
{
    public class DietPlanGenerator
    {
        /*  TODO: IMPLEMENT DIET PLAN GENERATOR LOGIC
            Algorithm: https://www.scirp.org/journal/paperinformation.aspx?paperid=66880
        
        ====================[ DIET PLAN GENERATOR ]=====================| 
         TASK 1: Set nutrient ranges
            - All nutrients have a MinAmount, IdealAmount, and MaxAmount 
            - MinAmount = the least amount of that nutrient that will be accepted to accept the meal plan.
                - A default MinAmount is provided for all nutrients.
                - Users can customize the default MinAmount value
            - IdealAmount = the amount of the nutrient that will result in the meal plan receiving a perfect score for the specific nutrient.
            - It is possible for the minimum amount of nutrient value and ideal amount of nutrient avalue to be the same.
            - MaxAmount = (optional) The maximum acceptable amount, above which the meal plan is not acceptable.

         Task 2: Calculate a number to score each nutrient
            - The score is calculated using one of three linear functions
            - The funciton used to calculate the score is selected based on the nutrientAmount
            - The decimal nutrientAmount = the amount of nutrient currently in the meal plan in relation to its MaxAmount, IdealAmount, and MinAmount.

         TASK 3: Write three functions that differ in the “Importance” (the line segment's slope) and intercept used (where it crosses the y-axis, i.e., the 'default score').
            - If nutrientAmount > IdealAmount && nutrientAmount < MaxAmount => use the first function.
            - If nutrientAmount < IdealAmount && nutrientAmount > MinAmount, the second function is used.
            - If nutrientAmount < MinAmount, the third function is used.
            > The user can adjust the importance and defaults
            > You should have 3 distinct ranges and functions to calculate the nutrient score so the meal plan can be customized
            > Importance (aka weight): 1 = a line slope of 1; 2 = a line slope of 2.

         TASK 4: Calculate a number to score the meal plan.
             - MealPlanScore = sum of each nutrient score, i.e.: [NutrientScoreFIRST, ... ,NutrientScoreLAST].sum();
             - If two MealPlanScores have an identical set of nutritional goals,
                    then a larger MSCORE means that the meal plan is more in line with nutritional requirements.

        EXAMPLE: 
          Nutrient    = Calcium,
          Unit        = mg,
          MinAmount   = 1000,
          IdealAmount = 2500,
          MaxAmount   = 5000,
          MealHas     = 1164, (current amount in the meal)
          Importance  = 2
          Intercept   = 1

         Function examples:
            f(x) =  m *     x       + b = y      
                    2 * (1164/2500) + 1 = 1.931
                    1 * (1164/2500) + 1 = 1.466

        FORMULAS for the function(nutrientAmount). 
         - returns: the nutrient score,
         - parameter: the nutrient amount. 
         - if MaxAmount >= n > idealAmount;
                Function 1: NutrientLessThanMaxAmount(n) => (-1 * Importance * ( n / maxAmount)) + Intercept;
         - if idealAmount >= n > MinAmount; 
                Function 2: NutrientGreaterThanMinAmount(n) => Importance * ( n / idealAmount) + Intercept;
         - if MinAmount >= n >= 0;
                Function 3: NutrientLessThanMinAmount(n) => Importance * ( n / minAmount) + Intercept; 


        ====================[ IMPLEMENTATION ]=====================| 
         Get Nutrition Data for foods
         Get a list of 100 foods with the highest amount of each nutrient from the USDA National Nutrient Database
         var plan = new MealPlan();
         Add foods to increse the meal plan's nutrient's sum score. 
         Iterate over each nutrient to check
         For each nutrient, select a random food from a list of 100 foods that have the most amount of the nutrient. 
         Add the random item to the meal plan and recalculate the meal plan's total score.
         If the food doesn't make any other nutrient amount to go over the upper bound for that nutrient, then keep it.
         If the food makes any other nutrient amount to go over the upper bound for that nutrient, then remove it and select a new food item.
              Record the number of times a nutrient cause a food rejection.
              If a nutrient causes a food rejection four or more times, remove the food item from the meal plan with the highest amount of that nutrient.
              
         Select the next nutrient and repeat. 
         Add foods until each nutrient goes over its lower bound. 
         Meal plan is complete if all nutrients meet minimum requirements.


        ====================[ IMPROVEMENTS ]=====================|
         A model such as SSC3gd could be used to pare down the food list prior to it being passed to this method.
         A pantry feature that would allow users to track the foods that they currently have in their pantry/house.
         Use pantry data, along with the food list for generated meal plans, to provide the users with a shopping list.
         Present users with nutritional goal templates, an example being “Post race recovery”.
              The template would recommend the MinAmount, IdealAmount, and MaxAmount, and would insert the nutrient defaults and weights.
         The website provides the user with recipes, as opposed to a simple food list.
         The recipes would be user submitted, along with the selecting what foods from the USDA database to use.

        ====================[ PROGRAM EXAMPLE RUN for Calcium ]=====================|
        1) Looking for Vitamin C.
        2) Adding Peppers, sweet, green, cooked, boiled, drained, without salt.
        3) Looking for Vitamin B1 (thiamine).
        4) Adding WORTHINGTON Dinner Roast, frozen, unprepared.
        5) Looking for Vitamin B2 (riboflavin).
        6) Adding Spaghetti with meat sauce, frozen entrée.
        7) Looking for Vitamin B3 (niacin).
        8) Adding Fast foods, submarine sandwich, turkey, roast beef and ham on white bread with lettuce and tomato.
        9) Looking for Pantothenic Acid.
        10) Adding Chicken, liver, all classes, cooked, pan-fried.
        11) Looking for Calcium.
        12) Exceeded Sodium (1). 
        13) Looking for Vitamin K.
        14) Exceeded Sodium (2).
        15) Looking for Magnesium.
        16) Adding Peanuts, Virginia, oil-roasted, without salt.
        17) Looking for Potassium.
        18) Adding Plums, dried (prunes), uncooked.
        19) Looking for Zinc.
        20) Exceeded Sodium (3).
        21) Looking for Vitamin E.
        22) Exceeded Sodium (4).
        23) The score is: 5.52796417989.
        24) Removing a food for Sodium.
        25) Looking for Vitamin C.
        26) Adding Orange juice, raw.
        27) Looking for Calcium.
        28) Adding CARRABBA’S ITALIAN GRILL, cheese ravioli with marinara sauce.
        29) Looking for Vitamin K.
        30) Exceeded Sodium (1).
        31) Looking for Magnesium.
        32) Exceeded Sodium (2).
        33) Looking for Potassium.
        34) Adding Apricots, dehydrated (low-moisture), sulfured, stewed.
        35) Looking for Zinc.
        36) Exceeded Sodium (3).
        37) Looking for Vitamin E.
        38) Adding Oil, sunflower, linoleic (less than 60%).
        39) This report is for date: 16/11/22. The score is: 7.55021904762.
         
        |=====================[ OUTPUT ]=====================|
        1) Elapsed time (ms): 329500.334978.
        2) This report is for date: 16/11/22. The score is: 19.7325233333.
        3) Nutrient List.
            1) Histidine = N/A DRV (2.068 g/0).
            2) Vitamin C = 40.7% of Ideal (609.9 mg/1.2198).
            3) Vitamin B1 (thiamine) = 84.4% of Ideal (2.111 mg/2.5332).
            4) Vitamin B2 (riboflavin) = 174.6% of Ideal (4.015 mg/0.330833333333).
            5) Vitamin B3 (niacin) = 69.4% of Ideal (20.81 mg/2.081).
            6) Pantothenic Acid = 54.2% of Ideal (10.837 mg/1.62555).
            7) Folate = 197.8% of Ideal (989.0 ug/0.6044).
            8) Calcium = 107.8% of Ideal (2694.0 mg/3.6896).
            9) Vitamin K = 24.8% of Ideal (124.1 ug/0.7446).
            10) Iron = 73.7% of Ideal (22.12 mg/2.212).
            11) Magnesium = 87.2% of Ideal (698.0 mg/2.6175).
            12) Phosphorus = 246.1% of Ideal (2461.0 mg/0.0156).
            13) Potassium = 153.1% of Ideal (6890.0 mg/−3.92142857143).
            14) Sodium = 136.3% of Ideal (1363.0 mg/0.0264285714286).
            15) Zinc = 107.1% of Ideal (18.2 mg/0.636).
            16) Copper = 49.6% of Ideal (2.978 mg/1.489).
            17) Fluoride = 0.0% of Ideal (0 ug/0).
            18) Manganese = 178.7% of Ideal (5.36 mg/0.464).
            19) Selenium = 72.0% of Ideal (72.0 ug/2.16).
            20) Vitamin A = 111.1% of Ideal (8334.0 IU/0.66664).
            21) Vitamin E = 154.1% of Ideal (46.22 mg/0.5378).
            22) Vitamin D = 0.4% of Ideal (8.0 IU/0).
            23) Tryptophan = N/A DRV (0.904 g/0).
            24) Threonine = N/A DRV (3.2 g/0).
            25) Isoleucine = N/A DRV (3.487 g/0).
            26) Leucine = N/A DRV (6.107 g/0).
            27) Lysine = N/A DRV (4.907 g/0).
            28) Methionine = N/A DRV (0.914 g/0).
            29) Phenylalanine = N/A DRV (1.002 g/0).
            30) Valine = N/A DRV (3.732 g/0).
        4) Food List.
            1) Beverages, MONSTER energy drink, low carb-Beverages.
            2) Broccoli, frozen, chopped, unprepared-Vegetables and Vegetable Products.
            3) Beans, white, mature seeds, raw-Legumes and Legume Products.
            4) Desserts, mousse, chocolate, prepared-from-recipe-Sweets.
            5) Strawberries, frozen, sweetened, sliced-Fruits and Fruit Juices.
            6) Peppers, sweet, red, raw-Vegetables and Vegetable Products.
            7) Lupins, mature seeds, raw-Legumes and Legume Products.
            8) CAMPBELL’S, V8 Vegetable Juice, Essential Antioxidants V8-Vegetables and Vegetable Products.
            9) Pepper, banana, raw-Vegetables and Vegetable Products.
            10) Peppers, hot chili, green, raw-Vegetables and Vegetable Products.
            11) Whey, acid, dried-Dairy and Egg Products.
            12) Oil, sunflower, high oleic (70% and over)-Fats and Oils.
            13) Mushrooms, white, cooked, boiled, drained, without salt-Vegetables and Vegetable Products.
        */
    }
}
