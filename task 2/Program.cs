/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

void CalcArray(int[,] Array)
{ 
    int minSum = 100;
    int minId = 0;
    for (int i = 0; i < Array.GetLength(0); i++){
        int Sum = 0;
        for (int j=0; j < Array.GetLength(1); j++) {
            Sum = (Sum + Array[i,j]);
        }
        if (Sum < minSum) {
            minSum = Sum;
            minId = i;
            }
    }

    Console.Write($"Минимальная сумма элементов - {minSum} в {minId} строке");
}
//--------------------------------------------------------

Console.Write("Укажите колличество строк массива - ");
int m = int.Parse(Console.ReadLine());
Console.Write("Укажите колличество столбцов массива - ");
int n = int.Parse(Console.ReadLine());
int[,] Box = new int[m,n];

    for (int i = 0; i < m; i++){
        for (int j=0; j < n; j++) {
            Box[i,j] = new Random().Next(0,10);
            Console.Write(Box[i,j]);
            Console.Write(" ");
        }
        Console.WriteLine();
    }

Console.WriteLine();
CalcArray(Box);
