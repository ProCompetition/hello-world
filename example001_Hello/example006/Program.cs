﻿int a = 2;
int b = 5;
int c = 1;
int d = 9;
int e = 7;

int max = a;

if (a>max) max = a;
if (b>max) max = b;
if (c>max) max = c;
if (d>max) max = d;
if (e>max) max = e;

Console.Write("max = ");
Console.WriteLine(max);