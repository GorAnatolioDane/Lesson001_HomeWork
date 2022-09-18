Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 0 ;
while (count < userNumber - 1) //"-1 костыль,пока не понял как без него"//
{
    count += 2;
    Console.Write(count + " ");
}