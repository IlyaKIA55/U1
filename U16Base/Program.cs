﻿int a = 2;
int b = 5;
int c = 8;
int d = 3;
int e = 1;

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;

Console.Write("Максимальное значение= ");
Console.WriteLine(max);