Console.Clear();
Console.WriteLine("Напишите пятизначное число, чтобы узнать, является ли оно палиндромом: ");
int N = Convert.ToInt32(Console.ReadLine());
string ForLenght = Convert.ToString(N);
int Nlenght = ForLenght.Length;
int units = N % 10;
int dozens = N % 100 / 10;
int thousands = N / 1000 % 10;
int tenthousands = N / 10000;
if (Nlenght != 5)   
    while (Nlenght != 5){
        Console.WriteLine("Число не пятизначное\nНапишите пятизначное число, чтобы узнать, является ли оно палиндромом: ");
        N = Convert.ToInt32(Console.ReadLine());
        ForLenght = Convert.ToString(N);
        Nlenght = ForLenght.Length;
        units = N % 10;
        dozens = N % 100 / 10;
        thousands = N / 1000 % 10;
        tenthousands = N / 10000;
    }
    if (units == tenthousands && dozens == thousands)
        Console.WriteLine("Да, это число является палиндромом");
    else 
        Console.WriteLine("Нет, это число не является палиндромом");