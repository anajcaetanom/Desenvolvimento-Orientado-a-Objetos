using System;
using System.Collections.Generic;

namespace GraphicEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeFactory treeFactory = new TreeFactory();
            Forest forest = new Forest();

            TreeType oakTreeType = treeFactory.GetTreeType("Oak", "Green");
            forest.AddTree(new Tree(oakTreeType, 10, 20));
            forest.AddTree(new Tree(oakTreeType, 15, 25));
            forest.AddTree(new Tree(oakTreeType, 20, 30));

            TreeType pineTreeType = treeFactory.GetTreeType("Pine", "Dark Green");
            forest.AddTree(new Tree(pineTreeType, 30, 40));
            forest.AddTree(new Tree(pineTreeType, 35, 45));

            forest.Render();
        }
    }
}