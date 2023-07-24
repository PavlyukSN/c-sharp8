/*
Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

void SortArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++) {
        for (int j = 0; j < Array.GetLength(1); j++){
            int maxMember = Array[i,j];
            int maxId = j;
            for(int k = j+1; k < Array.GetLength(1); k++){
                if (Array[i,k]>maxMember){
                    maxMember = Array[i,k];
                    maxId = k;
                }
            }
            Array[i,maxId] = Array[i,j];
            Array[i,j] = maxMember;
        }       
    }
}
void PrintArray(int[,] Array){
    for (int i = 0; i < Array.GetLength(0); i++){
        for (int j = 0; j < Array.GetLength(1); j++){
            Console.Write(Array[i,j]);
            if(i < Array.Length-1) Console.Write(" ");
        }
        Console.WriteLine();
    }
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

SortArray(Box);
Console.WriteLine();
PrintArray(Box);


