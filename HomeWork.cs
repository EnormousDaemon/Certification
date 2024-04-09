// Задача 1: Задайте значения M и N.
//  Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.
// void main()
// {
//     Console.Write("введите начало: ");
//     int M = Convert.ToInt32(Console.ReadLine());
//     Console.Write("введите конец: ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     PrintNumbers(M, N);
// }
// void PrintNumbers(int i, int j)
// {
//     if(i > j)
//         return;
//     Console.Write(i + ", ");
//     i++;
//     PrintNumbers(i, j);
// }
// main();

//-------------------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

// void main()
// {
//     Console.Write("введите M: ");
//     int M = Convert.ToInt32(Console.ReadLine());
//     Console.Write("введите N: ");
//     int N = Convert.ToInt32(Console.ReadLine());
//     Console.Write(Ackerman(N, M));
// }
// int Ackerman(int m, int n)
// {
//     if(m == 0)
//     {
//         return n + 1;
//     } 
//     else if(m > 0 && n == 0)
//     {
//         return Ackerman(m - 1, 1);
//     } 
//     else
//     {
//         return Ackerman(m - 1, Ackerman(m, n - 1));
//     }
// }
// main();

//------------------------------------------------------------------------------------------------------------------------------------------------------

// Задача 3: Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

// void main()
// {
//     System.Console.Write("Введите размер массива: ");
//     int arraySize = Convert.ToInt32(Console.ReadLine());

//     int[] myArray = new int[arraySize];
//     Random rand = new Random();

//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = rand.Next(1, 11);
//     }
//     PrintMas(myArray, arraySize);
//     Console.WriteLine();
//     ShowMas(myArray);
// }
// void PrintMas(int[] mas, int i)
// {
//     i--;
//     if(i < 0) return;
//     PrintMas(mas, i);
//     Console.Write(mas[i] + ", ");
// }
// void ShowMas(int[] mas)
// {
//     foreach(int e in mas)
//         Console.Write(e + ", ");
// }
// main();


СПАСИБО ЗА СЕМИАНРЫ БЫЛО КРУТО.