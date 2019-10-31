// github.com/cawhitecode

class Solution {

    // Complete the countApplesAndOranges function below.
    static void countApplesAndOranges(int s, int t, int a, int b, int[] apples, int[] oranges) {
        int appleInsideCount = 0;
        int orangeInsideCount = 0;

        // a = apple tree
        // Apples in between s and t
        foreach(int apple in apples)
        {
            if ((apple + a >= s) && (apple + a <= t))
            {
                appleInsideCount++;
            }
        }

        // b = orange tree
        // oranges in between s and t
        foreach(int orange in oranges)
        {
            if ((orange + b <= t) && (orange + b >= s))
            {
                orangeInsideCount++;
            }
        }
        Console.WriteLine(appleInsideCount);
        Console.WriteLine(orangeInsideCount);

    }