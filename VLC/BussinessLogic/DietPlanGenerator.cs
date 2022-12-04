//using Humanizer;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Internal;
//using Newtonsoft.Json;
//using NuGet.Packaging.Signing;
//using System;
//using System.ComponentModel.DataAnnotations;
//using System.Threading;
//using VLC.Models.Meals;
//using VLC.Models.Nutrition;
//using static VLC.Models.Nutrition.NutritionFacts;


///*
// You can use the NutritionFacts class to store information about the nutritional content of foods. This class has properties for serving size, calories, and various macronutrients and micronutrients. It also has methods for getting the macronutrient and micronutrient dictionaries.

//The Nutrient class can be used to store information about the nutritional requirements of a person. It has properties for the name of the nutrient, the minimum, ideal, and maximum quantities of the nutrient, the current quantity of the nutrient in the person's diet, and the priority of the nutrient. It also has methods for calculating the score of the nutrient based on the current quantity and for checking if the nutrient requirements are met.

//The MealPlan class can be used to store information about a personalized meal plan. It has a list of foods and a list of nutrients. It also has methods for calculating the score of the meal plan, checking if the meal plan is acceptable, selecting a food item, and adding the food item to the meal plan.

//The MealPlanGenerator class can be used to generate a personalized meal plan that meets specific nutritional requirements. It has a MealPlan object, a list of Nutrient objects, and a list of top 100 foods. It also has methods for loading nutrient data from a database or API, generating the meal plan by selecting and adding foods, and calculating the nutrient content of a food.

//To implement these classes and methods, you can use a combination of the C# programming language, the .NET framework, and a database or API for storing and accessing nutritional data. You can also use arrow functions to simplify your code and make it more readable.
// */

//// 1. Start the program and load the data on the nutrients that are considered in the meal plan, including their minimum, ideal, and maximum quantities.

//// 2. Select a random food item from a list of the top 100 foods that contain the next unmet nutrient in the meal plan.

//// 3. Check if the selected food matches the criteria for the ideal quantity of the nutrient in question.

//// 4. If the food matches the criteria, add it to a food list and check if all the nutrient requirements in the list are met. If they are, end the program. If not, go back to step 2 to select another food item.

//// 5. If the food does not match the criteria, reject the food and increment the iterator. If there are more than 100 iterations, go back to step 2 to select a different food item.

//// 6 .Calculate the nutrient scores for the meal plan using the linear functions described in the algorithm. Sum the scores for each nutrient to get the overall mealPlanScore.

//// 7. Use the mealPlanScore to evaluate the nutritional value of the meal plan and make adjustments as needed to meet the individual's nutritional goals.

////To make the algorithm faster, one possible approach is to use a more efficient method for selecting food items that meet the nutritional goals.
////For example, instead of randomly selecting food items from a list of the top 100 foods, the algorithm could use a search algorithm to find the food items that most closely match the nutritional requirements.
////This would allow the algorithm to quickly find the optimal combination of foods that meet the nutritional goals, without the need for multiple iterations. Additionally,
////using a database to store and manage the data on nutrients and foods can also improve the efficiency of the algorithm, as it allows for more efficient data retrieval and manipulation.

//// TODO: add additional properties to your Nutrient and MealPlan classes to store this information, and use it in your meal plan generation methods to customize the generated meal plan. You could also add additional methods to your MealPlanGenerator class to calculate the individual's daily calorie needs based on their gender, age, height, weight, body fat, and activity level.

//namespace VLC.BussinessLogic
//{
//    public class NutrientModel
//    {
//        [Required]
//        public string Name { get; set; }
//        [Range(0, double.MaxValue)]
//        public double MinimumQuantity { get; set; }
//        [Range(0, double.MaxValue)]
//        public double IdealQuantity { get; set; }
//        [Range(0, double.MaxValue)]
//        public double MaximumQuantity { get; set; }
//        [Range(0, double.MaxValue)]
//        public double CurrentQuantity { get; set; }
//        [Range(0, double.MaxValue)]
//        public double Weight { get; set; }

//        public NutrientModel()
//        {
//            CurrentQuantity = 0;
//        }
//    }

//    public class Nutrient
//    {
//        public string Name { get; set; }
//        public double MinimumQuantity { get; set; }
//        public double IdealQuantity { get; set; }
//        public double MaximumQuantity { get; set; }
//        public double CurrentQuantity { get; set; }
//        public double Priority { get; set; }

//        public Nutrient()
//        {
//            CurrentQuantity = 0;
//        }

//        /// <summary>
//        /// Method for adding a specified quantity of the nutrient
//        /// </summary>
//        /// <param name="quantity"></param>
//        public void AddQuantity(double quantity)
//        {
//            CurrentQuantity += quantity;
//        }


