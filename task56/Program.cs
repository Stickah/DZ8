Console.WriteLine("Введите неравное количество строк и столбцов в массиве");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
if (m==n)
Console.WriteLine("Вы ввели равное количество строк и столбцов в массиве! Начните сначала");
else 
{
int [,] array = new int [m,n];
Random rnd = new Random();
for (int i = 0; i<array.GetLength(0); i++)
{
     for (int j=0; j<array.GetLength(1);j++)
     {array[i,j] = rnd.Next(0,10);   
      Console.Write($"{array[i,j]} ");
     }
  Console.WriteLine();
}
Console.WriteLine();
void MinSumInRows (int [,] Arr)
{
int minSum = 0;
int indexRow = 0;
for (int b=0; b<Arr.GetLength(1);b++)
{ 
    minSum = minSum + Arr[0,b];
} 
for (int a = 1; a<Arr.GetLength(0); a++) 
    {
        int Sum = 0;
           for (int b=0; b<Arr.GetLength(1);b++)
            { 
               Sum = Sum + Arr[a,b];
            }
            if (Sum<minSum)
                {
                  minSum = Sum;   
                  indexRow = a;
                }
    }
Console.WriteLine($"это строка {indexRow+1}");
}
MinSumInRows (array);
}