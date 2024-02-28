/*
* Scrieti un program care va afisa suma cifrelor unui numar n, n fiind citit de la tastatura
*/

Console.WriteLine("Introduceti un numar");
int numar = int.Parse(Console.ReadLine());
int x = numar;
int sumaCifre = 0;

while (x > 0)
{
    int r = x % 10;
    sumaCifre = sumaCifre + r;
    x = x / 10;
}
Console.WriteLine("Suma cifrelor numarului " + numar  + " este: " + sumaCifre);