//        /// <summary>
//        /// Uses the appropriate linear function to calculate the nutrient score
//        /// </summary>
//        /// <param name="ideal"></param>
//        /// <param name="maximum"></param>
//        /// <param name="minimum"></param>
//        /// <param name="priority"></param>
//        /// <param name="defaultScore"></param>
//        /// <returns></returns>
//        // based on the nutrient quantity, ideal, maximum, and minimum quantities,
//        // as well as the Priority and defaultScore values
//        public double CalculateNutrientScore(double ideal, double maximum, double minimum, double priority, double defaultScore)
//        {
//            if (CurrentQuantity > ideal && CurrentQuantity < maximum)
//            {
//                return priority * (CurrentQuantity - ideal) + defaultScore;
//            }
//            else if (CurrentQuantity < ideal && CurrentQuantity > minimum)
//            {
//                return priority * (CurrentQuantity - ideal) + defaultScore;
//            }
//            else if (CurrentQuantity < minimum)
//            {
//                return priority * (CurrentQuantity - minimum) + defaultScore;
//            }

//            // default return value if none of the conditions are satisfied
//            return 0;
//        }
//    }



//    public class MealPlan
//    {
//        // List of nutrients in the meal plan
//        public List<Nutrient> Nutrients { get; set; }

//        // List of food items in the meal plan
//        public List<FoodItem> FoodItems { get; set; }

//        // Constructor
//        public MealPlan()
//        {
//            Nutrients = new List<Nutrient>();
//            FoodItems = new List<FoodItem>();
//        }

//        // Method for calculating the score for a given nutrient in the meal plan
//        public double CalculateNutrientScore(Nutrient nutrient)
//        {
//            // Get the current quantity of the nutrient in the meal plan
//            double currentQuantity = nutrient.CurrentQuantity;

//            // Select the appropriate function for calculating the nutrient score,
//            // based on the current quantity of the nutrient in the meal plan
//            if (currentQuantity > nutrient.IdealQuantity && currentQuantity < nutrient.MaximumQuantity)
//            {
//                // Function used when the current quantity of the nutrient is greater than the ideal quantity
//                // and less than the maximum quantity
//                return nutrient.Priority * (currentQuantity - nutrient.MinimumQuantity) + nutrient.DefaultScore;
//            }
//            else if (currentQuantity < nutrient.IdealQuantity && currentQuantity > nutrient.MinimumQuantity)
//            {
//                // Function used when the current quantity of the nutrient is less than the ideal quantity
//                // and greater than the minimum quantity
//                return nutrient.Priority * (currentQuantity - nutrient.MinimumQuantity) + nutrient.DefaultScore;
//            }
//            else
//            {
//                // Function used when the current quantity of the nutrient is less than the minimum quantity
//                return nutrient.Priority * (currentQuantity - nutrient.MinimumQuantity) + nutrient.DefaultScore;
//            }
//        }

//        // Method for calculating the overall score for the meal plan
//        public double CalculateMealPlanScore()
//        {
//            double score = 0;

//            // Calculate the score for each nutrient in the meal plan
//            foreach (var nutrient in Nutrients)
//            {
//                score += CalculateNutrientScore(nutrient);
//            }

//            return score;
//        }

//        // Method for checking if a meal plan meets the specified nutritional requirements
//        public bool IsMealPlanAcceptable(MealPlan mealPlan)
//        {
//            // Check if the meal plan is acceptable
//            foreach (var nutrient in mealPlan.Nutrients)
//            {
//                // Check if the nutrient score is within the acceptable range
//                if (nutrient.CurrentQuantity < nutrient.MinimumQuantity ||
//                    nutrient.CurrentQuantity > nutrient.MaximumQuantity)
//                {
//                    // The meal plan is not acceptable
//                    return false;
//                }
//            }
//            // If all nutrients are within the acceptable range, the meal plan is acceptable
//            return true;

//        }




//        public class MealPlanGenerator
//        {
//            public MealPlan MealPlan { get; set; }
//            public List<Nutrient> Nutrients { get; set; }
//            public List<string> Top100Foods { get; set; }
//            public List<string> Foods { get; set; }
//            public Diet Diet { get; set; }
//            public int Calories { get; set; }
//            public Gender Gender { get; set; }
//            public int Age { get; set; }
//            public int Height { get; set; }
//            public int Weight { get; set; }
//            public int BodyFat { get; set; }
//            public int ActivityLevel { get; set; }
//            public bool UseMetricUnits { get; set; }


//            public MealPlanGenerator()
//            {
//                MealPlan = new MealPlan();
//                Nutrients = new List<Nutrient>();
//                Top100Foods = new List<string>();
//                Foods = new List<string>();

//            }

//            public void LoadNutrientData()
//            {
//                // Use the entity framework to retrieve data on nutrients and their quantities from the database
//                using (var db = new MyDbContext())
//                {
//                    Nutrients = db.Nutrients.ToList();
//                }
//            }

