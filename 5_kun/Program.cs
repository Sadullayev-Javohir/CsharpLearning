// **Oddiy**


// 1. Berilgan sonni musbat yoki manfiy ekanligini aniqlang:
//     Bu misolda, sizga biror son beriladi va uning musbat yoki manfiy ekanligini aniqlashingiz kerak. Agar son ijobiy bo'lsa, "musbat", aks holda "manfiy" deb chiqariladi.

// Console.WriteLine("Biror Son kiriting: ");
// string input = Console.ReadLine();
// int number = Convert.ToInt32(input);

// if (number > 0)
// {
//   Console.WriteLine("Musbat");
// }
// else
// {
//   Console.WriteLine("Manfiy");
// }



// 2.Berilgan yosh bo'yicha voyaga yetganlikni tekshiring:
//     Bu savolda, foydalanuvchidan yosh olinadi va agar u 18 yoki undan katta bo'lsa, u "voyaga yetgan" deb hisoblanadi. Aks holda "voyaga yetmagan" deb javob qaytariladi.

// int age = 17;

// if (age >= 18)
// {
//   Console.WriteLine("Voyaga yetgan");
// }
// else
// {
//   Console.WriteLine("Voyaga yetmagan");
// }



// 3.Berilgan raqamni juft yoki toq ekanligini aniqlang:
//     Raqamning juft yoki toq ekanligini tekshirishingiz kerak. Agar raqamni 2 ga bo'lishda qolgan qism 0 bo'lsa, u juft; aks holda toq raqamdir.

// int num = 4;

// if (num % 2 == 0)
// {
//   Console.WriteLine("Juft son");
// }
// else
// {
//   Console.WriteLine("Toq son");
// }



// 4.Berilgan sonning manfiy, nol yoki musbat ekanligini aniqlang:
//     Bu yerda, siz biror sonni tekshirishingiz va uning manfiy, nol yoki musbat ekanligini aniqlashingiz kerak. Agar son 0 dan kichik bo'lsa, manfiy; 0 ga teng bo'lsa, nol; aks holda musbat deb chiqariladi.

// int num = 0;

// if (num > 0)
// {
//   Console.WriteLine("Musbat son");
// }
// else if (num == 0)
// {
//   Console.WriteLine("Nolga teng");
// }
// else
// {
//   Console.WriteLine("Manfiy son");
// }


// 5.Berilgan ball bo'yicha baholarni aniqlang (kam, o'rtacha, yaxshi):
//     Bu misolda, foydalanuvchidan ball olinadi va u 0-50 oralig'ida bo'lsa "kam", 51-75 oralig'ida bo'lsa "o'rtacha", 76-100 oralig'ida bo'lsa "yaxshi" deb baholanishi kerak.

// int ball = 50;

// if (ball <= 50)
// {
//   Console.WriteLine("Kam");
// }
// else if (ball <= 75)
// {
//   Console.WriteLine("O'rtacha");
// }
// else if (ball <= 100)
// {
//   Console.WriteLine("yaxshi");
// }


// **O'rtacha**

// 1.Berilgan yilni kabisat yil yoki oddiy yil ekanligini aniqlang:

//     Bu savolda, berilgan yil kabisat yili yoki oddiy yil ekanligini aniqlaysiz. Kabisat yili bo'lishi uchun yil 4 ga bo'linishi kerak, lekin agar 100 ga bo'linadigan bo'lsa, 400 ga ham bo'linishi kerak.

// int yil = 2020;
// if (yil % 4 == 0 && yil % 100 != 0)
// {
//   Console.WriteLine("Kabisa yili");
// }
// else if (yil % 100 == 0 && yil % 400 == 0)
// {
//   Console.WriteLine("Kabisa yili");

// }
// else
// {
//   Console.WriteLine("Kabisa yili emas");
// }



// 2.Berilgan harorat bo'yicha ob-havo holatini tekshiring (issiq, sovuq, o'rtacha):

//     Bu misolda, berilgan harorat bo'yicha ob-havo holatini tekshirishingiz kerak. Agar harorat yuqori bo'lsa (masalan, 30°C dan yuqori), "issiq", past bo'lsa (masalan, 10°C dan past), "sovuq", o'rtacha bo'lsa (masalan, 10-30°C oralig'ida), "o'rtacha" deb javob beriladi.


// int harorat = 9;

// if (harorat > 30)
// {
//   Console.WriteLine("Issiq");
// }
// else if (harorat >= 10)
// {
//   Console.WriteLine("O'rtacha");
// }
// else
// {
//   Console.WriteLine("Sovuq");
// }



// 3.Berilgan raqamni uch bo'linadigan yoki to'rt bo'linadiganligini aniqlang:

//     Bu yerda, berilgan raqamning 3 yoki 4 ga bo'linadiganligini tekshirishingiz kerak. Agar raqam 3 yoki 4 ga bo'linadigan bo'lsa, tegishli natija qaytariladi.

// int raqam = 2;

