//-----------Programa Principal-----------------
// ---------------------------------------------
// Ejemplo 01 
// 3 Filas / 3 Columnas
int[,] array2D = { { 1, 2, 9 }, { 3, 4, 8 }, { 5, 6, 5 } };

Console.Write(array2D.Length);
Console.Write(array2D.Rank);
Console.Write(array2D.GetLength(0));

int[] array = { 1, 2, 3, 4, 5 };

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}

Array.Reverse(array);

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i]+" ");
}

// ---------------------------------------------
// Ejemplo 02
int[] numeros = new int[6];

numeros[0] = 1;
numeros[1] = 10;
numeros[2] = 14;
numeros[3] = 7;
numeros[4] = 20;
numeros[5] = 45;

for (int i = 0; i < numeros.Length; i++)
{
    Console.Write(numeros[i]+" ");
}

