# A free tool to allow the average health-conscience consumer a way to make positive food choices tailored to a set of nutritional goals

## User experience, Story time! 

Characters
— Victoria works at Viva La Carte,
— James is a customer

James wants to simplify his meal planning.  In fact, he wishes he had his own personal nutritionist who would help him plan well-balanced meals for the week. At the same time, the nutritionist should know which foods James likes to eat and which foods he is allergic to or just doesn't like, or which foods he doesn't feel like eating at any particular moment. 

Here, the nutritionist shows James a meal plan for the week. Now, James can substitute meals to suit his tastes, or he just accepts whatever the nutritionist actually recommends. In addition, he can tell the nutritionist which brands he prefers over others.

So James goes to Victoria's Shopping Service with the shopping list he needs to get the foods set from his meal plan. When he gives Victoria his list, she gets all the products he needs. Victoria shows James how many calories each item has and how the items compare to each other based on a standard metric, such as kcal per 100g. The prices in Victoria's store are displayed last and are viewed as the least important. Victoria makes it a priority to be familiar with her customers personally. That's why when she sees James for the first time, she first asks him his name. Chatting helps Victoria figure out exactly the type of food James likes and dislikes, and beyond that, she indulges in gossip. For example, she tells James about what her other customers have bought recently, what his friends got, and she can provide James with his entire grocery shopping history for easy reference. She suggests that James might want to replace items or add and remove specific items to or from his shopping cart. 

James has all the items he wants. He purchases them. Victoria takes note and thanks James. She asks him if he would like to set up his order for repeated delivery. James says yes, but he would need to modify some things. Victoria notes that and tells James about how they could arrange regular deliveries. 

## Outline of Functionality

1. Register an account, login and logout
2. Enter personal data needed by the nutritionist.
3. Enter health goals and food and brand preferences
4. Generate a meal plan for a week. The customer can change the period. 
5. Edit meal plan. Substitute parts by regenerating sections of the plan. E.g., for just one day, or just one meal. 


# DIET PLAN GENERATOR LOGIC 

The NutritionFacts, Nutrient, and MealPlan classes are used to store and manage data on nutrients and foods, while the MealPlanGenerator class is used to generate personalized meal plans based on the nutritional requirements and food data stored in the other classes.

1. You can use the NutritionFacts class to store information about the nutritional content of foods. This class has properties for serving size, calories, and various macronutrients and micronutrients. It also has methods for getting the macronutrient and micronutrient dictionaries.
2. The Nutrient class can be used to store information about the nutritional requirements of a person. It has properties for the name of the nutrient, the minimum, ideal, and maximum quantities of the nutrient, the current quantity of the nutrient in the person's diet, and the priority of the nutrient. It also has methods for calculating the score of the nutrient based on the current quantity and for checking if the nutrient requirements are met.
3. The MealPlan class can be used to store information about a personalized meal plan. It has a list of foods and a list of nutrients. It also has methods for calculating the score of the meal plan, checking if the meal plan is acceptable, selecting a food item, and adding the food item to the meal plan.
4. The MealPlanGenerator class can be used to generate a personalized meal plan that meets specific nutritional requirements. It has a MealPlan object, a list of Nutrient objects, and a list of top 100 foods. It also has methods for loading nutrient data from a database or API, generating the meal plan by selecting and adding foods, and calculating the nutrient content of a food.

To implement these classes and methods, you can use a combination of the C# programming language, the .NET framework, and a database or API for storing and accessing nutritional data. You can also use arrow functions to simplify your code and make it more readable.

1. Start the program and load the data on the nutrients that are considered in the meal plan, including their minimum, ideal, and maximum quantities.
2. Select a random food item from a list of the top 100 foods that contain the next unmet nutrient in the meal plan.
3. Check if the selected food matches the criteria for the ideal quantity of the nutrient in question.
4. If the food matches the criteria, add it to a food list and check if all the nutrient requirements in the list are met. If they are, end the program. If not, go back to step 2 to select another food item.
5. If the food does not match the criteria, reject the food and increment the iterator. If there are more than 100 iterations, go back to step 2 to select a different food item.
6 .Calculate the nutrient scores for the meal plan using the linear functions described in the algorithm. Sum the scores for each nutrient to get the overall mealPlanScore.
7. Use the mealPlanScore to evaluate the nutritional value of the meal plan and make adjustments as needed to meet the individual's nutritional goals.

