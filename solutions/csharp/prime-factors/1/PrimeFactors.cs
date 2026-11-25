public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> factors = new List<long>();
        long divisor = 2;

        while (number > 1)
        {
            if (number % divisor == 0)
            {
                factors.Add(divisor);
                number /= divisor;
            }
            else if (divisor > number / divisor)
            {
                factors.Add(number);
                break;
            }
            else divisor++;
        }
        return factors.ToArray();
    }
}