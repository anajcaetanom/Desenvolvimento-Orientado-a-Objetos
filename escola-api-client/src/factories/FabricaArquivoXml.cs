namespace escola_api_client.factories;

public class FabricaArquivoXml : IArquivoFactory
{
    public IArquivoCriador CriarArquivo()
    {
        return new CriadorXml();
    }
}