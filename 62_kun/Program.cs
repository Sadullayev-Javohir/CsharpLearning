using System;
using System.Diagnostics;

// class Program
// {
//   static void Main()
//   {
//     Trace.Listeners.Clear();
//     Trace.Listeners.Add(new ConsoleTraceListener());
//     Trace.WriteLine("Dastur boshlandi");

//     try
//     {
//       int a = 10;
//       int b = 2;
//       int result = a / b;
//     }
//     catch (Exception ex)
//     {
//       Trace.WriteLine($"Xatolik yuz berdi: {ex.Message}");
//     }

//     Trace.WriteLine("Dastur tugadi");
//     Console.WriteLine("Listeners soni: " + Trace.Listeners.Count);

//   }
// }




// class Program
// {
//   static void Main()
//   {
//     string file = "log.txt";

//     TextWriterTraceListener fileListener = new TextWriterTraceListener(file);

//     Trace.Listeners.Add(fileListener);

//     Trace.Listeners.Add(new ConsoleTraceListener());

//     Trace.WriteLine("Dastur boshlandi: " + DateTime.Now);

//     try
//     {
//       int a = 10;
//       int b = 0;
//       int c = a / b;
//     }
//     catch (Exception ex)
//     {
//       Trace.WriteLine("Xatolik" + ex.Message);
//     }
//     Trace.WriteLine("Tugadi: " + DateTime.Now);

//     Trace.Flush();

//     fileListener.Close();
//   }
// }


// using System;
// using Microsoft.Extensions.Logging;

// class Program
// {
//   static void Main(string[] args)
//   {
//     // 1. Loggerni yaratish
//     using var loggerFactory = LoggerFactory.Create(builder =>
//     {
//       builder
//               .AddConsole()
//               .SetMinimumLevel(LogLevel.Information);
//     });

//     ILogger logger = loggerFactory.CreateLogger<Program>();

//     try
//     {
//       Console.WriteLine("Kalkulyatorga xush kelibsiz!");
//       Console.Write("Birinchi sonni kiriting: ");
//       double a = Convert.ToDouble(Console.ReadLine());

//       Console.Write("Ikkinchi sonni kiriting: ");
//       double b = Convert.ToDouble(Console.ReadLine());

//       Console.Write("Amalni tanlang (+, -, *, /): ");
//       string amal = Console.ReadLine();

//       double natija = 0;

//       switch (amal)
//       {
//         case "+":
//           natija = a + b;
//           logger.LogInformation("➕ Qo‘shish amali bajarildi: {A} + {B} = {Natija}", a, b, natija);
//           break;

//         case "-":
//           natija = a - b;
//           logger.LogInformation("➖ Ayirish amali bajarildi: {A} - {B} = {Natija}", a, b, natija);
//           break;

//         case "*":
//           natija = a * b;
//           logger.LogInformation("✖️ Ko‘paytirish amali bajarildi: {A} * {B} = {Natija}", a, b, natija);
//           break;

//         case "/":
//           if (b == 0)
//           {
//             logger.LogError("❌ Nolga bo‘lishga urinish: {A} / {B}", a, b);
//             Console.WriteLine("Xatolik: Nolga bo‘lish mumkin emas.");
//             return;
//           }
//           natija = a / b;
//           logger.LogInformation("➗ Bo‘lish amali bajarildi: {A} / {B} = {Natija}", a, b, natija);
//           break;

//         default:
//           logger.LogError("❌ Noto‘g‘ri amal kiritildi: {Amal}", amal);
//           Console.WriteLine("Noto‘g‘ri amal kiritildi.");
//           return;
//       }

//       Console.WriteLine($"Natija: {natija}");
//     }
//     catch (Exception ex)
//     {
//       logger.LogError(ex, "❌ Istisno holat yuz berdi.");
//       Console.WriteLine("Xatolik yuz berdi: " + ex.Message);
//     }
//   }
// }

