Console.WriteLine("Ingrese su nota");
int nota = int.Parse(Console.WriteLine());
if (nota >= 65 && nota <= 100)
{
    Console.WriteLine("Aprobado");
}
else if (nota >= 0 && nota < 65)
{
    Console.WriteLine("Reprobado");
}