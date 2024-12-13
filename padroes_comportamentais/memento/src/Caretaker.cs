namespace memento;

public class Caretaker
{
    private PlayerState _memento;

    public void Save(PlayerState state)
    {
        _memento = state;
    }

    public void Restore(Player player)
    {
        if (_memento != null)
        {
            player.RestoreState(_memento);
        }
    }
}