// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите длину массива");
int number = Convert.ToInt32(Console.ReadLine());
Random rng = new Random();
int count = 0;
int[] array = new int[number];
for (int i = 0; i < array.Length; i++){
    array[i] = rng.Next(100, 1000);
    Console.Write($"{array[i]}   ");
    if (array[i] % 2 == 0){
        count++;
    }
}
Console.WriteLine();
Console.WriteLine(count);
