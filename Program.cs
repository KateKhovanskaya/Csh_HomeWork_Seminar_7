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
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

double[,] GetArrInt(int m, int n, int minValue, int maxValue){
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

bool IsHaveNum(double num, double[,] arr){
    for(int i = 0; i < arr.GetLength(0); i++){
        for(int j = 0; j < arr.GetLength(1); j++){
            if(arr[i,j]==num){
                return true;
            }
        }
    }
    return false;
}

/*Задача 50. Напишите программу, которая на вход принимает число,
и проверяет есть ли такое число в двумерном массиве, а также возвращает
сообщение о том, что оно найдено или же указание, что такого элемента нет.
*/
double[,] arr50=GetArrInt(3,4,0,10);
PrintArray(arr50);
Console.Write("Введите число для поиска ");
double numToFind = Convert.ToDouble(Console.ReadLine()!);
if(IsHaveNum(numToFind, arr50)) Console.WriteLine("Число в массиве есть");
else Console.WriteLine("Заданного числа в массиве нет");


