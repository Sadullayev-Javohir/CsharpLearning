// 1-hafta: C# asoslari va muhit bo‘yicha murakkab test savollari
// 1-kun: C# va .NET kirish

// 1. Quyidagilardan qaysi biri .NET Framework va .NET Core o‘rtasidagi asosiy farqlardan biri hisoblanadi?

//     A) .NET Framework faqat Windowsda ishlaydi, .NET Core esa kross-platformadir
//     B) .NET Core faqat mobil ilovalar uchun, Framework esa faqat web uchun yaratilgan
//     C) .NET Framework ochiq kodli, .NET Core esa yopiq
//     D) .NET Core C# ni qo‘llab-quvvatlamaydi

// 2. C# dasturlash tilining yaratilishida asosiy maqsad nima bo‘lgan?

//     A) O'yinlar ishlab chiqish uchun eng yaxshi til bo'lishi
//     B) JavaScript ni almashtirish
//     C) Zamonaviy, xavfsiz va obyektga yo‘naltirilgan til yaratish
//     D) Faqat mobil dasturlar uchun til yaratish

// 3. .NET SDK o‘rnatilgandan so‘ng terminalda qaysi buyruq yordamida versiyasini tekshirish mumkin?

//     A) csc --version
//     B) dotnet --version
//     C) csharp --v
//     D) netcore -v

// 4. Visual Studio Code’da C# bilan ishlash uchun qaysi kengaytma o‘rnatiladi?

//     A) C++ Tools
//     B) C# by Microsoft
//     C) NetBeans
//     D) IntelliJ IDEA

// 2-kun: Birinchi dastur

// 1. Quyidagi C# dasturida qaysi qatorda xatolik bor?

// using System;
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Salom!");
//         return 0;
//     }
// }

//     A) using System;
//     B) Main metodining parametrlari
//     C) return 0;
//     D) Console.WriteLine() funksiyasida

// 2. Quyidagi C# dasturini ishga tushirganda nima chiqadi?

// class Program
// {
//     static void Main()
//     {
//         Console.Write("A");
//         Console.WriteLine("B");
//     }
// }

//     A) AB
//     B) A\nB
//     C) A\nB\n
//     D) B\nA

// 3. C# dasturining entry point (kirish nuqtasi) qaysi metod hisoblanadi?

//     A) Start()
//     B) Run()
//     C) Main()
//     D) Begin()

// 4. Konsolga foydalanuvchi ismini chiqaruvchi dasturda qaysi to‘g‘ri yozilgan?

//     A) Console.WriteLine(ism);
//     B) Console.WriteLine("ism");
//     C) print(ism);
//     D) Write(ism);

// 3-kun: O‘zgaruvchilar va ma’lumot turlari

// 1. Quyidagi kod natijasini aniqlang:

// decimal x = 3.14M;
// double y = 3.14;
// Console.WriteLine(x == y);

//     A) True
//     B) False
//     C) Xatolik chiqadi
//     D) 3.14

// 2. Quyidagi o‘zgaruvchilar e’lonida xatolik bor:

//     A) string ism = "Ali";
//     B) int a = 5;
//     C) float b = 3.4;
//     D) decimal d = 20.5M;

// 3. bool tipidagi o‘zgaruvchini to‘g‘ri qiymat berish qaysi variantda?

//     A) bool x = 1;
//     B) bool x = "true";
//     C) bool x = false;
//     D) bool x = 't';

// 4. Quyidagi kod natijasini aniqlang:

// float f = 1.5F;
// int i = (int)f;
// Console.WriteLine(i);

//     A) 1.5
//     B) 2
//     C) 1
//     D) Xatolik chiqadi

// 4-kun: Operatorlar

// 1. Quyidagi kod natijasini aniqlang:

// int a = 6, b = 4;
// Console.WriteLine(a / b * 2.0);

//     A) 3
//     B) 2
//     C) 2.0
//     D) 0

// 2. Quyidagi ifodaning natijasi nima bo‘ladi?

// int x = 5, y = 10;
// bool z = (x > 3) && (y < 10) || !(x == 5);
// Console.WriteLine(z);

