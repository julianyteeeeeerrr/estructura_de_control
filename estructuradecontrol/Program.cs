// See https://aka.ms/new-console-template for more information
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

//Console.WriteLine("Ingrese el precio del producto: ");
//float precio = float.Parse(Console.ReadLine());

//if (precio >= 100000)
//{
//    float descuento = precio * 0.10f;
//    float total = precio - descuento;
//    Console.WriteLine("Se aplicó un 10% de descuento.");
//    Console.WriteLine("El precio final es: " + total);
//}
//else
//{
//    Console.WriteLine("No se aplica descuento.");
//    Console.WriteLine("El precio final es: " + precio);
//}

//prestamo del estudiante

//Console.WriteLine("Ingrese el monto del préstamo solicitado: ");
//float monto = float.Parse(Console.ReadLine());

//float interesAnual = monto * 0.05f; 
//float interesTrimestre = interesAnual / 4;
//float interesMes = interesAnual / 12;

//float totalPagar = monto + (interesAnual * 5);

//Console.WriteLine("interes pagado en un año:" + interesAnual);
//Console.WriteLine("interes pagado en el tercer trimestre:" + interesTrimestre);
//Console.WriteLine("interes pagado en el primer mes:" + interesMes);
//Console.WriteLine("total a pagar incluyendo intereses: " + totalPagar);



//algoritmo colilla

//Console.WriteLine("Ingrese el salario del empleado: ");
//float salario = float.Parse(Console.ReadLine());

//Console.WriteLine("ingrese el valor del ahorro mensual programado: ");
//float ahorro = float.Parse(Console.ReadLine());


//float descuentoEPS = salario * 0.125f;
//float descuentoPension = salario * 0.16f;
//float totalDescuentos = descuentoEPS  + descuentoPension + ahorro;
//float totalRecibir =  salario - totalDescuentos;

//Console.WriteLine("salario del empleado: " + salario);
//Console.WriteLine("Ahorro mensual: " + ahorro);
//Console.WriteLine("Descuento EPS: " + descuentoEPS);
//Console.WriteLine("Descuento Pensión: " + descuentoPension);
//Console.WriteLine("Total a recibir: " + totalRecibir);


//Matricula estudiante

//Console.WriteLine("Ingrese el valor total de la matricula: ");
//float matricula = float.Parse(Console.ReadLine());

//float cuato1 = matricula * 0.40f;
//float cuato2 = matricula * 0.25f;
//float cuato3 = matricula * 0.20f;
//float cuato4 = matricula * 0.15f;

//Console.WriteLine("priemra cuota (40%): " + cuato1);
//Console.WriteLine("segunda cuota (25%): " + cuato2);
//Console.WriteLine("tercera cuota (20%): " + cuato3);
//Console.WriteLine("cuarta cuota (15%): " + cuato4);

//solicitar año de nacimiento

//Console.WriteLine("Ingrese su nombre:");
//string nombre = Console.ReadLine();

//Console.WriteLine("Ingrese su dirección:");
//string direccion = Console.ReadLine();

//Console.WriteLine("Ingrese su año de nacimiento:");
//int añoNacimiento = int.Parse(Console.ReadLine());

//int edad = 2025 - añoNacimiento;

//Console.WriteLine("Nombre: " + nombre);
//Console.WriteLine("Dirección: " + direccion);
//Console.WriteLine("Año de nacimiento: " + añoNacimiento);
//Console.WriteLine("Edad: " + edad + " años");

//Baldes de agua

//Console.WriteLine("Ejercicio 4");
//Console.WriteLine("Un balde de 1 litro tarda 1 hora y media en llenarse.");

//// Tiempo que tarda el balde de 1 litro (en horas)
//float tiempo1Litro = 1.5f;

//// Calcular tiempo para baldes de 3 y 5 litros
//float tiempo3Litros = tiempo1Litro * 3;
//float tiempo5Litros = tiempo1Litro * 5;

//Console.WriteLine("Tiempo para llenar balde de 1 litro: " + tiempo1Litro + " horas");
//Console.WriteLine("Tiempo para llenar balde de 3 litros: " + tiempo3Litros + " horas");
//Console.WriteLine("Tiempo para llenar balde de 5 litros: " + tiempo5Litros + " horas");

//montaña de 7 metros

//Console.WriteLine("Ejercicio 5");
//Console.WriteLine("Una persona tarda 5 horas en subir una montaña de 7 metros.");

//Console.WriteLine("Ingrese la altura (en metros) que desea subir:");
//float altura = float.Parse(Console.ReadLine());

//// Regla de tres simple: (tiempo * nueva_altura) / altura_total
//float tiempo = (5 * altura) / 7;

//Console.WriteLine("El tiempo estimado para subir " + altura + " metros es: " + tiempo + " horas");


//prestamo estudiante

//Console.WriteLine("Ejercicio 6");
//Console.WriteLine("Un estudiante realiza un préstamo a 5 años con una tasa fija de interés del 5% anual.");

//Console.WriteLine("Ingrese el monto del préstamo:");
//double prestamo = double.Parse(Console.ReadLine());

//double tasa = 0.05; 
//int años = 5;


