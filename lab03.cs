using System;

// Обобщённый класс "Сад"
public class Garden<TGardener, TPlant>
{
    public TGardener Gardener { get; private set; } // Свойство "Садовник"
    public TPlant Plant { get; private set; } // Свойство "Растение"

    // Конструктор класса "Сад"
    public Garden(TGardener gardener, TPlant plant)
    {
        Gardener = gardener;
        Plant = plant;
    }

    // Метод "Посадить"
    public void PlantTree()
    {
        Console.WriteLine($"Садовник {Gardener} посадил растение {Plant}");
    }
}

// Класс "Яблоня"
public class AppleTree
{
    public string Sort { get; private set; } // Свойство "Сорт"

    // Конструктор класса "Яблоня"
    public AppleTree(string sort)
    {
        Sort = sort;
    }

    // Переопределение метода ToString для удобного вывода информации о яблоне
    public override string ToString()
    {
        return $"Яблоня сорта {Sort}";
    }
}

// Класс "Смородина"
public class CurrantBush
{
    public string Sort { get; private set; } // Свойство "Сорт"

    // Конструктор класса "Смородина"
    public CurrantBush(string sort)
    {
        Sort = sort;
    }

    // Переопределение метода ToString для удобного вывода информации о смородине
    public override string ToString()
    {
        return $"Смородина сорта {Sort}";
    }
}

// Пример использования обобщённого класса "Сад"
class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра яблони
        var appleTree = new AppleTree("Антоновка");

        // Создание экземпляра садовника
        var gardener = "Ивакава Махикари";

        // Создание экземпляра обобщённого класса "Сад" с яблоней
        var gardenWithAppleTree = new Garden<string, AppleTree>(gardener, appleTree);

        // Посадка яблони
        gardenWithAppleTree.PlantTree(); // Выводит: "Садовник Ивакава Махикари посадил растение Яблоня сорта Антоновка"

        // Создание экземпляра смородины
        var currantBush = new CurrantBush("Черная смородина");

        // Создание экземпляра обобщённого класса "Сад" с смородиной
        var gardenWithCurrantBush = new Garden<string, CurrantBush>(gardener, currantBush);

        // Посадка смородины
        gardenWithCurrantBush.PlantTree(); // Выводит: "Садовник Ивакава Махикари посадил растение Смородина сорта Черная смородина"
    }
}