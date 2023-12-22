Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
Console.WriteLine("Введите систему исчисления: ");
int p = int.Parse(Console.ReadLine());

int result = ConvertToDecimal(number, p);
Console.WriteLine(result);


int ConvertToDecimal(string number, int p)
{
    int decimalNumber = 0;
    int position = 0;

    for (int i = number.Length - 1; i >= 0; i--)
    {
        int digit = int.Parse(number[i].ToString());
        decimalNumber += digit * (int)Math.Pow(p, position);
        position++;
    }
    return decimalNumber;
}

