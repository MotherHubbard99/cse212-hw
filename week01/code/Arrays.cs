using System.Runtime.Serialization;

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
        // number is the number we need to start with and how much we need to increment each time
        // length is the amount of numbers that need to be printed
        //create an array that will hold doubles
        double[] multiples = new double[length];
        //start at zero and add one to the counter each time
        for (int i = 0; i < length; i++)
        {
            //arrayholder(index) = the number * the counter plus 1, to increment each time
            //example 3*1, 3*2, 3*3
            multiples[i] = number * (i + 1);
        }
        //return the array that was created
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
        //slice the list in 2 parts
        //start the list with the 'amount' sent through to the end of the list
        List<int> endSlice = data.GetRange(data.Count - amount, amount);
        //now find the other list items starting with zero and stop when the 'amount' is hit
        List<int> startSlice = data.GetRange(0, data.Count - amount);
        //Clear out the original list
        data.Clear();
        data.AddRange(endSlice);
        data.AddRange(startSlice);

    }
}
