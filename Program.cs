// Задача 47. Задайте двумерный массив размером m×n, заполненный
//случайными вещественными числами.
// Console.Write("Введите количество строк: ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine()!);

// double[,] arr47=GetArr(rows, columns, -10, 10);
// PrintArray(arr47);
//-----методы-----
// double[,] GetArr(int m, int n, double minValue, double maxValue){
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = Math.Round(new Random()
//             .NextDouble()*(maxValue-minValue) + minValue,1);
//         }
//     }
//     return result;
// }
// void PrintArray(double[,] array){
//     for(int i = 0; i < array.GetLength(0); i++){
//         for(int j = 0; j < array.GetLength(1); j++){
//             Console.Write($"{array[i,j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// double[,] GetArrInt(int m, int n, int minValue, int maxValue){
//     double[,] result = new double[m,n];
//     for(int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++){
//             result[i,j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return result;
// }

// bool IsHaveNum(double num, double[,] arr){
//     for(int i = 0; i < arr.GetLength(0); i++){
//         for(int j = 0; j < arr.GetLength(1); j++){
//             if(arr[i,j]==num){
//                 return true;
//             }
//         }
//     }
//     return false;
// }

/*Задача 50. Напишите программу, которая на вход принимает число,
и проверяет есть ли такое число в двумерном массиве, а также возвращает
сообщение о том, что оно найдено или же указание, что такого элемента нет.
*/
// double[,] arr50=GetArrInt(3,4,0,10);
// PrintArray(arr50);
// Console.Write("Введите число для поиска ");
// double numToFind = Convert.ToDouble(Console.ReadLine()!);
// if(IsHaveNum(numToFind, arr50)) Console.WriteLine("Число в массиве есть");
// else Console.WriteLine("Заданного числа в массиве нет");

//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
int[,] arr52=GetArrInt(2,4,0,10);
PrintArray(arr52);
Console.WriteLine();
Console.WriteLine(String.Join(";",ArithmeticMeanOfColumn(arr52)));

//----Методы---
int[,] GetArrInt(int m, int n, int minValue, int maxValue){
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[] ArithmeticMeanOfColumn(int[,] arr)
{
    double[] resultArr = new double[arr.GetLength(1)];
    for (int j = 0; j < arr.GetLength(1); j++){
        double sum = 0;
        for(int i=0; i<arr.GetLength(0);i++){
            sum+=arr[i,j];
        }
        resultArr[j]=Math.Round(sum/arr.GetLength(0),1);
    }
    return resultArr;
}
