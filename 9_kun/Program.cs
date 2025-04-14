Console.WriteLine("BMI kalkulyatoriga xush kelibsiz");

// Foydalanuvchidan vaznini so'rash.
Console.WriteLine("Iltimos vazningizni kilogramda kiriting: ");
double weight = Convert.ToDouble(Console.ReadLine());


// Foydalanuvchidan bo'yini so'rash.
Console.WriteLine("Iltimos bo'yingizni metrda kiriting: ");
double height = Convert.ToDouble(Console.ReadLine());

// BMI ni hisoblash

double bmi = weight / (height * height);

Console.WriteLine($"Sizning BMI hisobingiz: {Math.Round(bmi, 2)}");

// Bmi holatini aniqlash

if (bmi < 18.5)
{
  Console.WriteLine("Siz ozg'insiz");
}
else if (bmi >= 18.5 && bmi < 24.9)
{
  Console.WriteLine("Sizning vazningiz normal holatda");
}

else if (bmi >= 25 && bmi < 29.9)
{
  Console.WriteLine("Siz ortiqcha vaznli ekansiz");
}
else
{
  Console.WriteLine("Siz semiz toifasiga kirasiz");
}