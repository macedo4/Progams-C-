// using System;
// using System.Globalization;

// namespace ExemplosFundamentos
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             // Configurar a cultura padrão para "pt-BR"
//             CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

//             // Exibir valor monetário em diferentes culturas
//             decimal valorMonetario = 82.90M;
//             Console.WriteLine($"{valorMonetario:C}"); // Cultura padrão "pt-BR"
//             Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); // Cultura "en-US"

//             // Exibir número em formato de porcentagem
//             double porcentagem = 0.3421;
//             Console.WriteLine(porcentagem.ToString("P"));

//             // Formatar número com um padrão específico
//             int numero = 123456;
//             Console.WriteLine(numero.ToString("##-##-##"));
//         }
//     }
// }
