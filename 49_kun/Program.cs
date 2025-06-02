// 1. ref bilan sonni ikki barobar oshirish:

// void DoubleValue(ref int x) => x *= 2;

// int num = 5;
// DoubleValue(ref num);
// Console.WriteLine(num);



// 2. out yordamida kvadratni qaytarish:
// void Square(int num, out int square) => square = num * num;

// int num = 5;
// int result;
// Square(num, out result);
// Console.WriteLine(result);


// 3. params yordamida har xil sonlarni ko'paytirish:

// int Multiply(params int[] numbers)
// {
//   int add = 1;
//   foreach (var i in numbers)
//   {
//     add *= i;
//   }
//   return add;
// }

// int result = Multiply(2, 5, 7, 8);
// Console.WriteLine(result);


