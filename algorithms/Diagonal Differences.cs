// github.com/cawhitecode

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int d1 = 0, d2 = 0;
        int n = arr.Count();
        Console.WriteLine(n);
      
        for (int i = 0; i < n; i++) 
        { 
            for (int j = 0; j < n; j++) 
            { 
                  
                // finding sum of primary diagonal 
                if (i == j)
                {
                    d1 += arr[i][j];
                }
                     
      
                // finding sum of secondary diagonal 
                if (i == (n - j - 1))
                {
                    d2 += arr[i][j];
                }                      
            } 
        } 
      
        // Absolute difference of the 
        // sums across the diagonals 
        return Math.Abs(d1 - d2); 
    }

}