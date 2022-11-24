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
        //Console.WriteLine("{0} wylosował/a {1}", imie, imie2);
        NameToName.Add(imie, imie2);
        osobyDoWylosowania.Add(imie);
        osobyDoWylosowania.Remove(imie2);

    }
    else
    {
        randomIndex = new Random().Next(0, osobyDoWylosowania.Count);
        string imie2 = osobyDoWylosowania[randomIndex];
        //Console.WriteLine("{0} wylosował/a {1}", imie, imie2);
        NameToName.Add(imie, imie2);
        osobyDoWylosowania.Remove(imie2);
    }

}

Console.WriteLine("Welcome to the people draw app!");
Console.WriteLine("Please write your name starting with a capital letter:");

var userInput = Console.ReadLine();


if (NameToName.ContainsKey(userInput))
{
    Console.WriteLine();
}
else
{
    Console.WriteLine("Error! Please write your name again:");
}
