Console.WriteLine("Введите количество строк и столбцов в массиве");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
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
void SortRow (int [,] array)
{
for (int i = 0; i<array.GetLength(0); i++)
{
  for (int j=0; j<array.GetLength(1);j++)
    {  int IndexMaxInRow = j;
       for (int k = j+1;k<array.GetLength(1);k++)
         {
         if (array [i,k]> array [i,IndexMaxInRow]) 
         IndexMaxInRow = k;
         }
    int help = array [i,j];
    array [i,j] = array [i,IndexMaxInRow];
    array [i,IndexMaxInRow] = help;
    }
}
}
SortRow (array);
for (int a = 0; a<array.GetLength(0); a++)
{
  for (int b=0; b<array.GetLength(1);b++)
  Console.Write($"{array[a,b]} ");
Console.WriteLine();
}