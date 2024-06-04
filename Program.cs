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
while(continuar)
{
            Console.WriteLine("Bienvenido a la Calculadora");
            Console.WriteLine("Seleccione la operación que desea realizar:");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");
            int opcion;
            if(!int.TryParse(Console.ReadLine(), out opcion) || opcion < 1 || opcion > 5)
            {
                Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                continue;

            }
            if(opcion == 5){
                Console.WriteLine("Gracias por usar calculadora");
                break;
            }
            Console.WriteLine("Ingrese el primer numero");
            int num1; 
            int.TryParse(Console.ReadLine(), out num1);
            Console.WriteLine("Ingrese el segundo numero");
            int num2;
            int.TryParse(Console.ReadLine(), out num2);
            int resultado; 
            switch(opcion)
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
                resultado = num1 / num2;
                break;
                default:
                Console.WriteLine("Opcion invalida");
                continue;

            }
            Console.WriteLine("El resultado es: " + resultado);

}