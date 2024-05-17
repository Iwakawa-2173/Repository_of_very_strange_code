using System;
using System.Collections.Generic;
using System.Linq;

// Определение класса "Ингредиент"
public class Ingredient
{
    // Свойства
    public string Name { get; set; }
    public double Cost { get; set; }

    // Конструктор
    public Ingredient(string name, double cost)
    {
        Name = name;
        Cost = cost;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание коллекции ингредиентов с помощью конструкторов элементов
        List<Ingredient> ingredients = new List<Ingredient>
        {
            new Ingredient("Листья салата", 1.5),
            new Ingredient("Помидоры", 2.0),
            new Ingredient("Огурцы", 1.8),
            new Ingredient("Перец", 1.2),
            new Ingredient("Маслины", 2.3)
        };

        // Запрос LINQ для получения общей стоимости первых трех ингредиентов
        var totalCost = ingredients.Take(3).Sum(i => i.Cost);

        Console.WriteLine($"Общая стоимость салата из первых трех ингредиентов: {totalCost}");
    }
}