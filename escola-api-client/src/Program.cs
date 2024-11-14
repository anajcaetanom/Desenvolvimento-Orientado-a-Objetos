using escola_api_client.factories;
using escola_api_client.models;
using escola_api_client.services;
using Newtonsoft.Json.Linq;

namespace escola_api_client;

class Program
{
    private static async Task Main(string[] args)
    {
        var client = ApiClient.GetInstance();

        Console.WriteLine("Fazendo requisição...");
        
        var response = await client.GetAsync("alunos");
        
        if (!response.IsSuccessStatusCode)
        {
            Console.WriteLine("Erro ao obter os dados do webservice.");
        }
        else
        {
            var jsonString = await response.Content.ReadAsStringAsync();
            var alunosJson = JArray.Parse(jsonString);
            
            var alunos = new List<Aluno>();

            foreach (var alunoJson in alunosJson)
            {
                var aluno = AlunoFactory.CriarAluno(alunoJson);
                alunos.Add(aluno);
            }

            IArquivoFactory arquivoFactory = new FabricaArquivoXml();
            var arquivoCriador = arquivoFactory.CriarArquivo();

            foreach (var aluno in alunos)
            {
                arquivoCriador.Salvar(aluno);
                Console.WriteLine($"Arquivo XML criado para: {aluno.Nome}");
            }

        }
    }
}