// Задача 47. Задайте двумерный массив размером m×n, заполненный
//случайными вещественными числами.
Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] arr47=GetArr(rows, columns, -10, 10);
PrintArray(arr47);
//-----методы-----
double[,] GetArr(int m, int n, double minValue, double maxValue){
    double[,] result = new double[m,n];
    for(int i = 0; i < m; i++){
        for(int j = 0; j < n; j++){
            result[i,j] = Math.Round(new Random()
            .NextDouble()*(maxValue-minValue) + minValue,1);
        }
    }
    return result;
}
void PrintArray(double[,] array){
    for(int i = 0; i < array.GetLength(0); i++){
        for(int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}