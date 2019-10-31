// github.com/cawhitecode

class Solution {

    // Complete the compareTriplets function below.
    static List<int> compareTriplets(List<int> a, List<int> b) {
        
        var scoreA = 0;
        var scoreB = 0;
        var length = a.Count();
                
        for(int score = 0; score < length; score++)
        {
                if (a[score] > b[score])
            {
                scoreA++;
            }
            else if (a[score] < b[score])
            {
                scoreB++;
            }
            
        }

        List<int> scores = new List<int>();
        scores.Add(scoreA);
        scores.Add(scoreB);
        return scores;
            
            

    }