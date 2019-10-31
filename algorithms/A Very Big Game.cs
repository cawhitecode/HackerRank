// github.com/cawhitecode

class Solution {

    // Complete the aVeryBigSum function below.
    static long aVeryBigSum(long[] ar) {
        long sum = 0;
        
        int length = ar.Count();


        for (int number = 0; number < length; number++)
        {
            sum = sum + ar[number];
        }
        return sum;


    }
