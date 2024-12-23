﻿//--------- ARRAYS UNIDIMENSIONALES ---------
// Los arrays en C# son objetos, por lo tanto ademas, son tipos de referencia. 

// Forma 1: Declaracion y asignacion en una linea sin valores iniciales
// Usando Collection Expressions
int[] array01 = [];

// Forma 2: Declaracion y asignacion en una linea sin valores iniciales con capacidad especificada;
int[] array02 = new int[10];

// o bien, 
int tamanio = 30;
int[] array03 = new int[tamanio];

//Forma 3: Declaracion e inicializacion en una sola linea con elementos
int[] array04 = { 1, 2, 3, 4, 5 };
string[] nombres = { "Juan", "Pepe", "Lucia" };

// Forma 4: Declaracion e inicializacion en varias Lineas
int[] array05;
array05 = new int[10];

// Forma 5: Usando Array.CreateInstance;
Array myArray = Array.CreateInstance(typeof(int), 5);


int[] array06 = [1, 2, 3];



//--------- ARRAYS BIDIMENSIONALES/MATRICES ---------
// Forma 1: Declaracion y asignacion en una linea sin valores iniciales
// NO EXISTE LA FORMA 1; ya que el array debe ser declarado con un tamanio inicial

