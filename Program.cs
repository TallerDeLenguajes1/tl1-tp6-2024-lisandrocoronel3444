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