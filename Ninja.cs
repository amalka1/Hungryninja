using System.Collections.Generic;
namespace Practice
{
    class Ninja
    {

        
        private int calorieInTake;
        public List<Food> FoodHistory;
        public Ninja( )
        {
            calorieInTake = 0;
            FoodHistory = new List<Food>();
        }
        bool isFull{
            get
            {
                return calorieInTake > 1200;
            }
        }
    
        public void eat (Food foodmenu)
        {
            if( ! isFull ){
                calorieInTake += foodmenu.Calories;
                FoodHistory. Add (foodmenu);
                System.Console.WriteLine("The ninja just ate " + foodmenu.Name );
                if (foodmenu.IsSpicy)
                    System.Console.WriteLine("This " + foodmenu.Name + " is spicy");
                if (foodmenu.IsSweet)
                    System.Console.WriteLine("This " + foodmenu.Name + "is spicy" );
            }
            else 
            {
                System.Console.WriteLine("Ninja is full");
            }
    }
}
}
