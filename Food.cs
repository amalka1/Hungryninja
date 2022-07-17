using System.Collections.Generic;
namespace Practice{

    public class Food{

        public string Name;
        public int Calories;
        public bool IsSpicy;
        public bool IsSweet;

        public Food(string name, int calories, bool isspicy, bool issweet)
        {
            this.Name = name;
            this.Calories = calories;
            this.IsSpicy = isspicy;
            this.IsSweet = issweet;
        }
    }
}