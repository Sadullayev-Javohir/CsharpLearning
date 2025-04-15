while (true)
{
  Console.WriteLine("Kalkulyator");
  Console.WriteLine("Birinchi sonni kiriting: ");
  int a = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Ikkinchi sonni kiriting: ");
  int b = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine("Ishorani kiriting (*, /, -, +, %): ");
  string ishora = Convert.ToString(Console.ReadLine());
  int result = 0;

  switch (ishora)
  {
    case "*":
      result = a * b;
      break;
    case "/":
      result = a / b;
      break;
    case "-":
      result = a - b;
      break;
    case "+":
      result = a + b;
      break;
    case "%":
      result = a % b;
      break;
  }

  Console.WriteLine(result);
}