Console.Clear();
Console.WriteLine("Напишите число, чтобы узнать квадраты чисел от 1 до этого числа:");
int N = Convert.ToInt32(Console.ReadLine());
int i = 1;
for (i = 1; i < N; i++)
    Console.Write($"{i * i * i} ");