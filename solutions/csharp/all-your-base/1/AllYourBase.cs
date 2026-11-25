public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        if(inputBase < 2 || outputBase < 2) throw new ArgumentException();
        if(inputDigits.Length == 0) return new int[] { 0 };
        long number = 0;

        foreach(int digit in inputDigits)
        {
            if(digit < 0 || digit >= inputBase) throw new ArgumentException();
            number = number * inputBase + digit;
        }

        if(number == 0) return new int[] { 0 };

        List<int> result = new List<int>();

        while(number > 0)
        {
            int remainder = (int)(number % outputBase);
            result.Add(remainder);
            number /= outputBase;
        }
        result.Reverse();
        return result.ToArray();
    }
}