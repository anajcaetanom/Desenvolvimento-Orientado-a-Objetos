using System.Collections;

namespace iterator;

public class Playlist : IEnumerable<string>
{
    private readonly List<string> _songs = new List<string>();
    private bool _isRandomOrder = false;

    public void Add(string song)
    {
        _songs.Add(song);
    }

    public void ToggleRandomOrder()
    {
        _isRandomOrder = !_isRandomOrder;
    }

    public IEnumerator<string> GetEnumerator()
    {
        if (_isRandomOrder)
        {
            var random = new Random();
            var shuffledSongs = new List<string>(_songs);
            for (int i = shuffledSongs.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (shuffledSongs[i], shuffledSongs[j]) = (shuffledSongs[j], shuffledSongs[i]);
            }
            
            return shuffledSongs.GetEnumerator();
        }
        else
        {
            return _songs.GetEnumerator();
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}