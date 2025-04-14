// // ✅ 1. Shart: Berilgan matnning uzunligini hisoblang.

// string name = "C# Dasturi";
// Console.WriteLine($"Matn uzunligi {name.Length}");


// // ✅ 2. Shart: Berilgan matndagi barcha harflarni katta harfga aylantiring.

// string city = "toshkent";
// string kattaCity = city.ToUpper();
// Console.WriteLine(kattaCity);


// // ✅ 3. Shart: Matnda berilgan so‘z mavjud yoki yo‘qligini tekshiring.

// string text = "Assalomu alaykum!";
// Console.WriteLine(text.Contains("As"));


// // ✅ 4. Shart: Matndan faqatgina 0-indeksdan boshlab 5 ta belgini ajratib oling.

// string word = "Dasturlash";
// string separate = word.Substring(0, 5);
// Console.WriteLine(separate);


// // ✅ 5. Shart: Matnning boshidagi va oxiridagi bo‘sh joylarni olib tashlang.

// string s = "   Hello   ";
// string result = s.Trim();
// Console.WriteLine(result);


// // ✅ 6. Shart: Gapni so‘zlarga ajrating va har bir so‘zni yangi qatorda chiqaring.

// string sentence = "Bu C# dasturi juda qulay.";
// string[] words = sentence.Split(" ");

// foreach (var item in words)
// {
//   Console.WriteLine(item);
// }


// // ✅ 7. Shart: Matnni teskari qilib chiqaring.
// string input = "salom";
// string reversedText = new string(input.Reverse().ToArray());
// Console.WriteLine(reversedText);


// ✅ 8. Shart: StringBuilder yordamida 3 ta so‘zni birlashtirib, bitta jumla hosil qiling.

// using System.Text;

// StringBuilder sb = new StringBuilder();
// sb.Append("C# ");
// sb.Append("dasturlash ");
// sb.Append("tili");
// Console.WriteLine(sb.ToString());


// // ✅ 9. Shart: Ikki matn tengligini tekshiring, katta-kichik harflarga e’tibor bermang.

// string a = "salom";
// string b = "Salom";

// // bool tengmi = (a.ToLower() == b.ToLower());
// bool tengmi = a.Equals(b, StringComparison.OrdinalIgnoreCase);
// Console.WriteLine(tengmi);


// // ✅ 10. Shart: Matndagi so‘zlar sonini hisoblang.
// string input = "Bugun havo juda yaxshi";
// string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// // int count = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
// int count = 0;
// foreach (string word in words)
// {
//   count++;
// }
// Console.WriteLine(count);