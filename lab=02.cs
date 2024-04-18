using System;
using System.Collections.Generic;
using System.Linq;

// Описание класса Ингредиент
class Ingredient
{
    // Поля ингредиента
    public string Name { get; }          // Название ингредиента
    public double CostPer100g { get; }   // Стоимость 100 грамм ингредиента
    public int Quantity { get; }         // Количество ингредиента

    // Конструктор класса Ингредиент
    public Ingredient(string name, double costPer100g, int quantity)
    {
        Name = name;
        CostPer100g = costPer100g;
        Quantity = quantity;
    }

    // Метод для расчета стоимости ингредиента в салате
    public double GetCost()
    {
        return CostPer100g * Quantity / 100.0;  // Рассчитываем стоимость и возвращаем ее
    }
}

// Описание класса Салат, который является наследником класса List<Ingredient>
class Salad : List<Ingredient>
{
    // Метод для расчета общей цены салата
    public double GetCost()
    {
        // С помощью LINQ суммируем стоимость каждого ингредиента
        return this.Sum(ingredient => ingredient.GetCost());
    }
	
	/* Альтернативные пути реализации метода GetCost
	// Метод для расчета общей цены салата с использованием foreach
	public double GetCost()
	{
		double totalCost = 0;  // Переменная для хранения общей стоимости салата

		// Итерируемся по каждому ингредиенту в салате
		foreach (Ingredient ingredient in this)
		{
			// Добавляем стоимость ингредиента к общей стоимости
			totalCost += ingredient.GetCost();
		}

		return totalCost;  // Возвращаем общую стоимость салата
	}
	
	// Метод для расчета общей цены салата с использованием for
	public double GetCost()
	{
		double totalCost = 0;  // Переменная для хранения общей стоимости салата

		// Итерируемся по каждому индексу в списке ингредиентов
		for (int i = 0; i < this.Count; i++)
		{
			// Получаем ингредиент по текущему индексу
			Ingredient ingredient = this[i];
			
			// Добавляем стоимость ингредиента к общей стоимости
			totalCost += ingredient.GetCost();
		}

		return totalCost;  // Возвращаем общую стоимость салата
	}
	*/

    // Переопределение метода ToString для вывода информации о салате
    public override string ToString()
    {
        // Формируем строку из списка ингредиентов через запятую и общей стоимости салата
        string ingredients = string.Join(", ", this.Select(ingredient => ingredient.Name));
        double totalCost = GetCost();  // Получаем общую стоимость салата
        return $"{ingredients}, {totalCost}"; // Формат вывода: "<список ингредиентов через запятую>, <стоимость салата>"
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание салата с произвольными ингредиентами
        Salad salad = new Salad()
        {
            new Ingredient("Листья салата", 1.5, 200),
            new Ingredient("Помидоры", 2.0, 300),
            new Ingredient("Оливки", 3.0, 100),
            new Ingredient("Огурцы", 1.0, 150),
            new Ingredient("Перец", 1.8, 200)
        };

        // Вывод информации о салате
        Console.WriteLine("Информация о салате:");
        Console.WriteLine(salad);
    }
}