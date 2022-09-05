using System;

namespace Full_GRASP_And_SOLID.Library
{
    // - SRP -
    // Separo la responsabilidad de tener que imprimir la receta al objeto de la receta
    // Haciendo esto, La receta solo debe conocer lo necesario para poder crear un objeto receta
    
    public class ConsolePrinter
    {
        public static void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}