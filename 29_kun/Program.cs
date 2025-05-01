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


// 🔹 21. TrimExcess

// Masala: Listda bir necha elementlar o‘chirilgan. Endi List xotirasini optimallashtirish uchun ortiqcha sig‘imni olib tashlang.

// List<int> sonlar = new List<int>(){1, 2, 3, 4, 5, 6};
// sonlar.RemoveRange(1, 2);
// sonlar.ForEach(n => Console.WriteLine(n));


// 🔹 22. GetRange

// Masala: Listning 2-chi indeksidan boshlab 3 ta elementni alohida Listga ajrating.

// List<int> sonlar = new List<int>(){12, 23, 35, 1, 6, 13, 8};
// List<int> subList = sonlar.GetRange(2, 3);
// subList.ForEach(n => Console.WriteLine(n));


// 🔹 23. Exists

// Masala: Listda 10 soni mavjud yoki yo‘qligini tekshiring.

// List<int> sonlar = new List<int>(){1, 4, 7, 10};
// bool bormi10 = sonlar.Exists(n => n == 10);
// Console.WriteLine(bormi10);


// 🔹 24. FindIndex

// Masala: 10 dan katta bo‘lgan birinchi elementning indeksini toping.

// List<int> sonlar = new List<int>(){1,2,3,4,5,11};
// int index = sonlar.FindIndex(n => n > 10);
// Console.WriteLine(index);


// 🔹 25. Last va LastIndexOf

// Masala: Listdagi oxirgi elementni va qiymati 10 bo‘lgan elementning oxirgi indeksini toping.


// List<int> sonlar = new List<int>{10,20,10,30,};
// int last = sonlar.Last();
// int lastindex10 = sonlar.LastIndexOf(10);
// Console.WriteLine(lastindex10);



// 🔹 26. ToString (Listni string ko‘rinishga aylantirish)

// Masala: Listdagi barcha sonlarni vergul bilan ajratilgan stringga aylantiring.

// List<int> sonlar = new List<int>(){1,2,3,4,5};
// string listString = string.Join(", ", sonlar);
// Console.WriteLine(listString);


// 🔹 27. Distinct

// Masala: Listdagi takrorlanuvchi elementlarni olib tashlang.

// List<int> numbers = new List<int>(){1,2,3,4,5,5};
// List<int> distinctNumbers = numbers.Distinct().ToList();
// // Console.WriteLine(string.Join(", ", distinctNumbers));
// distinctNumbers.ForEach(n => Console.WriteLine(n));


// 🔹 28. Union

// Masala: Ikki Listni birlashtiring, takrorlanmas qiymatlarni oling.

// List<int>a = new List<int> {10, 20};
// List<int>b = new List<int> {20, 30};
// List<int>combined = a.Union(b).ToList();
// combined.ForEach(n => Console.WriteLine(n));


// 🔹 29. Intersect

// Masala: Ikkita Listdagi umumiy elementlarni toping.

// List<int> sonlar1 = new List<int> {10, 20, 30};
// List<int> sonlar2 = new List<int> {10, 20};

// List<int> umumiyElem = sonlar1.Intersect(sonlar2).ToList();
// umumiyElem.ForEach(n => Console.WriteLine(n));


// 🔹 30. Except

// Masala: Faqat birinchi Listda bor, ikkinchisida yo‘q bo‘lgan elementlarni toping.

// List<int> first = new List<int>{10,20,30};
// List<int> second = new List<int>{30};
// List<int> diference = first.Except(second).ToList();
// diference.ForEach(n => Console.WriteLine(n));



// 🔹 31. RemoveAll

// Masala: Listdan manfiy sonlarning barchasini olib tashlang.

// List<int> sonlar = new List<int>(){1, -2, 0, -3, 3};
// sonlar.RemoveAll(n => n < 0);
// sonlar.ForEach(n => Console.WriteLine(n));

// 🔹 32. Sort (Custom)

// Masala: Listni kamayish tartibida saralang.

// List<int> sonlar = new List<int>(){2, 1, 7, 3, 8, 4};
// sonlar.Sort((x, y) => y.CompareTo(x));
// sonlar.ForEach(n => Console.WriteLine(n));

// 🔹 33. FindLast

// Masala: 20 dan kichik bo‘lgan oxirgi elementni toping.

// List<int> sonlar = new List<int>() {0, 10, 4, 20, 30,};
// int lastFound = sonlar.FindLast(n => n < 20);
// Console.WriteLine(lastFound);


// 🔹 34. ToList (LINQ)

// Masala: 10 dan katta bo‘lgan elementlarni yangi Listga ajrating.

// List<int> numbers = new List<int>{5, 2, 6, 19, 62};
// List<int> result = numbers.Where(n => n > 10).ToList();
// result.ForEach(n => Console.WriteLine(n));


// 🔹 35. CopyTo

// Masala: Listni arrayga nusxalang.

// List<int> sonlar = new List<int>(){1,2,3,4};
// int[] array = new int[sonlar.Count];
// sonlar.CopyTo(array);

// foreach(var item in array) {
//   Console.WriteLine(item);
// }



