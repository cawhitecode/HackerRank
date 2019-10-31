// github.com/cawhitecode

class Solution {

    // Complete the kangaroo function below.
    static string kangaroo(int x1, int v1, int x2, int v2) {
        if (v2 >= v1)
        {
            return "NO";
        }
        else 
        {
            if ((x2 - x1) % (v1 - v2) == 0)
            {
                return "YES";                
            }
            else
            {
                return "NO";
            }
        }

    }