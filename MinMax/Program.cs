Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > userNumber2)
    {
        Console.WriteLine("Наибольшим числом является: ");
        Console.WriteLine(userNumber1);
        Console.WriteLine("Наименьшим числом является: ");
        Console.WriteLine(userNumber2);
    }
    else if (userNumber1 < userNumber2)
    {
        Console.WriteLine("Наибольшим числом является: ");
        Console.WriteLine(userNumber2);
        Console.WriteLine("Наименьшим числом является: ");
        Console.WriteLine(userNumber1);
}

else if (userNumber1 == userNumber2)
    {
        Console.WriteLine("Числа равны! ");
    }