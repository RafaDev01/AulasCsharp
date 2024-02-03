using InterfaceEx;

SalvarXML salvarXml = new SalvarXML();
salvarXml.Salvar();
salvarXml.Nome();


SalvarJson salvarJson = new SalvarJson();
salvarJson.Salvar();
salvarJson.Nome();

ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();

Console.ReadKey();