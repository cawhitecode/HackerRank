// github.com/cawhitecode

class Solution {

    // Complete the staircase function below.
    static void staircase(int n) {
        
        for (int x = 0; x < n; x++)
        {
            for(int j = 1; j <= n; j++)
            {
                if ((x + j) >= n) {
                    Console.Write("#");
                }
                else {
                    Console.Write(" ");
                }                
            }
            Console.WriteLine();            
        }      
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }
}