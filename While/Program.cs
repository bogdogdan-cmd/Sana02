Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;

Console.WriteLine("n=");
int n = int.Parse(Console.ReadLine());

double a = 0;
for (int index = 1; index <= n; index++)
{
    a += Math.Pow(-1, index) / (2 * index + 1);

}

int i = 1;
double b = 0;
while (i <= n)
{
    b += 1 + 1.0 / (i * i);
    i++;
}

int j = 1;
double c = 0;
double factorial = 1;
while (j <= n)
{
    factorial *= j;
    c += factorial;
    j++;
}
Console.WriteLine($"a={a}");
Console.WriteLine($"b={b}");
Console.WriteLine($"c={c}");