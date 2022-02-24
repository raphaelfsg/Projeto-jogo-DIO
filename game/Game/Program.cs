using System;
using Game.Entities;

namespace Game
{
class Program
{
    static void Main(string[] args)
    {
        Knight knight = new Knight("Arus", 42, "Knight", 72, 749);
        Wizard wizard = new Wizard("Jenica", 42, "Withe Wizard", 482, 601);
        BlackWizard blackWizard = new BlackWizard("Topapa", 42, "Black Wizard", 641, 385);
        Ninja ninja = new Ninja("Wedge", 42, "Ninja", 89, 574);
        


        Console.WriteLine(wizard.Attack(10));
        Console.WriteLine(knight.Attack(4));
        Console.WriteLine(blackWizard.Attack(8));
        Console.WriteLine(ninja.Attack(2));
    }
}
}