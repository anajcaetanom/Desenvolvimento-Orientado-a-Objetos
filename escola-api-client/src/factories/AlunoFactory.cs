using escola_api_client.models;

namespace escola_api_client.factories;

public class AlunoFactory
{
    public static Aluno CriarAluno(dynamic json)
    {
        Aluno aluno = new Aluno()
        {
            Nome = json.Nome,
            Endereco = json.Endereco,
            Disciplinas = new List<Disciplina>()
        };

        foreach (var DisciplinaJson in json.disciplinas)
        {
            aluno.Disciplinas.Add(new Disciplina
            {
                Nome = DisciplinaJson.Nome,
                Nota = DisciplinaJson.Nota
            });
        }
        
        return aluno;
    }
}