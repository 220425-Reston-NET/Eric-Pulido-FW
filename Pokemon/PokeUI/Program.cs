// See https://aka.ms/new-console-template for more information

using PokeModel;
using PokeUI;
//Console.WriteLine("Hello, World!");

//Pokemon pokeobj = new Pokemon();
//pokeobj.PokeID = 100;
//Console.WriteLine(pokeobj.PokeID);
//pokeobj.PokeID = -10;
//Console.WriteLine(pokeobj.PokeID);

//adding abilities to obj
//Ability abi1 = new Ability();
//abi1.Name = "tackle";
//Ability abi2 = new Ability();
//abi2.Name = "Screech";

//pokeobj.Abilities.Add(abi1);
//pokeobj.Abilities.Add(abi2);

//Display everything that pokemon obj currently has in its abilities

//foreach (Ability item in pokeobj.Abilities)
//{
//    Console.WriteLine(item.Name);
//}

Console.Clear();
//creating ManiMenu obj
MainMenu menu = new MainMenu();
bool repeat = true;
while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.YourChoice();

    if (ans== "MainMenu")
    {

    }
    else if (ans == "AddPokemon")
    {
        
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }
}