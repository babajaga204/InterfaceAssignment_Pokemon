using InterfaceAssignment_Pokemon;

var wildPokemon = new List<IPokemon>
{
    new Charmander(100),
    new Pikachu(100)
};
var magikarp = new Magikarp(60, true);
var randomPokemon = GetWildPokemon(wildPokemon);
while (magikarp.Health > 0)
{
    magikarp.Splash(randomPokemon);
    randomPokemon.Attack(magikarp);
}

Console.WriteLine("Magikarp has " + magikarp.Health + " health left.");
Console.WriteLine(randomPokemon.GetType()
    .ToString()
    .Split(".")[1] + " has " + randomPokemon.Health + " health left.");
static IPokemon GetWildPokemon(List<IPokemon> wildPokemon)
{
    return wildPokemon[new Random().Next(0, wildPokemon.Count)];
}