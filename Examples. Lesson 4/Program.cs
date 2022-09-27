// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

// Console.Clear();

// int[] array = { -4, -8, 8, 2 };
// void function(int[] ar)
// {

//     // int[] array = { -4, -8, 8, 2 };
//     int a = -1;
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i] * a} ", "");

//     }

// }
// function(array);




// Console.Clear();

// int[] array = { -4, -8, 8, 2 };

// int name()
// {
//     Console.Write("Введите число: ");
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// void function(int[] array, int num)
// {
//     string result = String.Empty;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (num == array[i])
//         {
//             result = "Да";
//             break;

//         }
//         else
//         {
//             result = "Нет";
//         }
//     }
//     Console.WriteLine(result);

// }

// function(array, name());


// Console.Clear();

// int[] inputArray()
// {
//     int[] array = new int[123];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 201);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }


// int amountOfElements(int[] arr)
// {
//     int count = 0;
//     for (int j = 0; j < arr.Length; j++)
//     {
//         if ((arr[j] >= 10) && (arr[j] <= 99))
//         {
//             count++;
//         }

//     }
//     return count;

// }

// int[] A = inputArray();
// int amount = amountOfElements(A);
// PrintArray(A);
// Console.WriteLine();
// Console.WriteLine(amount);



// Console.Clear();

// int[] inputArray()
// {
//     int[] array = new int[10];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(0, 10);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// int[] result(int[] array)
// {
//     int size = array.Length / 2;
//     int[] arrResult = new int[size];
//     int res = 0;
//     int index = 0;
//     for (int i = 0; i < size; i++)
//     {
//         int len = array.Length - 1;
//         res = array[index] * array[len - index];
//         arrResult[index] = res;
//         index++;

//     }
//     return arrResult;

// }


// int[] A = inputArray();
// PrintArray(A);
// Console.WriteLine();
// int[] B = result(A);
// PrintArray(B);
// Console.WriteLine();