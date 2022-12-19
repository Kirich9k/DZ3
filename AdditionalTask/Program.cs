Console.Clear();
Console.WriteLine("Введите число кустов черники (от 3 включительно до 1000 включительно): ");
int nBush = Convert.ToInt32(Console.ReadLine());
while (nBush < 3 || nBush > 1000){
       Console.WriteLine($"Данное число не удовлетворяет условию\nВведите число кустов черники (от 3 включительно до 1000 включительно): ");
       nBush = Convert.ToInt32(Console.ReadLine());
}
int[] array = new int[nBush];
for (int i = 0; i < array.Length + 2; i++){
    Console.WriteLine($"Введите {i + 1} элемент массива (элемент не должен быть от 0 до 1000 включительно): ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    while (array[i] < 0 || array[i] > 1000){
       Console.WriteLine($"Данное число не удовлетворяет условию\nВведите {i + 1} элемент массива (элемент не должен быть от 0 до 1000 включительно): ");
       array[i] = Convert.ToInt32(Console.ReadLine());
    }
    array[array.Length] = array[0];
    array[array.Length + 1] = array[1];
    int sum = array[i - 1] + array[i] + array[i + 1];
    int summax = 0;
    if (summax > sum)
        summax = sum;
        Console.WriteLine($"{summax}");
}