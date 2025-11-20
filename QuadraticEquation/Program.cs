Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.Write("Ведіть а:");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведіть b:");
double b = Convert.ToDouble(Console.ReadLine());
Console.Write("Ведіть c:");
double c = Convert.ToDouble(Console.ReadLine());
double D = b * b - 4 * a * c;
Console.WriteLine($"Дискримінант: {D}");

if (D > 0)
{
    double x1 = (-b + Math.Sqrt(D)) / (2 * a);
    double x2 = (-b - Math.Sqrt(D)) / (2 * a);
    Console.WriteLine($"Два корені: x1 = {x1}, x2 = {x2}");
}
else if (D == 0)
{
    double x = -b / (2 * a);
    Console.WriteLine($"Один корінь: x = {x}");
}
else
{
    Console.WriteLine("Розв’язків немає.");
}