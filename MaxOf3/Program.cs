Console.WriteLine("Введите первое число: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int userNumber3 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 > userNumber2)
{
    if (userNumber1 > userNumber3)
   {
    Console.WriteLine("Наибольшим числом является :");
    Console.WriteLine(userNumber1);
   } 
   else
   {
    Console.WriteLine("Наибольшим числом является : ");
    Console.WriteLine(userNumber3);
   }
}
else
{
    if (userNumber2 > userNumber3)
    {
        Console.WriteLine("Наибольшим числом является : ");
        Console.WriteLine(userNumber2);
    }
    else
    {
       Console.WriteLine("Наибольшим числом является : ");
        Console.WriteLine(userNumber3);
    }
}