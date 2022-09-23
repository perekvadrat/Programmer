// https://codeforces.com/contest/723/problem/A

int x1 = 20;
int x2 = 20;
int x3 = 10;

int max = x1;
int min = x1;

if (x2 > max) max = x2;
if (x3 > max) max = x3;

if (x2 < min) min = x2;
if (x3 < min) min = x3;

Console.WriteLine(max-min);