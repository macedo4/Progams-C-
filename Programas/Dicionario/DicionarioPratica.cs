using ExemplosFundamentos.Programas.DicionarioIntrodução;



Dictionary<string, string> estados = new Dictionary<string, string>();
//Chaves e Valores:
estados.Add("AM", "Amazonas");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

//Exibição de Chaves e Valores ainda não alterados
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

Console.WriteLine("===========================");

//Removendo elementos
estados.Remove("BA");
//Alterando elementos
estados["AM"] = "Amazonas - Alteração sombria";

//Exibição de Elementos alterados
foreach(var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}
