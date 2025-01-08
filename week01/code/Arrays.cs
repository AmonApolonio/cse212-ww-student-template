public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // I'm going to create an array called 'multiples' with the size 'length'
        // I'll use a for loop to go from 0 to 'length - 1'
        // Inside the loop, I'll calculate the multiple by multiplying 'number' with (i + 1)
        // Then, I'll assign that multiple to the current index of the 'multiples' array
        // Finally, after the loop ends, I'll return the 'multiples' array

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // First, I will calculate the actual rotation needed by taking the modulus of the amount with the count of the list
        // Then, I will get the last 'amount' elements from the list using GetRange
        // After that, I will remove those elements from the end of the list using RemoveRange
        // Finally, I will insert the removed elements at the start of the list using InsertRange
        
        amount = amount % data.Count;
        List<int> endPart = data.GetRange(data.Count - amount, amount);
        data.RemoveRange(data.Count - amount, amount);
        data.InsertRange(0, endPart);
    }
}
