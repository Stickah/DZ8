int [,] array = new int [,] {{2,4,},{3,2}};
int [,] massiv = new int [,] {{3,4,},{3,3}};
int [,] result = new int [2,2];
void Compos (int x,int y,int z, int w)
{
for (int i = 0; i<array.GetLength(1); i++)
result [x,y] = result[x,y]+array[z,i]*massiv[i,w];
Console.Write($"{result[x,y]} ");
}
Compos (0,0,0,0);
Compos (0,1,0,1);
Console.WriteLine();
Compos (1,0,1,0);
Compos (1,1,1,1);