//     A) True
//     B) False
//     C) 1
//     D) 0

// 3. Quyidagi operatorlardan qaysi biri faqat mantiqiy ifodalar bilan ishlaydi?

//     A) %
//     B) /
//     C) &&
//     D) ==

// 4. Quyidagi kod natijasini aniqlang:

// int a = 10;
// a %= 4;
// Console.WriteLine(a);

//     A) 2
//     B) 4
//     C) 0
//     D) 10

// 5-kun: Shartli operatorlar

// 1. Quyidagi kod natijasini aniqlang:

// int ball = 65;
// if (ball >= 90) Console.WriteLine("A");
// else if (ball >= 80) Console.WriteLine("B");
// else if (ball >= 70) Console.WriteLine("C");
// else if (ball >= 60) Console.WriteLine("D");
// else Console.WriteLine("F");

//     A) A
//     B) B
//     C) D
//     D) F

// 2. Quyidagi switch kodida nima chiqadi?

// int d = 3;
// switch (d)
// {
//     case 1: Console.Write("A"); break;
//     case 2: Console.Write("B");
//     case 3: Console.Write("C"); break;
//     default: Console.Write("D");
// }

//     A) A
//     B) B
//     C) C
//     D) BC

// 3. if-else blokida qaysi yozuv xato hisoblanadi?

//     A) if (x > 0) Console.WriteLine("Musbat");
//     B) if (x == 0) Console.WriteLine("Nol"); else Console.WriteLine("Boshqa");
//     C) if x > 0 Console.WriteLine("Musbat");
//     D) if (x < 10) { Console.WriteLine(x); }

// 4. Quyidagi kod natijasini aniqlang:

// int x = 7;
// Console.WriteLine(x % 2 == 0 ? "Juft" : "Toq");

//     A) Juft
//     B) Toq
//     C) 7
//     D) 0

// 6-kun: Sikllar (Loops)

// 1. Quyidagi kod natijasini aniqlang:

// int sum = 0;
// for (int i = 1; i <= 5; i += 2)
//     sum += i;
// Console.WriteLine(sum);

//     A) 6
//     B) 9
//     C) 15
//     D) 5

// 2. while va do-while sikllari o‘rtasidagi asosiy farq qaysi javobda to‘g‘ri?

//     A) while har doim kamida bir marta bajariladi
//     B) do-while har doim kamida bir marta bajariladi
//     C) do-while va while bir xil ishlaydi
//     D) do-while faqat masssivlar bilan ishlaydi

// 3. Quyidagi kodda nechta son ekranga chiqadi?

// int i = 0;
// while (i < 3)
// {
//     Console.WriteLine(i);
//     i++;
// }

//     A) 1
//     B) 2
//     C) 3
//     D) 0

// 4. foreach sikli haqida noto‘g‘ri fikrni toping:

//     A) Massivlarda ishlatiladi
//     B) Indeks orqali ishlaydi
//     C) Har bir element ustida ishlaydi
//     D) O‘zgarmas kolleksiyalar uchun ham ishlaydi

// 7-kun: 1-hafta takrorlash va amaliyot

// 1. Quyidagi kod natijasini aniqlang:

// int[] arr = { 1, 2, 3 };
// int sum = 0;
// foreach (int x in arr)
//     sum += x;
// Console.WriteLine(sum);

//     A) 0
//     B) 6
//     C) 3
//     D) 1

// 2. Viktorina dasturida foydalanuvchi javobini qanday olish mumkin?

//     A) string javob = Console.ReadLine();
//     B) int javob = Console.WriteLine();
//     C) bool javob = Read();
//     D) var javob = PrintLine();

// 3. Quyidagi kod natijasini toping:

// for (int i = 1; i <= 3; i++)
//     for (int j = 1; j <= 2; j++)
//         Console.Write(i + j);

//     A) 2345
//     B) 234
//     C) 23456
//     D) 23434

// 4. Quyidagi kod natijasini aniqlang:

// string s = "test";
// Console.WriteLine(s.Length);

//     A) 0
//     B) 3
//     C) 4
//     D) xato
