﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("ingrese su edad: .");
//int numero = int.Parse(Console.ReadLine());
//Console.WriteLine($"su edad es: {numero}");

//ejercicio1

//Console.WriteLine("ingrese su nota 1: .");
//float nota1 = float.Parse(Console.ReadLine());
//Console.WriteLine("ingrese su nota 2: .");
//float nota2 = float.Parse(Console.ReadLine());
//Console.WriteLine("ingrese su nota 3: .");
//float nota3 = float.Parse(Console.ReadLine());

//float promedio = (nota1 * 0.2f) + (nota2 * 0.3f) + (nota3 * 0.5f);
//if (promedio >=3)
//{
//    Console.WriteLine("aprobado");
//}
//else
//{
//    Console.WriteLine("reprobado");
//}

//Ejercicio2

Console.WriteLine("Ingrese el precio del producto: ");
float precio = float.Parse(Console.ReadLine());

if (precio >= 100000)
{
    float descuento = precio * 0.10f;
    float total = precio - descuento;
    Console.WriteLine("Se aplicó un 10% de descuento.");
    Console.WriteLine("El precio final es: " + total);
}
else
{
    Console.WriteLine("No se aplica descuento.");
    Console.WriteLine("El precio final es: " + precio);
}
