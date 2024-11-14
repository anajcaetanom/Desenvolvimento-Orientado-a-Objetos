using System.Xml.Serialization;
using escola_api_client.models;

namespace escola_api_client.factories;

public class CriadorXml : IArquivoCriador
{
    public void Salvar(Aluno aluno)
    {
        var xmlSerializer = new XmlSerializer(typeof(Aluno));
        using (var writer = new StreamWriter($"{aluno.Nome}.xml"))
        {
            xmlSerializer.Serialize(writer, aluno);
        }
    }
}