To make the algorithm faster, one possible approach is to use a more efficient method for selecting food items that meet the nutritional goals. For example, instead of randomly selecting food items from a list of the top 100 foods, the algorithm could use a search algorithm to find the food items that most closely match the nutritional requirements.

This would allow the algorithm to quickly find the optimal combination of foods that meet the nutritional goals, without the need for multiple iterations. Additionally, using a database to store and manage the data on nutrients and foods can also improve the efficiency of the algorithm, as it allows for more efficient data retrieval and manipulation.


### Steps 

1. Create classes for NutritionFacts, Nutrient, MealPlan, and MealPlanGenerator. These classes should have the properties, methods, and interfaces as described in the project description.
2. Implement the GenerateMealPlan method in the MealPlanGenerator class. This method should generate a personalized meal plan based on the nutritional requirements and food data stored in the MealPlanGenerator object.
3. Implement the MealPlanController class in your ASP.NET MVC project. The MealPlanController class should have an GenerateMealPlan action method that takes a MealPlanGenerator object as an input parameter and returns the generated meal plan as a JSON response.
4. Implement the view in your ASP.NET MVC project to display the JSON object that the GenerateMealPlan action method returns. You can use the Json method of the Controller class to convert the JSON object to a string and display it in the view.

Once you have implemented these steps, you should have a working implementation of the project. You can then use the generated meal plan to evaluate the nutritional value of a person's diet and make adjustments as needed to meet their nutritional goals.


### Save plan 

To allow a user to save the generated meal plan, you can add a database to your ASP.NET MVC project and use it to store the meal plan data.

Here is an example of how you can do this:

In your ASP.NET MVC project, create a new database and a MealPlan table in the database to store the meal plan data. The MealPlan table should have columns to store the data for the Foods and Nutrients properties of the MealPlan class.

In the MealPlanController class, create a new action method called SaveMealPlan that takes a MealPlan object as an input parameter.

    public class MealPlanController : Controller
    {
        public ActionResult SaveMealPlan(MealPlan mealPlan)
        {
            // Add your code here
        }
    }
    In the SaveMealPlan action method, use Entity Framework to connect to the database and insert the data from the mealPlan object into the MealPlan table.
    Copy code
    public class MealPlanController : Controller
    {
        public ActionResult SaveMealPlan(MealPlan mealPlan)
        {
            using (var context = new YourDbContext())
            {
                context.MealPlans.Add(mealPlan);
                context.SaveChanges();
            }
    
            // Add your code here
        }
    }

To save the meal plan in the SaveMealPlan action method, you can use Entity Framework to connect to the database and insert the data from the mealPlan object into the MealPlan table.
In the SaveMealPlan action method, return a success message or a JSON response to confirm that the meal plan was saved successfully.

    public class MealPlanController : Controller
    {
        public ActionResult SaveMealPlan(MealPlan mealPlan)
        {
            using (var context = new YourDbContext())
            {
                context.MealPlans.Add(mealPlan);
                context.SaveChanges();
            }
    
            // Add your code here
        }
    }
    
In this example, the SaveMealPlan action method takes a MealPlan object as an input parameter. The action method uses Entity Framework to connect to the database and insert the data from the mealPlan object into the MealPlan table. The SaveChanges method is then called to save the changes to the database.

After the meal plan is saved, you can add additional code in the SaveMealPlan action method to return a success message or a JSON response to confirm that the meal plan was saved successfully.

For example, you can use the Json method of the Controller class to return a JSON response containing a success message:

    public class MealPlanController : Controller
    {
        public ActionResult SaveMealPlan(MealPlan mealPlan)
        {
            using (var context = new YourDbContext())
            {
                context.MealPlans.Add(mealPlan);
                context.SaveChanges();
            }
    
            return Json("Meal plan saved successfully");
        }
    }

In this example, the Json method is used to return a JSON response containing a success message. This JSON response can be used in the view to confirm that the meal plan was saved successfully

### Connect to Edamame 

To use the data from the Edamame Recipes API to generate the meal plan, you can create a Food class to represent the data for a food item from the API, and use the MealPlanGenerator class to select and add foods from the API to the meal plan.

Here is an example of how you can do this:

