namespace PokeSimulator.Domain.Pokemons;

public class Pokemon
{
    public string Name { get; set; }
    public ElementalType ElementalType { get; set; }
    public int HP { get; set; }
    public List<AttackMove> Moves { get; set; }
    public int Level { get; set; }
}

public class AttackMove
{
}

public enum ElementalType
{
    Water = 1,
    Fire = 2,
    Grass = 3
}
