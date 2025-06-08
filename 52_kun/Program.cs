// 🎯 Vazifa: Massivda LINQ orqali ma'lumotlarni filterlash
// 📌 Vazifa sharti (matn ko‘rinishida):

//     Sizda sonlardan iborat massiv mavjud. Ushbu massivdan LINQ yordamida faqat manfiy sonlarni ajratib oling va ularni ekranga chiqaradigan dastur tuzing.

// int[] sonlar = { 1, -53, 43, -6, -1, 3, -7 };
// var manfiySonlar = sonlar.Where(son => 0 > son);
// var tartiblangan = manfiySonlar.OrderBy(x => x);
// foreach (var i in tartiblangan)
// {
//   Console.WriteLine(i);
// }


// 📝 Masala:

//     Sizda ism va yoshlardan tashkil topgan ro‘yxat bor:

//     var odamlar = new List<(string Ism, int Yosh)>
//     {
//         ("Ali", 25),
//         ("Zarina", 30),
//         ("Anvar", 18),
//         ("Gulnoza", 22),
//         ("Aziza", 19)
//     };

//         LINQ yordamida yoshi 20 dan katta bo‘lgan odamlarni ajratib oling.

//         Ularni ismlarining bosh harfi "A" bo‘lganlar ichidan filterlang.

//         Natijani ismlari bo‘yicha alifbo tartibida saralang va ekranga chiqaring.

// var odamlar = new List<(string Ism, int Yosh)>
// {
//   ("Ali", 25),
//   ("Zarina", 30),
//   ("Anvar", 18),
//   ("Gulnora", 22),
//   ("Aziza", 19)
// };

// var kattaYoshlar = odamlar.Where(odam => odam.Yosh > 20);
// var aStart = odamlar.Where(odam => odam.Ism.StartsWith("A"));
// var saralangan = odamlar.OrderBy(odam => odam.Ism);


// foreach (var i in saralangan)
// {
//   Console.WriteLine(i);
// }

