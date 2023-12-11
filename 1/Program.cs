// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
while(true){
    Console.WriteLine("Введите число: ");
    string num = Console.ReadLine();
    if (num=="q") break;
    int x = Int32.Parse(num);
    int sum=0;
    while(x!=0){
        sum+=x%10;
        x/=10;
    }
    if (sum%2==0) break;
}
