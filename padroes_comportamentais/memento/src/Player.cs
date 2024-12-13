namespace memento;

public class Player
{
    public int Position { get; set; }
    public int Health { get; set; }

    public PlayerState SaveState()
    {
        return new PlayerState(Position, Health);
    }

    public void RestoreState(PlayerState state)
    {
        Position = state.Position;
        Health = state.Health;
    }
}