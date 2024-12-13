using padrao_composite.Interfaces;

namespace padrao_composite;

public class MenuItem : IMenuComponent
{
    private string nomeProduto = "caquinha";
    
    public void Display()
    {
        Console.WriteLine(nomeProduto);        
    }
    
}