using PokeSimulator.Domain.Pokemons;

namespace PokeSimulator.Domain.Trainer;

public sealed class GymLeader
{
    public string Name { get; set; }
    public List<Pokemon> Pokemons { get; set; }
}