using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ispit_zadatak_1
{
    internal class Program
    {

        public static void Main()
        {
            FoodType foodType = new FoodType("banana", 4, 93, 3);
            Food food = new Food(foodType, 110);

            Console.WriteLine(food.toString());
            Console.WriteLine(food.toStringInGrams());
            Console.WriteLine("broj instanci: " + FoodType.getNumberOfCreatedInstances());
            
            
            Console.ReadKey();
        }

    }

    public class FoodType
    {
        private String name;
        private int protein;
        private int carbs;
        private int fat;
        private static int counter = 0;

        public string Name { get => name; set => name = value; }
        public int Protein { get => protein; set => protein = value; }
        public int Carbs { get => carbs; set => carbs = value; }
        public int Fat { get => fat; set => fat = value; }

        public FoodType(String name, int protein, int carbs, int fat)
        {
            this.Name = name;
            this.Protein = protein;
            this.Carbs = carbs;
            this.Fat = fat;
            counter++;
        }


        public static int getNumberOfCreatedInstances()
        {
            return counter;
        }

        public String toString()
        {
            return Name + ": p - " + Protein + "%, c - " + Carbs + "%, f - " + Fat + "%";
        }
    }

    public class Food
    {
        private FoodType type;
        private int weight;

        public Food(FoodType type, int weight)
        {
            this.type = type;
            this.weight = weight;
        }

        public FoodType getType()
        {
            return type;
        }

        public int getWeight()
        {
            return weight;
        }

        public double getProtein()
        {
            return type.Protein * weight / 100.0;
        }

        public double getCarbs()
        {
            return type.Carbs * weight / 100.0;
        }

        public double getFat()
        {
            return type.Fat * weight / 100.0;
        }

        public String toString()
        {
            return type.toString() + ", w – " + weight + "g";
        }

        public String toStringInGrams()
        {
            return type.Name + ": p – " + getProtein() + "g, c – " +
                   getCarbs() + "g, f – " + getFat() +
                   "g, w – " + weight + "g";
        }
    }




}

