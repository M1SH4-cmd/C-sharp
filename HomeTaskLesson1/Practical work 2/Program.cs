int first = 23;
int second = 7;
Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if(n % 23 == 0 && n % 7 == 0) Console.WriteLine($"Число {n} кратно 23 и 7");
else Console.WriteLine($"Число {n} не кратно 23 и 7");