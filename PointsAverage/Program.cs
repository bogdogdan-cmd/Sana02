Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
double sum = 0;
for (int i = 1; i <= 5; i++) {
    Console.Write("Ведіть оцінку:");
    double Bal = Convert.ToDouble(Console.ReadLine());
    sum += Bal; 
}
double averge = sum / 5;
Console.WriteLine($"Середній бал: {averge}");

if (averge >= 50)
{
    Console.WriteLine("Студент допущений до екзамену.");
}
else {
    Console.WriteLine("Студент не допущений до екзамену.");
}