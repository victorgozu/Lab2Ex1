/*
* Scrieti un program care va determina daca un numar este sau nu palindrom
*/

Console.WriteLine("Introduceti un numar din mai multe cifre");
int a = int.Parse(Console.ReadLine());


int b, sum = 0, temp;
temp = a;
while (a > 0)
{
    b = a % 10;
    sum = (sum * 10) + b;
    a = a / 10;
    //Console.WriteLine(b + " " + sum + " " + a);
}
if (temp == sum)
    Console.Write("Numarul este palindrom");
else
    Console.Write("Numarul nu este palindrom");