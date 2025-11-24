using System;
using System.Collections.Generic;
using System.Linq;
using WinFormsApp1;

internal class SquadManager
{
    private List<Person> squad = new List<Person>();

    // Добавление персонажа
    public void AddPerson(Person person)
    {
        squad.Add(person);
        Console.WriteLine($"{person.Name} добавлен в отряд.");
    }

    // Удаление персонажа
    public void RemovePerson(string name)
    {
        var person = squad.FirstOrDefault(p => p.Name == name);
        if (person != null)
        {
            squad.Remove(person);
            Console.WriteLine($"{name} удален из отряда.");
        }
        else
        {
            Console.WriteLine($"Персонаж с именем {name} не найден.");
        }
    }

    // Сортировка по уровню
    public void SortByLevel()
    {
        squad = squad.OrderBy(p => p.Level).ToList();
        Console.WriteLine("Отряд отсортирован по уровню.");
    }

    // Исправление: Явно приводим person к типу Person, чтобы получить доступ к свойствам Name и Level
    public void FilterByType<T>() where T : Person
    {
        var filtered = squad.OfType<T>().ToList();
        Console.WriteLine($"Фильтр по типу {typeof(T).Name}:");
        foreach (var person in filtered)
        {
            Console.WriteLine($"- {(person as Person).Name} (Уровень: {(person as Person).Level})");
        }
    }

    // Вывод информации об отряде
    public void DisplaySquad()
    {
        Console.WriteLine("Состав отряда:");
        foreach (var person in squad)
        {
            Console.WriteLine($"- {person.Name} (Тип: {person.GetType().Name}, Уровень: {person.Level}, Здоровье: {person.Health})");
        }
    }

    // Возвращает список всех персонажей
    public List<Person> GetSquad()
    {
        return squad;
    }
}