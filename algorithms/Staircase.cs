// github.com/cawhitecode

// New solution 12/2/2019
// Time complexity: O(n) there is only for loop
    static void staircase(int n) {
        
        for (int i = 1; i <= n; i++){
            var pounds = new String(' ', n - i);
            var spaces = new String('#', i);           
            System.Console.WriteLine(pounds + spaces);
        }


    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        staircase(n);
    }


// Old Solution
// Time complexity: O(n^2) there are two for loops

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