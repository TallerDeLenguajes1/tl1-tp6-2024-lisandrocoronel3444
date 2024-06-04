// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;

a = 10;
 
b = a;

Console.WriteLine("Valor de a: " +a);
Console.WriteLine("Valor de b: " +b);
Console.WriteLine("Ingrese un valor: ");

String valor = Console.ReadLine();
if(int.TryParse(valor, out int numero)){
    if(numero > 0){
        Console.WriteLine("El numero es: " + numero + " y su invertido es: " + invertirNum(numero));

    }else{
        Console.WriteLine("ingrese un valor mayor a 0");
    }
}else{
    Console.WriteLine("Entrada invalida");
}

static int invertirNum(int numero){

    int numeroInvertido = 0;
    while(numero > 0){
        int digito = numero % 10;
        numeroInvertido = numeroInvertido * 10 + digito;
        numero /= 10;
    }
    return numeroInvertido; 


}

bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Bienvenido a la Calculadora");
            Console.WriteLine("Seleccione la operación que desea realizar:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Valor absoluto");
            Console.WriteLine("6. Cuadrado");
            Console.WriteLine("7. Raíz Cuadrada");
            Console.WriteLine("8. Seno");
            Console.WriteLine("9. Coseno");
            Console.WriteLine("10. Parte Entera");
            Console.WriteLine("11. Máximo entre dos números");
            Console.WriteLine("12. Mínimo entre dos números");
            Console.WriteLine("13. Salir");
            
            int opcion;
            if (!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 13)
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                continue;
            }

            if (opcion == 13)
            {
                Console.WriteLine("Gracias por usar la calculadora.");
                break;
            }

            if (opcion <= 4)
            {
                Console.WriteLine("Ingrese el primer número:");
                int num1;
                if (!int.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Número inválido. Por favor, ingrese un número válido.");
                    continue;
                }

                Console.WriteLine("Ingrese el segundo número:");
                int num2;
                if (!int.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Número inválido. Por favor, ingrese un número válido.");
                    continue;
                }

                int resultado = 0;

                switch (opcion)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        if (num2 != 0)
                        {
                            resultado = num1 / num2;
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede dividir entre cero.");
                            continue;
                        }
                        break;
                }

                Console.WriteLine("El resultado es: " + resultado);
            }
            else if (opcion >= 5 && opcion <= 10)
            {
                Console.WriteLine("Ingrese un número:");
                double num;
                if (!double.TryParse(Console.ReadLine(), out num))
                {
                    Console.WriteLine("Número inválido. Por favor, ingrese un número válido.");
                    continue;
                }

                double resultado = 0;

                switch (opcion)
                {
                    case 5:
                        resultado = Math.Abs(num);  // Valor absoluto
                        break;
                    case 6:
                        resultado = Math.Pow(num, 2);  // Cuadrado
                        break;
                    case 7:
                        if (num >= 0)
                        {
                            resultado = Math.Sqrt(num);  // Raíz cuadrada
                        }
                        else
                        {
                            Console.WriteLine("Error: No se puede calcular la raíz cuadrada de un número negativo.");
                            continue;
                        }
                        break;
                    case 8:
                        resultado = Math.Sin(num);  // Seno
                        break;
                    case 9:
                        resultado = Math.Cos(num);  // Coseno
                        break;
                    case 10:
                        resultado = Math.Truncate(num);  // Parte entera
                        break;
                }

                Console.WriteLine("El resultado es: " + resultado);
            }
            else if (opcion == 11 || opcion == 12)
            {
                Console.WriteLine("Ingrese el primer número:");
                double num1;
                if (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Número inválido. Por favor, ingrese un número válido.");
                    continue;
                }

                Console.WriteLine("Ingrese el segundo número:");
                double num2;
                if (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Número inválido. Por favor, ingrese un número válido.");
                    continue;
                }

                double resultado;

                if (opcion == 11)
                {
                    resultado = Math.Max(num1, num2);  // Máximo entre dos números
                }
                else // opcion == 12
                {
                    resultado = Math.Min(num1, num2);  // Mínimo entre dos números
                }

                Console.WriteLine("El resultado es: " + resultado);
            }

            Console.Write("¿Desea realizar otra operación? (S/N): ");
            string respuesta = Console.ReadLine();
            if (respuesta.ToUpper() != "S")
            {
                continuar = false;
            }
        }