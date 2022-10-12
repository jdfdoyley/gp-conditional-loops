/*******************************************************************************
 * Name: Jason D. F. D'Oyley
 * Date: Oct. 12, 2022
 * Assignment CIS214 Week 2 GP - Conditional Loops
 *
 * Main application (program) class.
 * In this application we will demonstrate the use of condition-based
 * loops by asking the user for input and continuing to ask for input
 * until the user indicates that they want to quit. Upon quitting, the
 * program will display the number of passing and failing grades
 * entered.
 */
public class GradeCounts
{
    static void Main(string[] args)
    {
        // Print a header line
        Console.WriteLine("\nJason D'Oyley - Week 2 GP Conditional Loops\n");

        // Get integer values from the user until the user enters -1
        Console.WriteLine("Looping using a while loop: ");
        Console.Write("Enter a grade between 0 and 100 (-1 to stop): ");
        string? val = Console.ReadLine();
        int inVal = Convert.ToInt32(val);
        int passCount = 0;
        int failCount = 0;

        // loop as long as the input value is not -1; note that if the first
        // value entered by the user is -1, the loop will never execute
        while (inVal != -1)
        {
            if (inVal >= 60)
            {
                // use shorthand to add to the count; this is the same as
                // passCount = passCount + 1;
                passCount += 1;
            }
            else
            {
                failCount += 1;
            }

            Console.Write("Enter a grade between 0 and 100 (-1 to stop): ");
            val = Console.ReadLine();
            inVal = Convert.ToInt32(val);
        }

        // Print the pass and fail counts and a header for the do-wile loop
        Console.WriteLine("Count of passing grades: {0}", passCount);
        Console.WriteLine("Count of failing grades: {0}\n", failCount);
        Console.WriteLine("Looping using a do-while loop:");
        passCount = 0;
        failCount = 0;

        // loop as long as the input value is not -1; note that if the first
        // value entered by the user is -1, the loop will still execute one
        // so to make sure we don't include the loop controller in the count
        // we account for it in the else-if statement
        do
        {
            Console.Write("Enter a grade between 0 and 100 (-1 to stop): ");
            val = Console.ReadLine();
            inVal = Convert.ToInt32(val);

            if (inVal >= 60)
            {
                // use shorthad to add to the count; this is the same as
                // passCount = passCound + 1;
                passCount += 1;
            }
            else if (inVal != -1)
            {
                failCount += 1;
            }
        } while (inVal != -1);

        // Print the pass and fail counts
        Console.WriteLine("Count of passing grades: {0}", passCount);
        Console.WriteLine("Count of failing grades: {0}", failCount);
    }
}

