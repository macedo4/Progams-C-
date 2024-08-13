// using System;
// using System.Globalization;

// namespace ExemplosFundamentos.Data
// {
//     public class DataConverter
//     {
//         public string DataString { get; set; }
//         public DateTime Data { get; private set; }
//         public bool Sucesso { get; private set; }

//         public DataConverter(string dataString)
//         {
//             DataString = dataString;
//             Sucesso = TryConvertData(dataString, out DateTime data);
//             Data = data;
//         }

//         private bool TryConvertData(string dataString, out DateTime data)
//         {
//             return DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm",
//                                           CultureInfo.InvariantCulture,
//                                           DateTimeStyles.None, out data);
//         }

//         public void ExibirResultado()
//         {
//             if (Sucesso)
//             {
//                 Console.WriteLine($"Conversão: {Sucesso}");
//             }
//             else
//             {
//                 Console.WriteLine($"CONVERSÃO: {Sucesso}");
//             }

//             Console.WriteLine(Data);
//         }
//     }

//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string dataString = "06-2023-27 18:00";

//             DataConverter converter = new DataConverter(dataString);
//             converter.ExibirResultado();
//         }
//     }
// }
