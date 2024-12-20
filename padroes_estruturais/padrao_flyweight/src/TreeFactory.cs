using System;
using System.Collections.Generic;

public class TreeFactory
{
    private readonly Dictionary<string, TreeType> _treeTypes = new Dictionary<string, TreeType>();

    public TreeType GetTreeType(string texture, string color)
    {
        string key = $"{texture}_{color}";

        if (!_treeTypes.ContainsKey(key))
        {
            _treeTypes[key] = new TreeType(texture, color);
        }

        return _treeTypes[key];
    }
}