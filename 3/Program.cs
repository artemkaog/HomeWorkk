//Задача 3: Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)
Random rnd = new Random();
Console.WriteLine("Введите длину массива: ");
int len = Convert.ToInt32(Console.ReadLine());
int[] array = new int[len];
int k=0;
for (int i=0 ; i<len; i++){
    array[i]= rnd.Next(1,10);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int[] arr = new int[len];
for ( int i =0; i<len;i++){
    int n = array[i];
    arr[i]=array[len-i-1];
    array[len-i-1]=n;
} 
for (int i = 0; i<len;i++){
    Console.Write($"{arr[i]} ");
}