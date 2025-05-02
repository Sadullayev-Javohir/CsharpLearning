// ✅ 1. Queue: Mijozlarni kutish navbati

// Shart: Bankda mijozlar navbatga turadi. Har bir mijoz navbatga qo‘shiladi va birma-bir chaqiriladi.

// Queue<string> mijozlarNavbati = new Queue<string>();
// mijozlarNavbati.Enqueue("Ali");
// mijozlarNavbati.Enqueue("Vali");
// mijozlarNavbati.Enqueue("Sami");
// mijozlarNavbati.Enqueue("Yami");
// mijozlarNavbati.Peek();

// Console.WriteLine($"Birinchi navbat: {mijozlarNavbati.Dequeue()}");
// Console.WriteLine($"Ikkinchi navbat: {mijozlarNavbati.Dequeue()}");




// ✅ 2. Queue: Printega hujjat yuborish

// Shart: Kompyuterga ketma-ket 3 ta hujjat printga yuborildi. Ular navbat asosida chiqariladi.

// Queue<string> printQueue = new Queue<string>();
// printQueue.Enqueue("report.docx");
// printQueue.Enqueue("application.docx");
// printQueue.Enqueue("vacation.docx");

// while (0 < printQueue.Count)
// {
//   Console.WriteLine(printQueue.Dequeue());
// }



// ✅ 3. Queue: Ovozli signalni qayta ishlash

// Shart: Qurilma 5 ta signalni qabul qiladi va navbat asosida ularni qayta ishlaydi.

// Queue<int> SignalNumbers = new Queue<int>(new[] {100, 101, 153, 225, 123} );

// while (SignalNumbers.Count > 0) 
// {
//   int signal = SignalNumbers.Dequeue();
//   Console.WriteLine($"Keyingisi: {signal}");
// }


// ✅ 4. Queue: Avtobusga chiqish navbati

// Shart: Yo‘lovchilar navbat bilan avtobusga chiqishadi. Har bir chiqishda navbat yangilanadi.

// Queue<string> passengers = new Queue<string>();
// passengers.Enqueue("Ahmad");
// passengers.Enqueue("Ali");
// passengers.Enqueue("Yamal");
// passengers.Enqueue("Vali");
// passengers.Enqueue("Kamal");

// while (passengers.Count > 0)
// {
//   Console.WriteLine($"{passengers.Dequeue()} avtobusga chiqdi.");
// }


// ✅ 5. Queue: O'yin navbatini boshqarish

// Shart: 4 o'yinchi navbat bilan harakat qiladi.

// class Program
// {
//     static void Main()
//     {
//         Queue<string> players = new Queue<string>();
//         players.Enqueue("Player1");
//         players.Enqueue("Player2");
//         players.Enqueue("Player3");
//         players.Enqueue("Player4");

//         for (int i = 0; i < 2; i++) // Faqat 2 ta aylanish
//         {
//             string current = players.Dequeue();
//             Console.WriteLine($"{current} harakat qiladi.");
//             players.Enqueue(current); // Navbat oxiriga qaytariladi
//         }

//         // Queue holatini ko'rsatamiz
//         Console.WriteLine("\nHozirgi navbat holati:");
//         foreach (var player in players)
//         {
//             Console.WriteLine(player);
//         }
//     }
// }


// ✅ 6. Stack: Matnni teskari yozish

// Shart: Berilgan matn teskari tartibda chiqsin.

// string input = "Salom";

// Stack<char> stack = new Stack<char>();
// foreach(char c in input) 
// {
//   stack.Push(c);
// }

// while (stack.Count > 0)
// {
//   Console.WriteLine(stack.Pop());
// }


// ✅ 7. Stack: Undo funksiyasi

// Shart: Foydalanuvchi ketma-ket 3 amal bajardi, va u oxirgi 2 tasini bekor qilmoqchi.

// Stack<string> stack = new Stack<string>();
// stack.Push("Delete");
// stack.Push("Add");
// stack.Push("Edit");

// stack.Pop();
// stack.Pop();
// foreach(var item in stack) 
// {
//   Console.WriteLine(item);
// }


// ✅ 8. Stack: HTML tag tekshiruvi

// Shart: HTML elementlar to‘g‘ri yopilganmi?

// string[] tags = {"<div>", "<p>", "</p>", "</div>"};

// Stack<string> tagStack = new Stack<string>();

// foreach(string tag in tags)
// {
//   if (!tag.StartsWith("</"))
//   {
//     tagStack.Push(tag);
//   }
//   else 
//   {
//     string openTag = tagStack.Pop();
//     Console.WriteLine($"Matched: {openTag} +  {tag}");
//   }
// }


// ✅ 9. Stack: Sonlar yig‘indisini orqadan hisoblash

// Shart: Sonlar teskari tartibda qo‘shiladi.

// int[] sonlar = {1,2,3,4,5};

// Stack<int> stack = new Stack<int>(sonlar);
// int result = 0;
// while (stack.Count > 0)
// {
//   result += stack.Pop();
//   Console.WriteLine(result);
// }


//   ✅ 10. Stack: Bracket matching (qavslar juftligini tekshirish)

// Shart: Qavslar to‘g‘ri juftlashganini tekshiring.


// string input = "((a + b) * c)";
// Stack<char> stack = new Stack<char>();
// bool isValid = true;

// foreach(char c in input)
// {
//   if (c == '(') stack.Push(c);
//   else if (c == ')')
//   {
//     if (stack.Count == 0) 
//     {
//       isValid = false;
//       break;
//     }
//     stack.Pop();
//   }
// }

// Console.WriteLine(isValid && stack.Count == 0 ? "Qavslar to'g'ri" : "Xato");


