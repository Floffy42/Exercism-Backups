public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span)
    {
        if (span < 0 || span > digits.Length) throw new ArgumentException();

        if (span == 0) return 1;

        long maxProduct = 0;

        for (int i = 0; i <= digits.Length - span; i++)
        {
            double product = 1;

            for (int j = 0; j < span; j++)
            {
                char digit = digits[i + j];
                if (!char.IsDigit(digit)) throw new ArgumentException();
                product *= char.GetNumericValue(digit);
            }
            if (product > maxProduct) maxProduct = (long)product;
        }
        return maxProduct;
    }
}