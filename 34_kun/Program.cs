// 🔸 1. Where

//     Method nomi: Where

//     Level: Easy

//     Description: Sizga butun sonlardan iborat massiv berilgan. Faqat juft sonlarni ajratib oling.

//     Example Input: [1, 2, 3, 4, 5, 6]

//     Example Output: [2, 4, 6]

//     Explanation: Where metodi shartga mos keluvchi elementlarni tanlaydi.

// int[] nums = {1, 2, 3, 4, 5, 6};
// var result = nums.Where(x => x % 2 == 0);
// foreach(var i in result)
// {
//   Console.WriteLine(i);
// }


// 🔸 2. Select

//     Method nomi: Select

//     Level: Easy

//     Description: Sonlar ro'yxatidagi har bir elementning kvadratini qaytaring.

//     Example Input: [1, 2, 3, 4]

//     Example Output: [1, 4, 9, 16]

//     Explanation: Select har bir elementga funksiya qo‘llaydi.

// int[] nums = {1, 2, 3, 4};
// var result = nums.Select(x => x * x);

// foreach(var i in result)
// {
//   Console.WriteLine(i);
// }


// 🔸 3. OrderBy

//     Method nomi: OrderBy

//     Level: Easy

//     Description: Berilgan sonlar ro'yxatini o'sish tartibida saralang.

//     Example Input: [5, 1, 4, 2]

//     Example Output: [1, 2, 4, 5]

//     Explanation: OrderBy elementlarni oshish tartibida tartiblaydi.

// int[] nums = {5, 1, 4, 2};
// var result = nums.OrderBy(x => x);
// foreach(var i in result)
// {
//   Console.WriteLine(i);
// }


// 🔸 4. OrderByDescending

//     Method nomi: OrderByDescending

//     Level: Easy

//     Description: Berilgan sonlar ro'yxatini kamayish tartibida saralang.

//     Example Input: [3, 1, 4, 2]

//     Example Output: [4, 3, 2, 1]

//     Explanation: OrderByDescending elementlarni kamayish tartibida tartiblaydi.

// int[] nums = {3, 1, 4, 2};
// var result = nums.OrderByDescending(x => x).ToList();
// foreach(var i in result)
// {
//   Console.WriteLine(i);
// }


// 🔸 5. GroupBy

//     Method nomi: GroupBy

//     Level: Medium

//     Description: Harflardan iborat ro'yxatni guruhlarga ajrating (har bir harf bo‘yicha).

//     Example Input: [“a”, “b”, “a”, “c”, “b”]

//     Example Output:

//         a: [“a”, “a”]

//         b: [“b”, “b”]

//         c: [“c”]

//     Explanation: GroupBy bir xil qiymatlar bo‘yicha guruhlaydi.


// List<string> letters = new List<string>() {"a", "b", "a", "c", "b"};
// var result = letters.GroupBy(l => l);
// foreach(var i in result)
// {
//   Console.WriteLine($"{i.Key} {string.Join(", ", i)}");
// }


// 🔸 6. FirstOrDefault

//     Method nomi: FirstOrDefault

//     Level: Easy

//     Description: Berilgan sonlar orasidan birinchi juft sonni qaytaring, agar topilmasa 0 qaytaring.

//     Example Input: [1, 3, 5, 6]

//     Example Output: 6

//     Explanation: FirstOrDefault shartga mos birinchi elementni qaytaradi, yo‘q bo‘lsa default qiymat.

// int[] nums = {1, 3, 5, 6};

// var result = nums.FirstOrDefault(x => x % 2 == 0);
// Console.WriteLine(result);


// 🔸 7. Any

//     Method nomi: Any

//     Level: Easy

//     Description: Ro'yxatda manfiy son bor-yo'qligini aniqlang.

//     Example Input: [3, -1, 5]

//     Example Output: true

//     Explanation: Any hech bo‘lmaganda bitta element shartga mos keladimi, tekshiradi.

// int[] nums = {3, -1, 5};
// var result = nums.Any(x => x < 0);
// Console.WriteLine(result);


// 🔸 8. All

//     Method nomi: All

//     Level: Easy

//     Description: Ro'yxatdagi barcha sonlar musbat ekanligini tekshiring.

//     Example Input: [1, 2, 3]

//     Example Output: true

//     Explanation: All barcha elementlar shartga mos bo‘lishini tekshiradi.

// int[] sonlar = {2, 4, 6, 8};
// var result = sonlar.All(x => x % 2 == 0);
// Console.WriteLine(result);


// 🔸 9. Sum

//     Method nomi: Sum

//     Level: Easy

//     Description: Ro'yxatdagi barcha sonlar yig'indisini hisoblang.

//     Example Input: [1, 2, 3, 4]

//     Example Output: 10

//     Explanation: Sum barcha qiymatlarni qo‘shadi.

// int[] nums = {1, 2, 3, 4};
// var result = nums.Sum();
// Console.WriteLine(result);


// 🔸 10. Distinct

//     Method nomi: Distinct

//     Level: Easy

//     Description: Takrorlanuvchi elementlarsiz yagona elementlar ro‘yxatini qaytaring.

//     Example Input: [1, 2, 2, 3, 3, 3]

//     Example Output: [1, 2, 3]

//     Explanation: Distinct unikal elementlarni tanlaydi.

// int[] nums = {1, 2, 2, 3, 3, 3};
// var result = nums.Distinct();
// foreach(var i in result)
// {
//   Console.WriteLine(i);
// }