//            public void GenerateMealPlan()
//            {
//                /*

//                  // First, calculate the person's daily caloric needs based on their gender, age, height, weight, and activity level
//                    int dailyCaloricNeeds = CalculateDailyCaloricNeeds(gender, age, height, weight, activityLevel);

//                    // Next, based on the person's goal (lose, maintain, or gain weight), determine the number of calories per meal and the proportion of macronutrients in the meal plan
//                    int caloriesPerMeal = 0;
//                    double proteinRatio = 0.0;
//                    double carbRatio = 0.0;
//                    double fatRatio = 0.0;
//                    if (goal == "lose")
//                    {
//                        // If the person wants to lose weight, reduce the number of calories per meal and increase the protein ratio
//                        caloriesPerMeal = dailyCaloricNeeds / 3;
//                        proteinRatio = 0.4;
//                        carbRatio = 0.3;
//                        fatRatio = 0.3;
//                    }
//                    else if (goal == "maintain")
//                    {
//                        // If the person wants to maintain their weight, keep the number of calories per meal and macronutrient ratios the same as their daily caloric needs
//                        caloriesPerMeal = dailyCaloricNeeds / 3;
//                        proteinRatio = dailyCaloricNeeds * 0.1 / caloriesPerMeal;
//                        carbRatio = dailyCaloricNeeds * 0.5 / caloriesPerMeal;
//                        fatRatio = dailyCaloricNeeds * 0.35 / caloriesPerMeal;


//                 */





//                // Set requirementsMet to false until all nutrient requirements are met
//                bool requirementsMet = false;
//                Random random = new();

//                // Keep selecting a random food and adding it to the meal plan until all requirements are met
//                while (!requirementsMet)
//                {
//                    // Select a random food from the list of top 100 foods
//                    // To do this, generate a random number between 0 and the length of the list
//                    // Use this random number as the index to access a random item from the list
//                    int index = random.Next(0, Top100Foods.Count);
//                    string food = Top100Foods[index];

//                    // Calculate the nutrient content of the food
//                    foreach (Nutrient nutrient in Nutrients)
//                    {
//                        nutrient.CurrentQuantity += CalculateFoodNutrientContent(food, nutrient.Name);
//                    }

//                    // Add the food to the meal plan
//                    Foods.Add(food);

//                    // Check if all nutrient requirements are met
//                    requirementsMet = true;
//                    foreach (Nutrient nutrient in Nutrients)
//                    {
//                        if (nutrient.CurrentQuantity < nutrient.MinimumQuantity)
//                        {
//                            requirementsMet = false;
//                            break;
//                        }
//                    }
//                }
//            }



//            ///// <summary>
//            ///// The GenerateMealPlan method is a recursive method that generates a personalized meal plan 
//            ///// by selecting a random food from a list of top 100 foods 
//            ///// and adding it to the meal plan. 
//            ///// The method then calculates the nutrient content of the food 
//            ///// and checks if all the nutrient requirements are met. 
//            ///// If all the requirements are met, the program ends. 
//            ///// If not, the method calls itself again to select another food 
//            ///// and add it to the meal plan, until all the requirements are met. 
//            ///// This allows the method to generate a meal plan that meets specific nutritional requirements
//            ///// </summary>
//            //public void GenerateMealPlan()
//            //{
//            //    // Select a random food from the list of top 100 foods
//            //    string food = Top100Foods[0];

//            //    // Calculate the nutrient content of the food
//            //    foreach (Nutrient nutrient in Nutrients)
//            //    {
//            //        nutrient.CurrentQuantity += CalculateFoodNutrientContent(food, nutrient.Name);
//            //    }

//            //    // Add the food to the meal plan
//            //    MealPlan.Foods.Add(food);

//            //    // Check if all nutrient requirements are met
//            //    bool requirementsMet = true;
//            //    foreach (Nutrient nutrient in Nutrients)
//            //    {
//            //        if (nutrient.CurrentQuantity < nutrient.MinimumQuantity)
//            //        {
//            //            requirementsMet = false;
//            //            break;
//            //        }
//            //    }

//            //    // If all nutrient requirements are met, end the program
//            //    if (requirementsMet)
//            //    {
//            //        return;
//            //    }

//            //    // If not, go back to selecting a random food item from the list
//            //    GenerateMealPlan();
//            //}


