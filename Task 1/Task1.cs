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


//Not sure what you where asking for here so I also created my own function that does the same thing.
public class numberFunctions
{
    public static int GetDoublePositiveEven(List<object> num)
    {
        //check if the input is a number
        if (!(num is int num))
        {
            throw new ArgumentException("Input must be a number.");
        }
        //Check if the number is positive
        else if (!(num > 0))
        {
            throw new ArgumentException("Number must be positive.");
        }
        else //If both checks pass, we can continue with the function
        {continue}
        // Check if the number is positive and even
        if (num > 0 && num % 2 == 0)
        {
            return num * 2; // Return the doubled value
        }
        else
        {
            throw new ArgumentException("Number must be positive and even.");
        }
    }
}