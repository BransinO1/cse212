public static class ArraysTester {
    /// <summary>
    /// Entry point for the tests
    /// </summary>
    public static void Run() {
        // Sample Test Cases (may not be comprehensive)
        Console.WriteLine("\n=========== PROBLEM 1 TESTS ===========");
        double[] multiples = MultiplesOf(7, 5);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{7, 14, 21, 28, 35}
        multiples = MultiplesOf(1.5, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{1.5, 3.0, 4.5, 6.0, 7.5, 9.0, 10.5, 12.0, 13.5, 15.0}
        multiples = MultiplesOf(-2, 10);
        Console.WriteLine($"<double>{{{string.Join(',', multiples)}}}"); // <double>{-2, -4, -6, -8, -10, -12, -14, -16, -18, -20}

        Console.WriteLine("\n=========== PROBLEM 2 TESTS ===========");
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 1);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{9, 1, 2, 3, 4, 5, 6, 7, 8}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 5);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 3);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}
        numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        RotateListRight(numbers, 9);
        Console.WriteLine($"<List>{{{string.Join(',', numbers)}}}"); // <List>{1, 2, 3, 4, 5, 6, 7, 8, 9}
    }
            // Plan for: MultiplesOf
                // Requirements for part 1: 
                    // Come up with a plan on how to implement the MultiplesOf function. The function should create and return a list of multiples of a number.
                    // The starting number and the number of multiples are provided as inputs to the function. 
                    // For example, MultiplesOf(3,5), where the 3 is the starting number and 5 is the number of multiples, would result in <double>{3, 6, 9, 12, 15}.

            // My steps (1-5):

            // 1. Define the function signature:
            //    - private static double[] MultiplesOf(double number, int length)

            // 2. Handle edge cases:
            //    - If length is less than or equal to 0, return an empty array.

            // 3. Initialize an array to store the multiples.

            // 4. Use a loop to calculate the multiples:
            //    - Start with the initial number.
            //    - For each multiple, multiply the number by its position in the loop.
            //    - Store the result in the array.

            // 5. Return the array of multiples.
    private static double[] MultiplesOf(double number, int length)
    {
        // Handle edge case: return empty array
        if (length <= 0)
        {
            return new double[0];
        }

        // Initialize an array to store the multiples
        double[] multiples = new double[length];

        // Use a loop to calculate the multiples
        for (int i = 0; i < length; i++)
        {
            // Calculate the multiple and store it in the array
            multiples[i] = number * (i + 1);
        }

        // Return the array of multiples
        return multiples;
    }
    
            // Plan to: RotateRight
                // Requirements for part 1: 
                    // Come up with a plan on how to implement the RotateListRight function. This function receives a list of data and an amount to rotate to the right.
                    // For example, if the data is <List>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 5 then the list returned should be <List>{5, 6, 7, 8, 9, 1, 2, 3, 4}. 
                    // If the data is <List>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list returned should be <List>{7, 8, 9, 1, 2, 3, 4, 5, 6}. 
                    // The value of amount will be in the range of 1 and data.Count.

            // My steps (1-5):
            // 1. Define the function signature:
            //    - private static void RotateListRight(List<int> data, int amount)

            // 2. Check input validity:
            //    - If amount is less than 1 or greater than or equal to data.Count, return without making any changes.

            // 3. Handle special cases:
            //    - If amount is equal to 1 or data.Count - 1, return without making any changes.

            // 4. Perform rotation:
            //    - Split the list into two parts:
            //        - The first part consists of the last 'amount' elements.
            //        - The second part consists of the remaining elements.
            //    - Concatenate the second part with the first part to create the rotated list.

            // 5. Modify the original list with the rotated list.

    private static void RotateListRight(List<int> data, int amount)
    {
        // Check input validity
        if (amount < 1 || amount >= data.Count)
        {
            // If amount is out of range, return without making any changes
            return;
        }

        // Handle special cases: no rotation needed
        if (amount == 1 || amount == data.Count - 1)
        {
            // No rotation needed, return without making any changes
            return;
        }

        // Perform rotation
        List<int> rotatedList = new List<int>();
        rotatedList.AddRange(data.GetRange(data.Count - amount, amount)); // First part
        rotatedList.AddRange(data.GetRange(0, data.Count - amount));      // Second part

        // Modify the original list with the rotated list
        for (int i = 0; i < data.Count; i++)
        {
            data[i] = rotatedList[i];
        }
    }
}