//            ///// <summary>
//            ///// A helper method that calculates the amount of a specific nutrient in a given food. 
//            ///// This method is called by the GenerateMealPlan method to calculate the nutrient content of a food that has been added to the meal plan. 
//            ///// The method takes two arguments: food, which is the name of the food to be analyzed, 
//            ///// and nutrientName, which is the name of the nutrient to be calculated. 
//            ///// The method looks up the nutrient composition of the food in a database or lookup table, 
//            ///// and returns the amount of the specified nutrient in the food. 
//            ///// </summary>
//            ///// <param name="food"></param>
//            ///// <param name="nutrientName"></param>
//            ///// <returns></returns>
//            //private double CalculateFoodNutrientContent(string food, string nutrientName)
//            //{
//            //    // Use the entity framework to retrieve the nutrient composition of the food from the database
//            //    using (var db = new MyDbContext())
//            //    {
//            //        var foodNutrient = db.FoodNutrients
//            //            .Where(fn => fn.Food.Name == food && fn.Nutrient.Name == nutrientName)
//            //            .SingleOrDefault();

//            //        if (foodNutrient != null)
//            //        {
//            //            return foodNutrient.Quantity;
//            //        }
//            //    }
//            //    // If the food does not have the specified nutrient, return 0
//            //    return 0;
//            //}
//            private double CalculateFoodNutrientContent(string food, string nutrientName)
//            {

//                // Make a request to the edamame API
//                string url = $"https://api.edamam.com/api/food-database/parser?ingr={food}&app_id=<YOUR_APP_ID>&app_key=<YOUR_APP_KEY>";
//                string response = MakeRequest(url);

//                // Parse the response to extract the nutrient content of the food
//                // For example, if the nutrientName is "Protein", you would return the amount of protein in the food
//                double nutrientContent = ParseResponse(response, nutrientName);

//                return nutrientContent;
//            }


//            /*

//            private const string API_URL = "https://example.com/api/v1/foods";

//            private async Task<double> CalculateFoodNutrientContent(string food, string nutrientName)
//            {
//                // Use HttpClient to make a GET request to the API
//                using (var client = new HttpClient())
//                {
//                    // Add the API key to the request header
//                    client.DefaultRequestHeaders.Add("x-api-key", API_KEY);

//                    // Set the Accept header to "application/json" to indicate that we want a JSON response
//                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

//                    // Make the GET request to the API
//                    HttpResponseMessage response = await client.GetAsync(API_URL);

//                    // Check if the request was successful
//                    if (response.IsSuccessStatusCode)
//                    {
//                        // Parse the JSON response from the API
//                        var jsonString = await response.Content.ReadAsStringAsync();
//                        var jsonObject = JsonConvert.DeserializeObject<JObject>(jsonString);

//                        // Extract the nutrient data for the specified food and nutrient
//                        var foodObject = jsonObject["foods"].FirstOrDefault(x => x["name"].Value<string>() == food);
//                        var nutrientValue = foodObject["nutrients"].FirstOrDefault(x => x["name"].Value<string>() == nutrientName)?["value"];

//                        // Return the nutrient value, or 0 if the nutrient was not found
//                        return nutrientValue?.Value<double>() ?? 0;
//                    }
//                    else
//                    {
//                        // The request was not successful, throw an exception
//                        throw new Exception($"Failed to retrieve data from API: {response.StatusCode} - {response.ReasonPhrase}");
//                    }
//                }
//            }


//             */


//            //private NutrientContent MakeRequest(string foodName)
//            //{
//            //    // Use the entity framework or a web API client to make a request to the database or API
//            //    // for information about the specified food item

//            //    // For example, using the entity framework:
//            //    using (var db = new MyDbContext())
//            //    {
//            //        return db.Foods.Where(f => f.Name == foodName).FirstOrDefault();
//            //    }

//            //    // Or, using a web API client:
//            //    var client = new HttpClient();
//            //    var response = await client.GetAsync($"http://myapi.com/foods?name={foodName}");
//            //    return await response.Content.ReadAsAsync<NutrientContent>();
//            //}



//        }





//        //public class MealPlanController : Controller
//        //{
//        //    public ActionResult GenerateMealPlan()
//        //    {
//        //        // Use the MealPlanGenerator class to generate a meal plan
//        //        MealPlanGenerator generator = new MealPlanGenerator();
//        //        generator.LoadNutrientData();
//        //        generator.GenerateMealPlan();

//        //        // Pass the generated meal plan to the view
//        //        return View(generator.MealPlan);
//        //    }
//        //}


//        /*
//        @model MealPlan

//    <h1>Meal Plan</h1>

//    <table>
//        <thead>
//            <tr>
//                <th>Food</th>
//                <th>Nutrient Content</th>
//            </tr>
//        </thead>
//        <tbody>
//            @foreach (var food in Model.Foods)
//        {
//                < tr >
//                    < td > @food </ td >
//                    < td >
//                        < ul >
//                            @foreach(var nutrient in Model.Nutrients)
//                            {
//                                < li > @nutrient.Name: @nutrient.CurrentQuantity @nutrient.Unit </ li >
//                            }
//                        </ ul >
//                    </ td >
//                </ tr >
//            }
//        </tbody>
//    </table>
//        */

//    }
//}
