// https://codeforces.com/contest/1/problem/A

int m = 9;
int n = 9;
int a = 4;

if (m != (m / a) * a) m = a * ((m / a) + 1);
if (n != (n / a) * a) n = a * ((n / a) + 1);

Console.WriteLine((m * n) / (a * a));