public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int a, int b, int c)> result = new List<(int, int, int)>();

        for (int a = 1; a < sum / 3; a++)
        {
            for (int b = a + 1; b < sum; b++)
            {
                int c = sum - a - b;

                if (b >= c) break;

                long aSquared = (long)a * a;
                long bSquared = (long)b * b;
                long cSquared = (long)c * c;

                if (aSquared + bSquared == cSquared) result.Add((a, b, c));
            }
        }
        return result;
    }
}