using System.Collections.Generic;
using PokeSimulator.Domain.Pokemons;

namespace PokeSimulator.Domain.Trainer;

public class Trainer
{
    public string Name { get; set; }
    public int Money { get; set; }
    public List<Pokemon> Pokemons { get; set; }
}
