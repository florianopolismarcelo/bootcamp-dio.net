﻿int[] arrayInteiros = new int[4];

arrayInteiros[0] = 72;
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;


int[] arrayInteiroDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteiroDobrado, arrayInteiros.Length);

//Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2 );

Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição N° {contador} = {arrayInteiros[contador]}");
}


// Console.WriteLine("");
// Console.WriteLine("Percorrendo o Array com o FOREACH");

// int contadorForeach = 0;
// foreach (int valor in arrayInteiros)
// {
//     Console.WriteLine($"Posição N° {contadorForeach} = {valor}");
//     contadorForeach++;
// }