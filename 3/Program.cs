using static System.Console;
Clear();

WriteLine("Enter the 'N' number ");
int n = int.Parse(ReadLine());
for (int i = 1; i <= n; i++)
{
    Write($"{i * i * i} ");
}