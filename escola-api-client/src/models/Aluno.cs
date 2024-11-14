using System;

namespace escola_api_client.models;

public class Aluno : ICloneable
{
    public string Nome { get; set; }
    public string Endereco { get; set; }
    public List<Disciplina> Disciplinas { get; set; }

    public object Clone()
    {
        Aluno alunoClone = (Aluno)this.MemberwiseClone();
        alunoClone.Disciplinas = new List<Disciplina>();
        this.Disciplinas.ForEach(disciplina => 
            alunoClone.Disciplinas.Add((Disciplina)disciplina.Clone()));
        
        return alunoClone;
    }
    
    
}