// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число А:");
long a = Convert.ToInt64(Console.ReadLine());
Console.WriteLine("Введите число B:");
long b = Convert.ToInt64(Console.ReadLine());
long pow = a;
for (int count = 1; count < b;) {
a = a * pow;
count += 1;
}
Console.WriteLine(a);
