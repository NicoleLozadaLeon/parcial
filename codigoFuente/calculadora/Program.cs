// See https://aka.ms/new-console-template for more information
using TestDemo;

Console.WriteLine("CALCULADORA DE FISICA");
Console.WriteLine("---------------------");
bool option = true;
int n = 0;
int n_while = 0;
Console.WriteLine("Ingresa 1 para habilitar la calculadora");
n = Convert.ToInt32(ConsoleReadLine());
if(n == 1){
    option = false;
}
while(option == false){
    Console.WriteLine("Elige una oppcion:");
    Console.WriteLine("Ingresa 1 para calcular la fuerza dados masa y aceleración (F = m * a).");
    Console.WriteLine("Ingresa 2 para calcular el trabajo dado por fuerza y distancia (W = F * d).");
    Console.WriteLine("Ingresa 3 para calcular la energía cinética dados masa y velocidad (E = 0.5 * m * v^2).");
    n_while = Convert.ToInt32(ConsoleReadLine());
    if(n_while == 1){
        double m;
        double a;
        m = Convert.ToDouble(ConsoleReadLine());
        a = Convert.ToDouble(ConsoleReadLine());
        double F = Mathematics.CalcularFuerza(m, a);
        Console.WriteLine("El resultado es: ", F);

    }
    if(n_while == 2){
        double F;
        double d;
        F = Convert.ToDouble(ConsoleReadLine());
        d = Convert.ToDouble(ConsoleReadLine());
        double F = Mathematics.CalcularTrabajo(F, d);
        Console.WriteLine("El resultado es: ", F);

    }
    if(n_while == 3){
        double m;
        double v;
        m = Convert.ToDouble(ConsoleReadLine());
        v = Convert.ToDouble(ConsoleReadLine());
        double F = Mathematics.CalcularEnergiaCinetica(m, v);
        Console.WriteLine("El resultado es: ", F);

    }

    Console.WriteLine("Escribe 0 si quieres salir del programa");
    n = Convert.ToInt32(ConsoleReadLine());
    if(n == 0){
    option = true;
}
}

