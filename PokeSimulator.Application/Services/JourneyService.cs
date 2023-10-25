using PokeSimulator.Domain.City;
using PokeSimulator.Domain.Pokemons;

namespace PokeSimulator.Application.Services;

public sealed class JourneyService
{
    public static List<Pokemon> InitialPokemons()
    {
        List<Pokemon> listaDePokemons = new List<Pokemon>
        {
            new() { Name = "Bulbasaur", ElementalType = ElementalType.Grass },
            new() { Name = "Charmander", ElementalType = ElementalType.Fire },
            new() { Name = "Squirtle", ElementalType = ElementalType.Water },
        };
        return listaDePokemons;
    }

    public static List<City> Cities()
    {
        List<City> cities = new List<City>
        {
            new() {Name = "Celadon", GymType = "Grass"},
            new() {Name = "Cerulean", GymType = "Water"},
            new() {Name = "Cinnabar", GymType = "Fire"}
        };
        return cities;
    }

    public static void StartJourney()
    {
        ChoosePokemon();
        Thread.Sleep(500);
        ChooseCity();
    }

    private static void ChoosePokemon()
    {
        List<Pokemon> pokemons = InitialPokemons();

        Console.WriteLine("Escolha seu pokemon inicial:");
        foreach (var pokemon in pokemons)
        {
            Console.WriteLine($"Nome: {pokemon.Name}, Tipo: {pokemon.ElementalType}");
        }

        var input = Console.ReadLine();

        var chosenPokemon = pokemons.Find(pokemon => pokemon.Name == input);

        if (input != null)
        {
            Console.WriteLine($"Você escolheu o pokemon {chosenPokemon.Name}!");
        }
        else
        {
            Console.WriteLine("Pokémon não encontrado. Certifique-se de digitar o nome corretamente.");
        }
    }

    private static void ChooseCity()
    {
        List<City> cities = Cities();

        Console.WriteLine("Agora escolha a cidade que quer iniciar:");
        foreach (var city in cities)
        {
            Console.WriteLine($"Nome: {city.Name}, Tipo do ginásio: {city.GymType}");
        }

        var input = Console.ReadLine();

        var chosenCity = cities.Find(city => city.Name == input);

        if (input != null)
        {
            Console.WriteLine($"Você escolheu a cidade de {chosenCity.Name}!");
        }
        else
        {
            Console.WriteLine("Cidade não encontrada. Certifique-se de digitar o nome corretamente.");
        }
    }
}