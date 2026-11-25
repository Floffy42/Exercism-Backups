public static class NthPrime
{
    public static int Prime(int nth)
    {
        if (nth < 1) throw new ArgumentOutOfRangeException();

        int count = 0;
        int number = 1;

        while (count < nth)
        {
            bool isPrime = true;
            number++;
            if(number < 2) isPrime = false;
            
            for (int i = 2; i <= number / i; i++)
            {
                if (number % i == 0) isPrime = false;
            }
            if (isPrime) count++;
        }
        return number;
    }
}