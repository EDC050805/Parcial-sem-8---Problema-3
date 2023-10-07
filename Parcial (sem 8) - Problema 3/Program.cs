// See https://aka.ms/new-console-template for more information
Console.WriteLine("\tAlgoritmo para mostrar asteríscos escalonados");
Console.WriteLine("\t*********************************************\n");
Console.Write(" Ingrese un número: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int TerminoAnterior = 0;

for (int i = 0; i < num; i++)
{
    int suma = TerminoAnterior + i;
    TerminoAnterior = i;
    if (suma > 0)
    {
        for (int j = 1; j <= suma; j++)
        {
            Console.Write("*");            
        }
    }
    Console.WriteLine("*");
}