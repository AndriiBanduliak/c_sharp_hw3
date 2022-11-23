using static System.Console;
Clear();

WriteLine("Enter the number");
string digit = ReadLine();
int diffDigitCounter = 0;
for (int i = 0; i < digit.Length; i++)
{
    if (digit[i] == digit[digit.Length - i - 1]) diffDigitCounter++;
}
if (diffDigitCounter == digit.Length) WriteLine("This number is a palindrome");
else WriteLine($"This number is not a palindrome");