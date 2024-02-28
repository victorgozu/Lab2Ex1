/*
* Scrieti un program care va determina daca un numar negativ citit de la tastatura
* este divizil cu 2 si nu este divizibil cu 6 
*/


Console.WriteLine("Introduceti un numar negativ:");
float a = float.Parse(Console.ReadLine());

if (a >= 0)
{
    Console.WriteLine("Numarul nu este negativ!");
}
else if (a % 2 == 0 && a % 6 != 0)
{
    Console.WriteLine("Numarul este divizil cu 2 si nu este divizibil cu 6");
}
else
{
    Console.WriteLine("Numarul nu respecta criteriul: divizibil cu 2 si nedivizibil cu 6");
}