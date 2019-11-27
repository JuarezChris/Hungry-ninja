using System;
using System.Collections.Generic;

namespace Hungry_ninja
{
    class Food
    {
        public string Name;
        public int Calories;
        // Foods can be Spicy and/or Sweet
        public bool IsSpicy;
        public bool IsSweet;
        // add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
        public Food(string name, int cal, bool spice, bool sweet)
        {
            Name = name;
            Calories = cal;
            IsSpicy = spice;
            IsSweet = sweet;
        }

    }
    class Buffet
    {
        public List<Food> Menu;

        //constructor
        public Buffet()
        {
            Menu = new List<Food>()
        {
            new Food("taco", 1000, true, false),
            new Food("burger", 500, false, false),
            new Food("salad", 20, false, true),
            new Food("chicken", 300, true, true),
            new Food("fish", 500, false, false),
            new Food("fries", 200, false, true),
            new Food("elephant", 900, true, true),
        };
        }

        public Food Serve()
        {
            Random rand = new Random();
            return Menu[rand.Next(0, Menu.Count)];
        }
    }
    class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory;

        // add a constructor
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();
        }

        // add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        // build out the Eat method
        public void Eat(Food item)
        {
            // calorieIntake += item.Calories;
            // FoodHistory.Add(item);
            
                calorieIntake += item.Calories;
                FoodHistory.Add(item);
            

            Console.WriteLine(item.Name);
            Console.WriteLine(item.Calories);
            if (item.IsSpicy == true)
            {
                Console.WriteLine("spicy");
            }
            if (item.IsSweet == true)
            {
                Console.WriteLine("sweet");
            }
            if(calorieIntake >= 1200)
            {
                Console.WriteLine("full");
            }


        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Buffet lunch = new Buffet();
            Food Meal = lunch.Serve();
            Ninja Amigo = new Ninja();

            while(!Amigo.IsFull)
            {
            Amigo.Eat(lunch.Serve());
            // Console.WriteLine($"Food is {}");
            
            }

            // Amigo.Eat(Meal);
            // Console.WriteLine($"Food is {Meal.Name}");
            // Amigo.Eat(Meal);
        }
    }
}
