using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;



List<string> osobyLosujace = new List<string>();
osobyLosujace.AddRange(new List<string>() { "Bartek", "Filip", "Justyna", "Maja", "Aneta", "Marta", "Emilia", "Józek", "Maria", "Dominik", "Paweł", "Gosia" });

List<string> osobyDoWylosowania = new List<string>();
osobyDoWylosowania.AddRange(osobyLosujace);

int randomIndex;

Dictionary<string, string> NameToName = new Dictionary<string, string>();

for (int i = 0; i < osobyLosujace.Count; i++)
{
    string imie = osobyLosujace[i];

    if (osobyDoWylosowania.Contains(imie))
    {
        osobyDoWylosowania.Remove(imie);
        randomIndex = new Random().Next(0, osobyDoWylosowania.Count);
        string imie2 = osobyDoWylosowania[randomIndex];
        NameToName.Add(imie, imie2);
        osobyDoWylosowania.Add(imie);
        osobyDoWylosowania.Remove(imie2);

    }
    else
    {
        randomIndex = new Random().Next(0, osobyDoWylosowania.Count);
        string imie2 = osobyDoWylosowania[randomIndex];
        NameToName.Add(imie, imie2);
        osobyDoWylosowania.Remove(imie2);
    }

}

do
{
    Console.WriteLine("Welcome to the people draw app!");
    Console.WriteLine("Please write your name starting with a capital letter:");
    var userInput = Console.ReadLine();

    if (NameToName.ContainsKey(userInput))
    {
        NameToName.TryGetValue(userInput, out string drawnPerson);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("{0} wylosował/a {1}", userInput, drawnPerson);
        Console.ForegroundColor = ConsoleColor.White;
        NameToName.Remove(userInput);
        Console.WriteLine("Please press any key to delete");
        var deleteOption = Console.ReadKey();
        if (deleteOption != null)
        {
            Console.Clear();
        }

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Error! Please write your name again WITH A CAPITAL LETTER:");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
while (NameToName.Count != 0);
