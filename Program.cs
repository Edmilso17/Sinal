int Numero;

Console.WriteLine("Digite um numero: ");
Numero = Convert.ToInt32 (Console.ReadLine());

if (Numero <0 )

{
    Console.ForegroundColor=ConsoleColor.Red;
    Console.WriteLine ("negativo");
}
else if (Numero >0 )
{
    Console.ForegroundColor=ConsoleColor.Green;
    Console.WriteLine ("positivo");    
}
else
{
    Console.ForegroundColor=ConsoleColor.Cyan;
    Console.WriteLine ("zero");
}

Console.ResetColor();