//double interesAnual = prestamo * tasa;
//double interesTrimestre = interesAnual / 4 * 3; 
//double interesMensual = interesAnual / 12; 
//double totalInteres = interesAnual * años;
//double totalPagar = prestamo + totalInteres;

//Console.WriteLine("Interés pagado en un año: $" + interesAnual);
//Console.WriteLine("Interés pagado en el tercer trimestre: $" + interesTrimestre);
//Console.WriteLine("Interés pagado en el primer mes: $" + interesMensual);
//Console.WriteLine("Total a pagar (capital + intereses): $" + totalPagar);

{
    //    int[] numeros = new int[3];
    //    for (int i = 0; i < 3; i++)
    //    {
    //        Console.WriteLine("Ingrese un numero:" + (i + 1) + ":");
    //        numeros[i] = int.Parse(Console.ReadLine());


    //    }
    //    Console.WriteLine("\nnumeros ingresados:");
    //    foreach (var item in numeros)
    //    {
    //        Console.WriteLine(item);
    //    }
    //    int suma = 0;
    //    for (int i = 0; i < 3; i++)
    //    {
    //        suma += numeros[i];
    //    }
    //    Console.WriteLine("\nLa suma de los numeros es: " + suma);

    //List<int> numeros = new List<int>();
    //numeros.Add(10);
    //numeros.Add(20);
    //numeros.Add(30);
    //Console.WriteLine("Numeros en la lista:");
    //foreach (int item in numeros)
    //{
    //    Console.WriteLine(item);
    //}
    ////acceder a un elemento por su indice
    //int primernumero = numeros[1];
    //Console.WriteLine($"El  numero en la lista es: " + primernumero);
    ////modificar elemento en la lista
    //numeros[2] = 50;
    //Console.WriteLine($"Numero modificado: {numeros[2]}");

    ////insertar un elemento en una posicion especifica
    //numeros.Insert(2, 15);
    //Console.WriteLine($"Numero modificado: {numeros[2]}");

    ////eliminar un elemento de la lista especifico
    //numeros.Remove(1);//elimina la posicion 1

    ////eliminar un elemento por su valor

    //numeros.Remove(10);//elimina el valor 10


    {
        {

            {
                // Aquí guardaremos los nombres y precios de los productos
                List<string> nombres = new List<string>();
                List<double> precios = new List<double>();

                int opcion = 0;

                // El programa se repite hasta que el usuario elija salir
                while (opcion != 5)
                {
                    // Mostramos el menú

                    Console.WriteLine("     MENÚ DE OPCIONES   ");

                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("2. Mostrar productos");
                    Console.WriteLine("3. Actualizar producto");
                    Console.WriteLine("4. Eliminar producto");
                    Console.WriteLine("5. Salir");
                    Console.Write("Elige una opción: ");

                    // Leemos la opción del usuario
                    opcion = int.Parse(Console.ReadLine());

                    // Usamos if (porque es más fácil que switch para principiantes)
                    if (opcion == 1)
                    {
                        Console.Write("Escribe el nombre del producto: ");
                        string nombre = Console.ReadLine();

                        Console.Write("Escribe el precio del producto: ");
                        double precio = double.Parse(Console.ReadLine());

                        nombres.Add(nombre);
                        precios.Add(precio);

                        Console.WriteLine(" Producto agregado con éxito!");
                    }
                    else if (opcion == 2)
                    {
                        Console.WriteLine("\nLISTA DE PRODUCTOS ");
                        if (nombres.Count == 0)
                        {
                            Console.WriteLine("No hay productos aún.");
                        }
                        else
                        {
                            for (int i = 0; i < nombres.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + nombres[i] + " - $" + precios[i]);
                            }
                        }
                    }
                    else if (opcion == 3)
                    {
                        Console.WriteLine("\n ACTUALIZAR PRODUCTO ");
                        Console.Write("Número del producto a actualizar: ");
                        int pos = int.Parse(Console.ReadLine()) - 1;

                        if (pos >= 0 && pos < nombres.Count)
                        {
                            Console.Write("Nuevo nombre: ");
                            nombres[pos] = Console.ReadLine();

                            Console.Write("Nuevo precio: ");
                            precios[pos] = double.Parse(Console.ReadLine());

                            Console.WriteLine(" Producto actualizado!");
                        }
                        else
                        {
                            Console.WriteLine(" Número inválido.");
                        }
                    }
                    else if (opcion == 4)
                    {
                        Console.WriteLine("\n ELIMINAR PRODUCTO ");
                        Console.Write("Número del producto a eliminar: ");
                        int pos = int.Parse(Console.ReadLine()) - 1;

                        if (pos >= 0 && pos < nombres.Count)
                        {
                            nombres.RemoveAt(pos);
                            precios.RemoveAt(pos);
                            Console.WriteLine(" Producto eliminado!");
                        }
                        else
                        {
                            Console.WriteLine(" Número inválido.");
                        }
                    }
                    else if (opcion == 5)
                    {
                        Console.WriteLine(" Saliendo del programa...");
                    }
                    else
                    {
                        Console.WriteLine(" Opción no válida, intenta otra vez.");
                    }










