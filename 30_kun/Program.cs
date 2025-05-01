// ✅ 1. Telefon raqamlarini saqlovchi lug‘at tuzing va "Ali"ning raqamini chiqaring.

// Shart:
// Ismlarni kalit, telefon raqamlarini qiymat qilib saqlang. Keyin "Ali"ning raqamini ekranga chiqaring.

// Dictionary<string, string> kontaktlar = new Dictionary<string, string>();
// kontaktlar["Ali"] = "+99893923192";
// kontaktlar["Vali"] = "+99893133298";

// Console.WriteLine(kontaktlar["Ali"]);


// ✅ 2. Berilgan matnda har bir harf necha marta qatnashganini hisoblang.

// Shart:
// "hello" matni berilgan. Har bir harf necha marta qatnashganini Dictionary<char, int> orqali hisoblab chiqaring.

// string text = "Hello";

// var belgi = new Dictionary<char, int>();

// foreach(char c in text) {
//   if (belgi.ContainsKey(c)) {
//     belgi[c] = belgi[c] + 1;
//   } else {
//     belgi[c] = 1;
//   }
// }

// foreach(var a in belgi) {
//   Console.WriteLine($"{a.Key}: {a.Value}");
// }


// ✅ 3. O‘quvchilarning baholarini saqlang va o‘rtacha bahosini hisoblang.

// Shart:
// Har bir o‘quvchi uchun fanlar bo‘yicha baholar ro‘yxatini saqlang. Har bir o‘quvchining o‘rtacha bahosini chiqaring.


// var marks = new Dictionary<string, List<int>> 
// {
//   {"Ali", new List<int>{56, 60, 90}},
//   {"Vali", new List<int>{82, 92, 54}},
// };

// foreach(var student in marks) {
//   double avg = student.Value.Average();
//   Console.WriteLine($"{student.Key} : {avg}");
// }


// ✅ 4. Kalit mavjudligini TryGetValue yordamida tekshiring va qiymatini chiqaring.

// Shart:
// Agar mahsulot ID’si 3 bo‘yicha ma’lumot mavjud bo‘lsa, uning nomini chiqaring. Aks holda "topilmadi" deb yozing.

// var products = new Dictionary<int, string>
// {
//   {1, "Apple"},
//   {2, "Banana"},
// };

// if (products.TryGetValue(3, out string name)) 
//   Console.WriteLine(name);
// else 
//   Console.WriteLine("Topilmadi");



// ✅ 5. Ichma-ich Dictionary yordamida o‘quvchilarning fanlar bo‘yicha ballarini saqlang va chiqarish.

// Shart:
// Har bir o‘quvchi uchun har bir fan bo‘yicha ballarni saqlang. "Ali"ning "English" fani bo‘yicha bahosini chiqaring.

// var school = new Dictionary<string, Dictionary<string, int>>
// {
//   {"Ali", new Dictionary<string, int> {{"Math", 80}, {"English", 90}}},
//   {"Vali", new Dictionary<string, int> {{"Math", 90},{"English", 100}}},
// };

// Console.WriteLine(school["Vali"]["English"]);


// ✅ 6. Shaxslarni ularning yashash joyi bo‘yicha guruhlab chiqaring.

// Shart:
// Berilgan ism va shaharlar ro‘yxatini Dictionary<string, List<string>> shaklida shahar bo‘yicha guruhlang.

// var people = new List<(string Name, string City)>
// {
//   ("Ali", "Tashkent"),
//   ("Vali", "Fergana"),
//   ("Sami", "Samarkand"),
// };

// var grouped = new Dictionary<string, List<string>>();

// foreach(var person in people) {
//   if (!grouped.ContainsKey(person.City)) {
//     grouped[person.City] = new List<string>();
//   }
//   grouped[person.City].Add(person.Name);
// }

// foreach(var i in grouped) {
//   Console.WriteLine($"{i.Key}:{string.Join(", ", i.Value)}");
// }



// ✅ 7. Matndagi so‘zlar takrorlanishini sanang.

// Shart:
// "this is a test this is only a test" matni berilgan. Har bir so‘z necha marta qatnashganini hisoblang.

// string sentence = "this is a test this is only a test";
// var wordCount = new Dictionary<string, int>();

// foreach(string word in sentence.Split())
// {
//   if (wordCount.ContainsKey(word))
//     wordCount[word]++;
//   else 
//     wordCount[word] = 1;
// }

// foreach(var w in wordCount)
//   Console.WriteLine($"{w.Key}: {w.Value}");


// ✅ 8. Login tizimi yaratish: login va parollarni tekshirish.

// Shart:
// Foydalanuvchi login va parol kiritadi. Ular Dictionary<string, string> ichida bor bo‘lsa, muvaffaqiyatli login deb chiqsin.


// if (users.TryGetValue(inputUser, out string correctPass) && correctPass == inputPass)
//   Console.WriteLine("Login muffaqiyatli!");
// else 
//   Console.WriteLine("Login yoki parol xato..");


// ✅ 9. Kalitlar bo‘yicha lug‘atni alifbo tartibida chiqarish.

// Shart:
// Ismlar va ularning ballaridan iborat lug‘atni alifbo bo‘yicha tartiblab chiqaring.

// var scores = new Dictionary<string, int>
// {
//   {"Vali", 85}, {"Sami", 92}, {"Ali", 90}
// };

// foreach (var item in scores.OrderBy(k => k.Key)) 
// {
//   Console.WriteLine($"{item.Key} : {item.Value}");
// }


// ✅ 10. Eng yuqori qiymatga ega bo‘lgan elementni toping.

// Shart:
// Oylar va ularning savdo summalari berilgan. Eng ko‘p savdo bo‘lgan oy va qiymatini chiqaring.


var sales = new Dictionary<string, int>
{
  {"January", 200},
  {"February", 340},
  {"March", 150}
};

var top = sales.OrderByDescending(x => x.Value).First();
Console.WriteLine($"Eng ko'p savdo: {top.Key} - {top.Value}$");