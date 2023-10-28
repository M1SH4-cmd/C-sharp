// // Вид 1
// void Method1()
// {
//     Console.WriteLine("OG Michael");
// }
// Method1();

// Вид 2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Method2(msg: "Text of message")

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Text", 4);