Create a Food class to represent the data for a food item from the API. The Food class should have properties to store the data for the food's name, serving size, calories, and various macronutrients and micronutrients. It should also have methods to get the macronutrient and micronutrient dictionaries.

    public class Food
    {
        public string Name { get; set; }
        public int ServingSize { get; set; }
        public int Calories { get; set; }
    
        public Dictionary<string, int> Macronutrients { get; set; }
        public Dictionary<string, int> Micronutrients { get; set; }
    
        public Dictionary<string, int> GetMacronutrientDictionary()
        {
            // Add your code here
        }
    
        public Dictionary<string, int> GetMicronutrientDictionary()
        {
            // Add your code here
        }
    }

Use the MealPlanGenerator class to select and add foods from the API to the meal plan. The MealPlanGenerator class should have a Foods property to store the list of foods from the API, and a GenerateMealPlan method that selects and adds foods to the meal plan based on the nutritional requirements.

To use the MealPlanGenerator class to select and add foods from the API to the meal plan, you can use the GenerateMealPlan method of the MealPlanGenerator class to select and add foods to the meal plan based on the nutritional requirements.

Here is an example of how you can do this:

In the GenerateMealPlan method of the MealPlanGenerator class, create a list of Food objects to store the foods from the API.

    public class MealPlanGenerator
    {
        private List<Food> Foods { get; set; }
    
        public MealPlan GenerateMealPlan()
        {
            var foods = new List<Food>();
    
            // Add your code here
        }
    }

In the GenerateMealPlan method, use the HttpClient class to send a GET request to the 

    Edamame Recipes API to retrieve the data for the top 100 foods.
    public class MealPlanGenerator
    {
        private List<Food> Foods { get; set; }
    
        public MealPlan GenerateMealPlan()
        {
            var foods = new List<Food>();
    
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://api.edamam.com/search?q=*&app_id=xxxx&app_key=xxxx&to=100");
    
                // Add your code here
            }
        }
    }

In the GenerateMealPlan method, deserialize the JSON response from the API into a list of Food objects.

     public class MealPlanGenerator
      {
        private List<Food> Foods { get; set; }
    
        public MealPlanGenerator()
        {
            Foods = new List<Food>();
        }
    
        public MealPlan GenerateMealPlan()
        {
            // Use the HttpClient class to send a GET request to the Edamame Recipes API
            using (var httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync("https://api.edamam.com/search?q=*&app_id=xxxx&app_key=xxxx&to=100");
    
                // Deserialize the JSON response from the API into a list of Food objects
                var json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<List<Food>>(json);
    
                Foods.AddRange(result);
            }
    
            // Select and add foods to the meal plan based on the nutritional requirements
            var mealPlan = new MealPlan();
    
            foreach (var nutrient in Nutrients)
            {
                var food = SelectFood(nutrient);
                if (food != null)
                {
                    mealPlan.AddFood(food);
    
                    if (mealPlan.IsAcceptable())
                    {
                        break;
                    }
                }
            }
    
            return mealPlan;
        }
    
        private Food SelectFood(Nutrient nutrient)
        {
            // Find the food with the closest match to the nutritional requirements of the given nutrient
            var food = Foods
                .OrderBy(f => Math.Abs(f.GetMacronutrientDictionary()[nutrient.Name] - nutrient.IdealAmount))
                .FirstOrDefault();
        
            // Check if the selected food matches the criteria for the ideal quantity of the nutrient
            if (food != null && food.GetMacronutrientDictionary()[nutrient.Name] >= nutrient.MinAmount && food.GetMacronutrientDictionary()[nutrient.Name] <= nutrient.MaxAmount)
            {
                return food;
            }
        
            return null;
        }
    }
    
In this example, the SelectFood method takes a Nutrient object as an input parameter and uses a search algorithm to find the food item with the closest match to the nutritional requirements of the given nutrient. The OrderBy method is used to sort the list of foods by the difference between the amount of the given nutrient in each food and the ideal amount of the nutrient. The FirstOrDefault method is then used to select the first food in the sorted list.

After the food is selected, the SelectFood method checks if the selected food matches the criteria for the ideal quantity of the nutrient. If the selected food matches the criteria, it is returned by the SelectFood method. If the selected food does not match the criteria, null is returned.

You can modify this implementation to use different search algorithms or criteria for selecting the food items that most closely match the nutritional requirements

## Project Tasks

### TASK 1: Set nutrient ranges
- All nutrients have a MinAmount, IdealAmount, and MaxAmount 
- MinAmount = the least amount of that nutrient that will be accepted to accept the meal plan.
    - A default MinAmount is provided for all nutrients.
    - Users can customize the default MinAmount value
