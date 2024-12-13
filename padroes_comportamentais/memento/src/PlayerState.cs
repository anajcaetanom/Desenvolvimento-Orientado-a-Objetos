namespace memento;

public class PlayerState
{
    public int Position { get; }
    public int Health { get; }

    public PlayerState(int position, int health)
    {
        Position = position;
        Health = health;
    }
}