using System;

string checkSign (int sign)
    {
        if (sign == 1)
    {
        return "+";
    }

    if (sign == 2)
    {
        return "-";
    }

    if (sign == 3)
    {
        return "*";
    }

    if (sign == 4)
    {
        return "/";
    }
    return "0";
    }
int displayValues(int a,int b,int c)
{
    string sign = checkSign(c);
    Console.Write(a + " " + sign + " " + b + " = ");
    return 0;
}
int addition(int a, int b)
{
    return a + b;
};
int subtraction(int a, int b)
{
    return a - b;
};
int multiplication(int a, int b)
{
    return a * b;
}

double division(double a, double b)
{
    return a / b;
}

int exponentiation(int a, int b)
{
    int c = a;
    for (int i = 0; i <= b-2; i++)
    {
        c = c * a;
    }
    return c;
  
}

int factorial(int a)
{
    int c = 1;
    for(int i = 1; i < a+1; i++)
    {
        c = c * i;
    }
    return c;   
}
int clearConsole()
{
    Console.WriteLine("Press any button");
    Console.ReadKey();
    Console.Clear();
    return 0;
}
int startValue = 1;
int valueOne, valueTwo;
Console.WriteLine("Hello, Calculator!");
do
{
    startValue = 1;
    Console.WriteLine("Choose the option and press enter");
    Console.WriteLine("1.Addition, 2.subtraction, 3.multiplication, 4.division, 5.exponentiation, 6.factorial 7. close the program");
    startValue = Convert.ToInt32(Console.ReadLine());
    if (startValue == 6)
    {
        Console.Write("enter value: ");
        valueOne = Convert.ToInt32(Console.ReadLine());
        valueTwo = 0;
    }
    else if (startValue == 7)
    {
        valueOne = 0;
        valueTwo = 0;
        Environment.Exit(0);
    }
    else
    {
        Console.Write("enter first value: ");
        valueOne = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter second value: ");
        valueTwo = Convert.ToInt32(Console.ReadLine());
    }
 
    Console.Write("result: ");
    switch (startValue)
    {
        case 1:
            displayValues(valueOne, valueTwo, startValue);
            Console.WriteLine(addition(valueOne, valueTwo));
            break;
        case 2:
            displayValues(valueOne, valueTwo, startValue);
            Console.WriteLine(subtraction(valueOne, valueTwo));
            break;
        case 3:
            displayValues(valueOne, valueTwo, startValue);
            Console.WriteLine(multiplication(valueOne, valueTwo));
            break;
        case 4:
            displayValues(valueOne, valueTwo, startValue);
            Console.WriteLine(division(valueOne, valueTwo));
            break;
        case 5:
            Console.WriteLine(exponentiation(valueOne, valueTwo));
            break;
        case 6:
            Console.WriteLine(factorial(valueOne));
            break;
        default:
            Console.WriteLine("wrong value, try again");
            break;
    }
    clearConsole();
    
} while (startValue != 7);