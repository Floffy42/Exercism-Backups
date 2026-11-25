public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        List<IEnumerable<int>> result = new List<IEnumerable<int>>();
        List<int> previousRow = new List<int>();

        for (int i = 0; i < rows; i++)
        {
            List<int> currentRow = new List<int>();

            for (int j = 0; j <= i; j++)
            {
                if (j == 0 || j == i) currentRow.Add(1);
                else
                {
                    int value = previousRow[j - 1] + previousRow[j];
                    currentRow.Add(value);
                }
            }

            result.Add(currentRow);

            previousRow = currentRow;
        }
        return result;
    }
}