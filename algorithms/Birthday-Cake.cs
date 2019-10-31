// github.com/cawhitecode

class Solution {

    // Complete the birthdayCakeCandles function below.
    static int birthdayCakeCandles(int[] ar) {
        // max hight candle count      
        int count = 0;
        int maxCandleHeight = ar.Max();
        foreach(int candle in ar)
        {
            if ( candle == maxCandleHeight)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        return count;
    }

}