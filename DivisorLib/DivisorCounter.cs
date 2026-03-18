namespace DivisorLib
{
    public static class DivisorCounter
    {
        public static int GetDivisorCount(int number)
        {
            int divisorCount = 0;

            for (int potentialDivisor = 1; potentialDivisor <= number; potentialDivisor++)
            {
                if (number % potentialDivisor == 0)
                {
                    divisorCount++;
                }
            }

            return divisorCount;
        }

        public static int CountNumbersWithEqualAdjacentDivisors(int upperLimit)
        {
            int validCount = 0;

            for (int currentNumber = 2; currentNumber < upperLimit; currentNumber++)
            {
                int currentDivisors = GetDivisorCount(currentNumber);
                int nextDivisors = GetDivisorCount(currentNumber + 1);

                if (currentDivisors == nextDivisors)
                {
                    validCount++;
                }
            }

            return validCount;
        }
    }
}