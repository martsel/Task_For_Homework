// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// (вводим массив с клавиатуры (т. е. через консоль :) ))


// int[] arr = new int[7];
// Console.Write("Введите первый элемент массива  ");
// int A = Convert.ToInt32(Console.ReadLine());
// A = arr[0];




// // Console.Write ($"{arr[7]} ");

// Console.Write(string.Join(", ", arr));

int[] arr = new int[7];
for (int i = 0; i<=arr.Length; i++)
{
Console.Write($"Введите элемент масима под номером {i+1}  ");
arr[i]=Convert.ToInt32(Console.ReadLine());
}
// Console.Write("Массив: ");
// Console.Write ($"{arr[7]} ");
Console.Write(string.Join(", ", arr));

// for (int i = 0; i<=arr.Length; i++)
// {
//     Console.Write(arr[i]);
// }
