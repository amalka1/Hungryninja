using System.Collections.Generic;
namespace Practice{

     class Buffet{
        public List<Food> Menu;

        public Buffet()
        {
            Menu = new List<Food>(){
                new Food("Lamb", 300, true,false),
                new Food("Chicken", 200, false, false),
                new Food("Fish Cake", 200, false, false),
                new Food("Dates", 235, false, true),
                new Food("Ice Cream", 180, false, false),
                new Food("Pasta", 185, true, false),
                new Food("Rice ", 217, false, false),
                new Food("Sweet Patatoe", 210, false, true),
            };
        }
              public  Food serve(){
                Random rand = new Random();
                var randomFood = rand.Next( Menu.Count);
                return Menu[randomFood];

            
           
        }
    }
}