// if (raqam % 3 == 0 || raqam % 4 == 0)
// {
//   Console.WriteLine("Tegishli");
// }
// else
// {
//   Console.WriteLine("Tegishli emas");
// }



// 4.Berilgan so'zning uzunligini tekshirib, qisqa yoki uzun ekanligini aniqlang:

//     Bu misolda, foydalanuvchidan so'z olinadi va uning uzunligi tekshiriladi. Agar uzunligi 5 ta harf yoki undan kam bo'lsa, "qisqa", aks holda "uzun" deb hisoblanadi.


// string word = "resul";

// if (word.Length > 4)
// {
//   Console.WriteLine("Uzun");
// }
// else
// {
//   Console.WriteLine("Qisqa");
// }


// 5.Berilgan sonlar bo'yicha eng katta va eng kichik raqamni aniqlang:

//     Bu yerda, ikkita yoki undan ortiq sonlar berilgan bo'ladi. Siz eng katta va eng kichik sonlarni aniqlab, natijalarni chiqarishingiz kerak.

// int a = 28, b = 26, c = 25;

// if (a > b && a > c)
// {
//   Console.WriteLine($"{a} katta son");
// }
// else if (b > a && b > c)
// {
//   Console.WriteLine($"{b} katta son");

// }
// else
// {
//   Console.WriteLine($"{c} katta son");
// }


// **Murakkab**

// 1.Berilgan odamning ishlash yoshi va tajribasiga qarab malaka bahosini aniqlang:

//     Bu misolda, biror odamning ishlash yoshi va tajribasi beriladi. Agar yoshi 30 dan katta va tajribasi 5 yildan ortiq bo'lsa, "kuchi bilan ishlaydi", aks holda "yosh va tajribasiz" deb natija chiqariladi.

// int yoshi = 31;
// int tajribasiYil = 6;

// if (yoshi > 30 && tajribasiYil > 5)
// {
//   Console.WriteLine("Kuchi bilan ishlaydi");
// }
// else
// {
//   Console.WriteLine("yosh va tajribasiz");
// }


// 2.Berilgan ikki raqamdan qaysi biri ko'proq ekanligini aniqlash (nested if):

//     Bu yerda, ikkita raqam beriladi va ularni if-else konstruktsiyasi yordamida solishtirasiz. Agar birinchi raqam ikkinchisidan katta bo'lsa, birinchi raqam chiqariladi, aks holda ikkinchisi chiqariladi. Bu yerda nested if (ichki if) ishlatiladi.

// int num1 = 3;
// int num2 = 4;

// if (num1 > num2)
// {
//   Console.WriteLine(num1);
// }
// else
// {
//   Console.WriteLine(num2);
// }


// 3.Berilgan sana bo'yicha hafta kunini aniqlash:

//     Bu misolda, foydalanuvchidan sana (masalan, sana raqami) olinadi va shu sana bo'yicha hafta kunini aniqlash kerak (dushanba, seshanba, va hokazo).

// int haftaRaqami = 2;

// if (haftaRaqami == 1)
// {
//   Console.WriteLine("Dushanba");
// }
// else if (haftaRaqami == 2)
// {
//   Console.WriteLine("Seshanba");
// }
// else if (haftaRaqami == 3)
// {
//   Console.WriteLine("Chorshanba");
// }
// else if (haftaRaqami == 4)
// {
//   Console.WriteLine("Payshanba");
// }
// else if (haftaRaqami == 5)
// {
//   Console.WriteLine("Juma");
// }
// else if (haftaRaqami == 6)
// {
//   Console.WriteLine("Shanba");
// }
// else if (haftaRaqami == 7)
// {
//   Console.WriteLine("Yakshanba");
// }
// else
// {
//   Console.WriteLine("Hafta nomi yo'q");
// }



// 4.Agar foydalanuvchi to'lovni to'lagan bo'lsa, xizmatni ko'rsatish, aks holda ogohlantirish yuborish:

//     Bu misolda, foydalanuvchining to'lovni to'laganligi tekshiriladi. Agar to'lov amalga oshirilgan bo'lsa, xizmat ko'rsatiladi, aks holda foydalanuvchiga to'lovni amalga oshirish haqida ogohlantirish yuboriladi.

// bool PayCheck = false;

// if (PayCheck)
// {
//   Console.WriteLine("To'lagan");
// }
// else
// {
//   Console.WriteLine("To'lamagan");
// }



// 5.Foydalanuvchidan ma'lum bir raqam oraliqdagi sonni tanlashni so'rab, to'g'ri yoki noto'g'ri ekanligini tekshirish:

//     Bu misolda, foydalanuvchidan ma'lum bir raqam oraliqdagi sonni tanlashni so'rab, tanlangan raqamning to'g'riligi tekshiriladi.

// Console.WriteLine("1-10 oraliqda son kiriting: ");
// string input = Console.ReadLine();
// int num = Convert.ToInt32(input);

// if (num == 4)
// {
//   Console.WriteLine("Siz topdingiz");
// }
// else
// {
//   Console.WriteLine("Afsuski topolmadingiz");
// }