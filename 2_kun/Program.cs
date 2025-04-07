// O'zgaruvchi - VARIABLE
// datatype variablename = value;

// int - Butun sonlar uchun: int yosh = 20;
// double - Haqiqiy (kasrli) sonlar uchun: double narx = 19.99;
// float - Haqiqiy sonlar (kamroq aniqlik): float oylik = 1050.5f;
// char - Bitta belgi saqlaydi: char belgi = "A";
// string - Matn (belgilar ketma-ketligi): string ism = "Ali";
// bool - Mantiqiy qiymat: true yoki false: bool holat = true;

// Local variables - funksiyalar ichida e'lon qilinadi
// void myFunction()
// {
//   int a = 1;
// }


// Global Variables - sinf (class) darajasida e'lon qilinadi
// class MyClass
// {
//   int globalVar = 5;
// }


// Constant Variables - o'zgarmaydigan qiymat
// const double Pi = 3.14;

// 7.Type Inference (var kalit so'zi)
// var ism = "Ali";
// var yosh = 6;

// 8. Nullable Types (null qiymat olish mumkin bo'lganlar)
// int? yosh = null;
// int? degani bu null bo'lishi mumkin bo'lgan int turidagi o'zgaruvchi.


// using System;

// class Dastur
// {
//   static void Main()
//   {
//     string ism = "Javohir";
//     int yosh = 19;
//     double oylik = 1500.50;

//     Console.WriteLine(ism);
//     Console.WriteLine(yosh);
//     Console.WriteLine(oylik);

//   }
// } 


// 1-Misol
// 🔹 Topshiriq: Quyidagi ma'lumotlarni o‘zgaruvchilarga saqlang va ularni Console.WriteLine() yordamida chiqarib bering:

//     Ism (string)

//     Yil (int)

//     Bo‘y (double)

//     Studentmi yoki yo‘qmi (bool)

// Yechim: 

// string ism = "Javohir";
// int tugilganYil = 2006;
// double boyi = 1.88;
// bool studentmi = true;

// Console.WriteLine($"Ism: {ism}, Tug'ilgan yili: {tugilganYil}, Bo'yi: {boyi}, Studentmi: {studentmi}");

// 2-Misol
// 🔹 Topshiriq: double tipidagi celsius o‘zgaruvchidan foydalangan holda haroratni Fahrenheitga aylantiring. Formula:
// fahrenheit = celsius * 9 / 5 + 32

// double celsius = 25;
// double fahrenheit = celsius * 9 / 5 + 32;
// Console.WriteLine($"{celsius}C == {fahrenheit}F");


// 3-Misol
// 🔹 Topshiriq: firstName va lastName o‘zgaruvchilari berilgan. Ularni birlashtirib, fullName degan yangi string yarating.

// string firstName = "Javohir";
// string lastName = "Sadullayev";
// string fullName = $"{firstName} {lastName}";

// Console.WriteLine(fullName);


// 4-Misol 
// 🔹 Topshiriq: Doiraning radiusi double radius ko‘rinishida berilgan. Yuzasini hisoblang. Formulasi:
// S = π * r * r

// const double Pi = 3.14;
// const double r = 25;
// double S = Pi * r * r;

// Console.WriteLine($"Doiraning yuzasi: {S}");


// 🧩 5-Mashq: Nullable int bilan ishlash

// 🔹 Topshiriq: int? age = null; deb e’lon qiling. Keyin foydalanuvchi yoshini kiritgan/kiritmaganiga qarab quyidagi xabar chiqsin:
//     Agar age != null bo‘lsa: "Yosh: 23"
//     Aks holda: "Yosh kiritilmagan"

// int? age = null;
// Console.Write("Yoshingizni kiriting");

// string input = Console.ReadLine();

// if (!string.IsNullOrEmpty(input))
// {
//   age = Convert.ToInt32(input);
// }
// if (age != null)
// {
//   Console.WriteLine("Yosh: " + age);
// }
// else
// {
//   Console.WriteLine("Yosh kiritmagansiz");
// }