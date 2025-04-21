// 1. Masala: Massivdagi barcha elementlarni ekranga chiqarish

// Vazifa: Quyidagi massivni yarating va uning barcha elementlarini ekranga chiqarish uchun foreach tsiklidan foydalaning.

// int[] numbers = { 5, 10, 15, 20, 25 };

// foreach (int num in numbers)
// {
//   Console.WriteLine(num);
// }


// 2. Masala: Massiv elementlarini teskari tartibda chiqarish

// Vazifa: Yuqoridagi massivni yaratib, Array.Reverse() metodidan foydalanib, uni teskari tartibda chiqarish.

// int[] sonlar = new int[] { 1, 2, 3, 4, 5 };
// Array.Reverse(sonlar);
// Console.WriteLine(string.Join(" ", sonlar));


// 3. Masala: Massivning eng katta va eng kichik elementini topish

// Vazifa: Yuqoridagi massivni yaratib, Max() va Min() metodlaridan foydalanib, massivdagi eng katta va eng kichik elementlarni chiqarish.

// int[] sonlar = { 1, 2, 3, 4 };
// int max = sonlar[0];

// foreach (int son in sonlar)
// {
//   max = Math.Max(max, son);
// }

// Console.WriteLine(max);


// 4. Masala: Massiv elementlarini saralash

// Vazifa: Quyidagi massivni yaratib, Array.Sort() metodidan foydalanib, elementlarini o‘sish tartibida saralash.


// int[] sonlar = new int[] { 2, 5, 1, -2, 6, -9 };

// Array.Sort(sonlar);

// Console.WriteLine(string.Join(" ", sonlar));



// 5. Masala: Massivga yangi element qo‘shish

// Vazifa: Massivning oxiriga yangi element qo‘shish uchun yangi massiv yaratib, eski massivni nusxalash va yangi elementni qo‘shing.

// int[] numbers = { 1, 2, 3, 4, 5 };
// int newElement = 7;

// int[] newNumbers = new int[numbers.Length + 1];

// for (int i = 0; i < numbers.Length; i++)
// {
//   newNumbers[i] = numbers[i];
// }
// newNumbers[newNumbers.Length - 1] = newElement;
// Console.WriteLine(string.Join(", ", newNumbers));



//   6. Masala: Massivning o‘rtasidagi elementni chiqarish

// Vazifa: Berilgan massivda o‘rtadagi elementni toping va uni ekranga chiqarish. (Agar massivning juft uzunligi bo‘lsa, ikki o‘rtadagi elementni tanlang).

// int[] sonlar = { 1, 2, 3, 4, 5, 6};
// int sonlarLength = sonlar.Length;

// if (sonlarLength % 2 == 1)
// {
//   int middleIndex = (sonlarLength / 2);
//   Console.WriteLine(sonlar[middleIndex]);
// }
// else
// {
//   int middleIndex1 = (sonlarLength / 2) - 1;
//   int middleIndex2 = (sonlarLength / 2);
//   Console.WriteLine($"{sonlar[middleIndex1]} va {sonlar[middleIndex2]}");
// }



// 7. Masala: Ko‘p o‘lchovli massiv bilan ishlash (2D array)

// Vazifa: Quyidagi ikki o‘lchovli massivni yarating va uni ekranga chiqarish.


// int[,] matrix = {
//   {1, 2},
//   {3, 4},
//   {4, 5},
// };

// for (int i = 0; i < matrix.GetLength(0); i++)
// {
//   for (int j = 0; j < matrix.GetLength(1); j++)
//   {
//     Console.Write(matrix[i, j] + " ");
//   }
//   Console.WriteLine();
// }


// 8. Masala: Jagged Array bilan ishlash

// Vazifa: Quyidagi jagged arrayni yarating va uning barcha elementlarini ekranga chiqarish.


// int[][] jaggedArray = new int[2][];
// jaggedArray[0] = new int[] { 1, 2, 3, 4 };
// jaggedArray[1] = new int[] { 5, 7, 8, 9, 10 };

// for (int i = 0; i < jaggedArray.Length; i++)
// {
//   for (int j = 0; j < jaggedArray[i].Length; j++)
//   {
//     Console.Write(jaggedArray[i][j] + " ");
//   }
//   Console.WriteLine();
// }


// 9. Masala: Massivni yig‘ish (sum)

// Vazifa: Quyidagi massivni yaratib, uning barcha elementlarini qo‘shib, yig‘indisini ekranga chiqarish.

// int[] numbers = { 1, 2, 3, 4, 5 };
// int s = 0;
// foreach (int item in numbers)
// {
//   s += item;
// }

// Console.WriteLine(s);


// 10. Masala: Massivni tekshirish (yig‘indisi 0 ga teng)

// Vazifa: Berilgan massivning barcha elementlari musbat yoki manfiy bo‘lsa, true qaytaruvchi metod yarating. Agar massivdagi barcha elementlarning yig‘indisi 0 ga teng bo‘lsa, false qaytarsin.

// int[] numbers = { 1, -1, 2, -2, 0 };

// bool[] list = new bool[5];

// for (int i = 0; i < numbers.Length; i++)
// {
//   if (numbers[i] > 0) list[i] = true;

//   else if (numbers[i] < 0) list[i] = false;
//   else list[i] = false;
// }

// Console.WriteLine(string.Join(", ", list));