- IdealAmount = the amount of the nutrient that will result in the meal plan receiving a perfect score for the specific nutrient.
- It is possible for the minimum amount of nutrient value and ideal amount of nutrient value to be the same.
- MaxAmount = (optional) The maximum acceptable amount, above which the meal plan is not acceptable.

### TASK 2: Calculate a number to score each nutrient
- The score is calculated using one of three linear functions
- The function used to calculate the score is selected based on the nutrientAmount
- The decimal nutrientAmount = the amount of nutrient currently in the meal plan in relation to its MaxAmount, IdealAmount, and MinAmount.

### TASK 3: Write three functions that differ in the “Importance” (the line segment's slope) and intercept used (where it crosses the y-axis, i.e., the 'default score').
    - If nutrientAmount > IdealAmount && nutrientAmount < MaxAmount → use the first function.
    - If nutrientAmount < IdealAmount && nutrientAmount > MinAmount, the second function is used.
    - If nutrientAmount < MinAmount, the third function is used.
    > The user can adjust the importance and defaults
    > You should have 3 distinct ranges and functions to calculate the nutrient score so the meal plan can be customized
    > Importance (aka weight): 1 = a line slope of 1; 2 = a line slope of 2.

### TASK 4: Calculate a number to score the meal plan.
     - MealPlanScore = sum of each nutrient score, i.e.: [NutrientScoreFIRST, … , NutrientScoreLAST].sum();
     - If two MealPlanScores have an identical set of nutritional goals,
            then a larger score means that the meal plan is more in line with nutritional requirements.

### EXAMPLE: 
  Nutrient = Calcium,
  Unit = mg,
  MinAmount = 1000,
  IdealAmount = 2500,
  MaxAmount = 5000,
  MealHas = 1164, (current amount in the meal)
  Importance = 2
  Intercept = 1

### Function examples:
   - f(x) =  mx+b      
   - function(param) = importance * (param) + intercept (the default score) 
       → returns the value of y
   - function(param) = 2 * (1164/2500) + 1 
       → returns 1.931
   - function(param) = 1 * (1164/2500) + 1 
       → returns 1.466

### FORMULAS for the function(nutrientAmount). 
 - returns: the nutrient score,
 - parameter: the nutrient amount. 
 - if MaxAmount >= n > idealAmount;
        Function 1: NutrientLessThanMaxAmount(n) ⇒ (-1 * Importance * (n / maxAmount)) + Intercept;
 - if idealAmount >= n > MinAmount; 
        Function 2: NutrientGreaterThanMinAmount(n) ⇒ Importance * (n / idealAmount) + Intercept;
 - if MinAmount >= n >= 0;
        Function 3: NutrientLessThanMinAmount(n) ⇒ Importance * (n / minAmount) + Intercept; 


## IMPLEMENTATION
1. Get Nutrition Data for foods
2.  Get a list of 100 foods with the highest amount of each nutrient from the USDA National Nutrient Database
3.  var plan = new MealPlan();
4.  Add foods to increse the meal plan's nutrient's sum score. 
5. Iterate over each nutrient to check
6.  For each nutrient, select a random food from a list of 100 foods that have the most amount of the nutrient. 
7.  Add the random item to the meal plan and recalculate the meal plan's total score.
8.  If the food doesn't make any other nutrient amount to go over the upper bound for that nutrient, then keep it. 
9.  If the food makes any other nutrient amount to go over the upper bound for that nutrient, then remove it and select a new food item.
10. Record the number of times a nutrient cause a food rejection.
11. If a nutrient causes a food rejection four or more times, remove the food item from the meal plan with the highest amount of that nutrient
12. Select the next nutrient and repeat. 
13. Add foods until each nutrient goes over its lower bound. 
14. Meal plan is complete if all nutrients meet minimum requirements.


## IMPROVEMENTS 
 A model such as SSC3gd could be used to pare down the food list prior to it being passed to this method.
 A pantry feature that would allow users to track the foods that they currently have in their pantry/house.
 Use pantry data, along with the food list for generated meal plans, to provide the users with a shopping list.
 Present users with nutritional goal templates, an example being “Post race recovery”.
      The template would recommend the MinAmount, IdealAmount, and MaxAmount, and would insert the nutrient defaults and weights.
 The website provides the user with recipes, as opposed to a simple food list.
 The recipes would be user submitted, along with the selecting what foods from the USDA database to use.

## PROGRAM EXAMPLE RUN
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
 
## OUTPUT 
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

