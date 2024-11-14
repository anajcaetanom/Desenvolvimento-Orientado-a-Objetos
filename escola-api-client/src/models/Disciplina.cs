namespace escola_api_client.models;

public class Disciplina : ICloneable
{
    public string Nome { get; set; }
    public int Nota { get; set; }

    public object Clone()
    {
        return this.MemberwiseClone();
    }
}