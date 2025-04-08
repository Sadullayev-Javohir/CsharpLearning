// ✅ 1. Assignment + Arithmetic + Logical

// Vazifa: Foydalanuvchi imtihondan 3 ta baho oldi. Agar o‘rtacha 60 dan katta bo‘lsa va ismi bo‘sh bo‘lmasa, u imtihondan o‘tgan hisoblanadi.

// string name = "Javohir";
// int math = 69, english = 59, physics = 54;

// int average = (math + english + physics) / 3;
// bool passed = average >= 60 && name != "";

// Console.WriteLine($"O'rtacha: {average}");
// Console.WriteLine($"Imtihondan o'tgan: {passed}");



// ✅ 2. Relational + Logical
// Vazifa: Agar foydalanuvchi yoshi 18 dan katta va ruxsati bo‘lsa, kirish ruxsat etiladi.

// int age = 20;
// bool hasPermission = true;

// if (age >= 18 && hasPermission)
// {
//   Console.WriteLine("Kirish ruxsat etildi");
// }
// else
// {
//   Console.WriteLine("Kirish taqiqlangan");
// }



// ✅ 3. Null-Coalescing + Ternary

// Vazifa: Foydalanuvchi ism kiritmagan bo‘lsa "Mehmon" deb chiqsin. Baho 90 dan katta bo‘lsa "A", boshqacha bo‘lsa "B".

// string userName = null;
// string nameToShow = userName ?? "Mehmon";

// int score = 90;
// string grade = (score > 90) ? "A" : "B";
// Console.WriteLine(grade);
// Console.WriteLine(nameToShow);



// ✅ 4. Type Check (is/as)

// Vazifa: Agar obyekt string bo‘lsa, uni uzunligini chop etish.

// object obj = "Hello World";

// if (obj is string str)
// {
//   Console.WriteLine($"Matn uzunligi {str.Length}");
// }



// ✅ 5. Massiv bilan boshqa operatorlar
// Vazifa: 5 ta raqam berilgan. Har birini 2 ga ko‘paytirib, yig‘indisini chiqar.
// int[] numbers = { 2, 3, 4, 5};
// int sum = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//   numbers[i] *= 2;
//   sum += numbers[i];
// }
// Console.WriteLine(sum);




