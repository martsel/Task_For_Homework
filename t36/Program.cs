// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array = new int [6];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-10, 11);
    Console.WriteLine(array[i]);
}

int summ = 0;
for(int i = 1; i < array.Length; i+=2)
{
    summ += array[i];
}
 Console.Write("sum");
    Console.WriteLine(summ);
