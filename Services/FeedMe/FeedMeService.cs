
namespace AllForOneAPI.Services.FeedMe;

    public class FeedMeService : IFeedMeService
    {
         public string GetFood(string myChoice)
        {
            if(myChoice == "1")
            {
                string[] fastFood = {"In-N-Out", "Burger King", "Jack in the Box", "KFC", "Popeyes", "Sonic", "Cracker Barrel", "Taco Bell", "Carls Jr", "Wienerschnitzel"};
                Random random = new Random();
                int foodresult = random.Next(0, fastFood.Length);
                return $"You should go to {fastFood[foodresult]} today!";
            }else if(myChoice == "2")
            {
                string[] seaFood = {"Long John Silvers", "La Petit Poisson", "Matsuyama Sushi", "Captain Crab", "Red Lobster", "Bubba Gump Shrimp Co.", "Surf N Turf", "Rubios", "Fish N Chips", "Holy Mackarel"};
                Random random = new Random();
                int foodresult = random.Next(0, seaFood.Length);
                return $"You should go to {seaFood[foodresult]} today!";
            }else if(myChoice == "3")
            {
                string[] vegFood = {"Lettuce Lounge", "Vegan Palace", "Healthie House", "Cabbage Cottage", "Broccoli Bunker", "Spinach Safehouse", "House of Veggies", "Grandma's Garden", "Eggplant Manor", "Casa de Cebolla"};
                Random random = new Random();
                int foodresult = random.Next(0, vegFood.Length);
                return $"You should go to {vegFood[foodresult]} today!";
            }else{
                return "Invalid input detected, please only enter a number value between 1 and 3.";
            }
        }
    }
