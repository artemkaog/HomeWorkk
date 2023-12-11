//Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
Random rnd = new Random();
Console.WriteLine("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
int k=0;
for (int i=0 ; i<len; i++){
    array[i]= rnd.Next(100,1000);
    Console.Write($"{array[i]} ");
    if (array[i]%2==0) k+=1;
}
Console.WriteLine();
Console.WriteLine(k);
