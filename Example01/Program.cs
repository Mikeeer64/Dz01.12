Console.Write("Введите трёхзначное число: ");
int namber = int.Parse(Console.ReadLine());

int X1 = namber % 100;
int answer = X1 / 10;

Console.WriteLine($"Ответ: {answer}");
