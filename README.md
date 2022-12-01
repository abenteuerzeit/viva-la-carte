# el-proyecte-grande-sprint-1-csharp-abenteuerzeit

## Two working versions at the moment

The solution MvcVivaLaCarte is the sandbox for ideas
The solution VLC is the development project for production. 

# User experience 

## Story time! 

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


## Flows

> Key: 
> 1. Action
>     1. Success.
>     2. Failure

### Actions (CRUD or REST)

#### Identity 

- ***Register a new account***
    -  ? View **Home page**
    -  : Return *register page with error message*
- ***Login to account***
    - ?  View **Home page**
    - :  Return *Login page with error message*

#### Profile Settings

- ***Food preferences***
    - USer interacts with **ProductPreferenceManager** to set preferences
        - Only 10 items can be favorite
        - Collect: Procuct.Id
        - Save for later viewing and editing (to change ratings)

```csharp
public enum Ratings 
{
    reject, dislike, like, love, favorite
}

``` 

- ***Meal preferences***
    - Displayed on home page. You don't need an account to generate meals 
    -  User interacts with Meal Planner to view generated meals
        - Edit items 
            - Add new item; change quantities/portion sizes, substitute products, delete items
        - **MealPlanManager** properties: 
        - 
```csharp
public enum Diets 
{
    Whatever, Paleo, Vegetarian, Vegan, Keto, Mediterranean
}

public class MealPlanManager : IMealPlanManager
{
    private double TotalCalories { get; set; }
    private int MealCount { get; set; }
    private Diets diet { get; set; }
    private List<Recipe> Meals { get; set; }
   ... 
}
```

### Flows

- Home Page displays Meal Plan Maker ⇒ User enters meal nutrition requirements and frequency ⇒ Accept / Modify / Reject meal plan.  
    - each meal is composed of recipes (like: how to make a hamburger, how to make french fries, how to make lemonade). 
    - User can see the nutritional data for the complete cart, an entire meal as well as for individual items
- Accept Meal Plan ⇒ Map as shopping list ⇒  Get, display, modify products ⇒  Checkout (Create Order) ⇒ Process Payment ⇒ Delivery Service

