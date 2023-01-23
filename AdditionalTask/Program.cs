Console.Clear();
Console.WriteLine("Введите число кустов черники: ");
int nBush = Convert.ToInt32(Console.ReadLine()), resultSum = 0;
while (nBush < 3 || nBush > 1000)
{
    Console.WriteLine($"Данное число не удовлетворяет условию\nВведите число кустов черники (от 3 включительно до 1000 включительно): ");
    nBush = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[nBush];
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"Введите {i + 1} элемент массива (элемент не должен быть от 0 до 1000 включительно): ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    while (array[i] < 0 || array[i] > 1000)
    {
        Console.WriteLine($"Данное число не удовлетворяет условию\nВведите {i + 1} элемент массива (элемент не должен быть от 0 до 1000 включительно): ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}
for (int i = 1; i < array.Length - 1; i++)
{
    if (resultSum < array[i - 1] + array[i] + array[i + 1])
        resultSum = array[i - 1] + array[i] + array[i + 1];
}
if (resultSum < array[nBush - 1] + array[nBush - 2] + array[0])
    resultSum = array[nBush - 1] + array[nBush - 2] + array[0];
if (resultSum < array[0] + array[1] + array[nBush - 1])
    resultSum = array[0] + array[1] + array[nBush - 1];
Console.WriteLine(resultSum);
