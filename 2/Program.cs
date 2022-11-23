using static System.Console;
Clear();

WriteLine("Enter coordinate X1");
int x1 = int.Parse(ReadLine());
WriteLine("Enter coordinate Y1");
int y1 = int.Parse(ReadLine());
WriteLine("Enter coordinate Z1");
int z1 = int.Parse(ReadLine());
WriteLine("Enter coordinate X2");
int x2 = int.Parse(ReadLine());
WriteLine("Enter coordinate Y2");
int y2 = int.Parse(ReadLine());
WriteLine("Enter coordinate Z2");
int z2 = int.Parse(ReadLine());

double c = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));
WriteLine($"The distance between these points is: {c}");