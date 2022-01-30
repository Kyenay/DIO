using static System.Console;
using Abstraindo_um_Jogo_de_RPG.src.Entities;


class Program
{
    static void Main(string[] arg)
    {
        Knight hero = new Knight("Argus", 5 , "Knight");
        Wizard wizard = new Wizard("Jenica", 4 , "Wizard");
        Ninja shinobi = new Ninja("Wellick", 5 , "Ninja");

        WriteLine(hero.Attack());
        WriteLine(wizard.Attack(6));
        WriteLine(shinobi.Attack(6));
    }
}