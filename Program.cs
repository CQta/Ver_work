System.Console.WriteLine("Введите x1");
double x = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите y1");
double y = double.Parse(Console.ReadLine());
double sum = 0;
System.Console.WriteLine("Введите x2");
double x2 = double.Parse(Console.ReadLine());
System.Console.WriteLine("Введите y2");
double y2 = double.Parse(Console.ReadLine());

sum = Math.Sqrt(Math.Pow(x - x2, 2) + Math.Pow(y - y2, 2));
System.Console.WriteLine("Расстояние между 2-мя точками =" + sum);
