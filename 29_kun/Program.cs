// 🔹 1. List e’lon qilish

// ✅ Masala: Bo‘sh List<int> yaratib, unga 3 ta son qo‘shing va ularni ekranga chiqaring.

// List<int> sonlar = new List<int>();

// sonlar.Add(13);
// sonlar.Add(15);
// sonlar.Add(46);

// foreach(var son in sonlar)
// {
//   Console.WriteLine(son);
// }


// 🔹 2. Add – Element qo‘shish

// ✅ Masala: List<string> yaratib, unga 3 ta ism qo‘shing va ularni chiqarish.

// List<string> ismlar = new List<string>();
// ismlar.Add("Javohir");
// ismlar.Add("Ali");
// ismlar.Add("Bobur");
// ismlar.ForEach(n => Console.WriteLine(n));


// 🔹 3. AddRange – Bir nechta elementlarni qo‘shish

// ✅ Masala: List<int>ga bir vaqtning o‘zida 5, 15, 20 sonlarini qo‘shing.

// List<int> numbers = new List<int>();
// numbers.AddRange(new List<int> {5, 2, 3, 1});

// numbers.ForEach(n => Console.WriteLine(n));


// 🔹 4. Insert – Indeksga qo‘shish

// ✅ Masala: [1, 2, 3] ro‘yxatiga 2-indeksga 99 sonini qo‘shing.

// List<int> numbers = new List<int>(){1,2,3};
// numbers.Insert(2, 99);
// numbers.ForEach(n => Console.WriteLine(n));

// 🔹 5. Remove – Qiymat bo‘yicha o‘chirish

// ✅ Masala: List: [10, 20, 30, 20] dan birinchi 20 ni o‘chiring.

// List<int> sonlar = new List<int>(){10, 20, 30, 20};
// sonlar.Remove(20);
// sonlar.ForEach(n => Console.WriteLine(n));


// 🔹 6. RemoveAt – Indeks bo‘yicha o‘chirish

// ✅ Masala: [10, 20, 30] listidan 1-indeksdagi elementni olib tashlang.

// List<int> sonlar = new List<int>(){10, 20, 30};
// sonlar.RemoveAt(1);
// sonlar.ForEach(n => Console.WriteLine(n));


// 🔹 7. Clear – Barchasini o‘chirish

// ✅ Masala: [5, 10, 15] ro‘yxatni tozalang va element sonini chiqaring.

// List<int> numbers = new List<int>(){5, 10, 15};
// numbers.Clear();
// Console.WriteLine(numbers.Count);


// 🔹 8. Contains – Element mavjudligini tekshirish

// ✅ Masala: [1, 2, 3, 4] listida 3 mavjudligini tekshiring.

// List <int> sonlar = new List<int>(){1,2,3,4};
// bool Bormi = sonlar.Contains(3);
// Console.WriteLine(Bormi);


// 🔹 9. Count – Elementlar soni

// ✅ Masala: [100, 200, 300] ro‘yxatidagi elementlar sonini chiqaring.

// List<int> sonlar = new List<int>(){100, 200, 300};
// Console.WriteLine(sonlar.Count);



// 🔹 10. IndexOf – Element indeksini topish

// ✅ Masala: [7, 8, 9, 10] ro‘yxatida 9 ning indeksini chiqaring.

// List<int> sonlar = new List<int>(){7,8,9,10};
// int findIndex = sonlar.IndexOf(9);
// Console.WriteLine(findIndex);


// 🔹 11. Sort – Saralash

// ✅ Masala: [30, 10, 20] ro‘yxatini o‘sish tartibida saralang.

// List <int> sonlar = new List<int>(){30, 10, 20};
// sonlar.Sort();
// sonlar.ForEach(n => Console.WriteLine(n));


// 🔹 12. Reverse – Teskari tartib

// ✅ Masala: [1, 2, 3, 4] ro‘yxatini teskari tartibda chiqaring.

// List<int> sonlar = new List<int>(){1,2,3,4};
// sonlar.Reverse();
// sonlar.ForEach(n => Console.WriteLine(n));



// 🔹 13. ForEach – Har bir elementga amal

// ✅ Masala: [2, 4, 6] sonlarini ekranga “Element: {qiymat}” tarzida chiqaring.

// List<int> sonlar = new List<int>(){2,4,6};
// sonlar.ForEach(n => Console.WriteLine($"Element: {n}"));


// 🔹 14. Find – Birinchi mos element

// ✅ Masala: [5, 10, 15, 20] ro‘yxatidan 10 dan katta birinchi sonni toping.

// List<int> sonlar = new List<int>(){5, 10, 15, 20};
// int find = sonlar.Find(n => n > 10);
// Console.WriteLine($"Topilgan son: {find}");


// 🔹 15. FindAll – Barcha mos elementlar

// ✅ Masala: [3, 6, 9, 12] ro‘yxatidan 6 dan katta barcha sonlarni chiqarish.

// List<int> sonlar = new List<int>(){3,6,9,12};
// List<int> result = sonlar.FindAll(n => n > 6);
// result.ForEach(n => Console.WriteLine(n));


// 🔹 16. ToArray – Listni massivga o‘girish

// ✅ Masala: [1, 2, 3] ro‘yxatini massivga o‘giring va elementlarini chiqaring.

// List<int> sonlar = new List<int>(){1,2,3};
// int[]sonlarMassiv = sonlar.ToArray();
// foreach(var i in sonlarMassiv) 
// {
//   Console.WriteLine(i);
// }


// 🔹 17. Array dan List yaratish

// ✅ Masala: {5, 10, 15} massivdan List<int> yarating va chiqaring.

// int[] array = {1, 2, 3, 4};
// List<int> sonlar = new List<int>(array);
// sonlar.ForEach(n => Console.WriteLine(n));