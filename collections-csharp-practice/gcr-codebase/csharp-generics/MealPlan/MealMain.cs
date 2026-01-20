namespace BridgeLabzTraining.collections_csharp_practice.gcr_codebase.csharp_generics.MealPlan
{
    // INTERFACE
    public interface IMealPlan
    {
        string MealName { get; }
        int Calories { get; }
        void DisplayMeal();
    }

    // VEGETARIAN MEAL
    public class VegetarianMeal : IMealPlan
    {
        public string MealName => "Vegetarian Meal";
        public int Calories => 500;

        public void DisplayMeal()
        {
            Console.WriteLine("Meal Type : Vegetarian");
            Console.WriteLine("Includes  : Vegetables, Dairy");
            Console.WriteLine("Calories  : " + Calories);
        }
    }

    // VEGAN MEAL
    public class VeganMeal : IMealPlan
    {
        public string MealName => "Vegan Meal";
        public int Calories => 450;

        public void DisplayMeal()
        {
            Console.WriteLine("Meal Type : Vegan");
            Console.WriteLine("Includes  : Plant-based foods");
            Console.WriteLine("Calories  : " + Calories);
        }
    }

    // KETO MEAL
    public class KetoMeal : IMealPlan
    {
        public string MealName => "Keto Meal";
        public int Calories => 700;

        public void DisplayMeal()
        {
            Console.WriteLine("Meal Type : Keto");
            Console.WriteLine("Includes  : Low-carb, High-fat foods");
            Console.WriteLine("Calories  : " + Calories);
        }
    }

    // HIGH PROTEIN MEAL
    public class HighProteinMeal : IMealPlan
    {
        public string MealName => "High Protein Meal";
        public int Calories => 650;

        public void DisplayMeal()
        {
            Console.WriteLine("Meal Type : High Protein");
            Console.WriteLine("Includes  : Protein-rich foods");
            Console.WriteLine("Calories  : " + Calories);
        }
    }

    // GENERIC MEAL CLASS
    public class Meal<T> where T : IMealPlan
    {
        public T MealPlan { get; private set; }

        public Meal(T mealPlan)
        {
            MealPlan = mealPlan;
        }

        public void ShowMeal()
        {
            MealPlan.DisplayMeal();
        }
    }

    // GENERIC METHOD UTILITY
    public class MealPlanGenerator
    {
        public static Meal<T> GenerateMealPlan<T>(T meal)
            where T : IMealPlan
        {
            Console.WriteLine("\nValidating Meal Plan...");
            Console.WriteLine("Meal Validated Successfully!\n");

            return new Meal<T>(meal);
        }
    }

    // MAIN PROGRAM
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Personalized Meal Plan Generator ===\n");

            Meal<VegetarianMeal> vegMeal =
                MealPlanGenerator.GenerateMealPlan(new VegetarianMeal());
            vegMeal.ShowMeal();

            Console.WriteLine();

            Meal<VeganMeal> veganMeal =
                MealPlanGenerator.GenerateMealPlan(new VeganMeal());
            veganMeal.ShowMeal();

            Console.WriteLine();

            Meal<KetoMeal> ketoMeal =
                MealPlanGenerator.GenerateMealPlan(new KetoMeal());
            ketoMeal.ShowMeal();

            Console.WriteLine();

            Meal<HighProteinMeal> proteinMeal =
                MealPlanGenerator.GenerateMealPlan(new HighProteinMeal());
            proteinMeal.ShowMeal();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
