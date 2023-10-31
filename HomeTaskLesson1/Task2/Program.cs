int i = 2;
Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
for(i = 2; i <= n; i = i + 2)
{
    Console.Write(i + " ");
}

