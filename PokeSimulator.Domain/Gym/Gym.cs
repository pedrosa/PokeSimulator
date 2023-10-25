using PokeSimulator.Domain.Trainer;

namespace PokeSimulator.Domain.Gym;

public class Gym
{
    public string Name { get; set; }
    public string GymType { get; set; }
    public string Badge { get; set; }
    public GymLeader GymLeader { get; set; }
}