
//--------------------------Task 47-----------------------------
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine($"\nEnter Massive  m x n:");
int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,99);
    }
  }
}

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}




//-----------------------------------Task 50-------------------------------------
// Задача 50. Напишите программу, которая на вход принимает два числа(строка, столбец), проверяя есть ли такая позиция в двумерном массиве и возвращает сообщение о том, что оно найдено, а также какое число стоит на этом месте или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 3 -> Такой элемент есть: 3
// i = 4, j = 2 -> такого элемента в массиве нет

Console.WriteLine($"\nEnter Massive  m x n:");
int m = InputNumbers("Enter m: ");
int n = InputNumbers("Enter n: ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(1,9);
    }
  }
}
void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}
Console.WriteLine("Enter checking numbers");
 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 if (a == m && b == n)
 {
    Console.WriteLine("Numbers are exist: {(a, b)}");
 }
 

 else
 {
    Console.WriteLine("Numbers are not exist");
 }


//-----------------------Task 52 --------------------------------------
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Enter Massive m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter massive n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[m,n];

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.Next(1,9);
Console.Write($"{randomArray[i,j]} ");
}
Console.WriteLine();
}
}

void arif(int m, int n)
{
Console.Write("Avarage: ");
int i,j;
Random rand = new Random();
for (j = 0; j < n; j++)
{
double sum = 0;
for (i = 0; i < m; i++)
{
sum = sum + randomArray[i,j];
}
Console.Write($"{sum/(i):F1}; ");
}
}
mas(m,n);
arif(m,n);