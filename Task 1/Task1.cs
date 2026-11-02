public class firstTask
{
    public static List<int> GetDoubledPositiveEvens(List<object> numList)
    {
        List<int> finalList = new List<int>();

        // Go through each number in the list
        foreach (var item in numList)
        {
            // Error handling: Check if item is a number
            if (!(item is int num))
            {
                // Skip non-integer values
                continue;
            }

            // Check if the number is positive and even
            if (num > 0 && num % 2 == 0)
            {
                int doubledNum = num * 2; 

                // Double the number
                finalList.Add(doubledNum); 

                // Add it to the final list
            }
        }

        // Return the list of doubled positive even numbers
        return finalList;
    }
}