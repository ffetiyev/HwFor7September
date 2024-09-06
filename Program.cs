

using HwFor7September.Exceptions;
using HwFor7September.Helpers.Constants;

static int Factorial(int a)
{  
    int fact = 1;
	try
	{
        if (a < 0)
        {
             throw new CustomFactorialException(ExceptionMessages.FactorialException);
        }

        for (int i = 1; i <= a; i++)
        {
            fact = fact * i;
        }

    }
	catch (Exception ex)
	{
        Console.WriteLine(ex.Message);
	}
    return fact;
}


Console.WriteLine(Factorial(-5));