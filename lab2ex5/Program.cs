﻿/*
* Sa se scrie un program care citeste de la tastatura un sir de n numere naturale si determina
* media aritmetica a celor pare, n fiind citit de la tastatura.
*/

Console.WriteLine("Specificati cate numere ar trebui sa aiba sirul:");
int numereSir = int.Parse(Console.ReadLine());


int sumaNumerePare = 0;
float medieNumerePare = 0;
int numerePare = 0;
int i = 1;
while (i <= numereSir)
{
    Console.WriteLine("Introduceti numarul " + i);
    int numarIntrodus = int.Parse(Console.ReadLine());
    if (numarIntrodus % 2 == 0)
    {
        numerePare = numerePare + 1;
        sumaNumerePare = sumaNumerePare + numarIntrodus;
        medieNumerePare = ((float)sumaNumerePare / (float)numerePare);
    }

    i = i + 1;
}

Console.WriteLine("Media aritmetica pentru numerele pare este: " + medieNumerePare);