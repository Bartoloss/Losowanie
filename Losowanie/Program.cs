using Losowanie;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;

var bartek = new Person(0, "Bartek");
var filip = new Person(1, "Filip");
var justyna = new Person(2, "Justyna");
var maja = new Person(3, "Maja");
var aneta = new Person(4, "Aneta");
var marta = new Person(5, "Marta");
var emilia = new Person(6, "Emilia");
var jozek = new Person(7, "Józek");
var maria = new Person(8, "Maria");
var dominik = new Person(9, "Dominik");
var pawel = new Person(10, "Paweł");
var gosia = new Person(11, "Gosia");

List<Person> osobyLosujace = new List<Person>();
osobyLosujace.AddRange(new List<Person>() { bartek, filip, justyna, maja, aneta, marta, emilia, jozek, maria, dominik, pawel, gosia });

List<Person> osobyLosowane = new List<Person>();
osobyLosowane.AddRange(new List<Person>() { bartek, filip, justyna, maja, aneta, marta, emilia, jozek, maria, dominik, pawel, gosia });


int randomIndex;

for (int i = 0; i < osobyLosujace.Count; i++)
{
    if (i == 10)
    {
        Console.WriteLine("{0} wylosował/a {1}", osobyLosujace[10].Name, osobyLosowane[1].Name);
        osobyLosowane.RemoveAt(1);
        Console.WriteLine("{0} wylosował/a {1}", osobyLosujace[11].Name, osobyLosowane[0].Name);
        break;
    }

    do
    {
        randomIndex = new Random().Next(0, osobyLosowane.Count - 1);
    }
    while (osobyLosowane[randomIndex].Id != osobyLosujace[i].Id);
    Console.WriteLine("{0} wylosował/a {1}", osobyLosujace[i].Name, osobyLosowane[randomIndex].Name);
    osobyLosowane.RemoveAt(randomIndex);
}

