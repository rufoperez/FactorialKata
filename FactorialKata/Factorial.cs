namespace FactorialKata;

public class Factorial
{
    public static int GetFactorial(int value)
    {
        int result = 1;
        for (int i = value; i >= 1; i--)
        {
            result *= i;
        }

        return result;
    }
}