Console.Write("Введите число: ");
int namber = int.Parse(Console.ReadLine());
int answer = 0;
if (namber >= 100)
{
while (namber > 999)
    {
        namber = namber / 10; 
    }
answer = namber % 10;
Console.WriteLine($"Ответ: {answer}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
