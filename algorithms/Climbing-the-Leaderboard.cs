 // github.com/cawhitecode
 
 class Solution {
    // Complete the climbingLeaderboard function below.
    static int[] climbingLeaderboard(int[] scores, int[] alice) {
        int[] aliceRank = {};
        var distinctScores = scores.Distinct().ToArray();
        Array.Reverse(alice);
        foreach(int score in alice)
        {
            // Add score to array            
            var combinedScores = distinctScores.Concat(new int[] {score}).ToArray();
            

            // Get distinct list on leaderboard
            var distinctCombinedScore = combinedScores.Distinct().ToArray();
            Array.Sort(distinctCombinedScore);
            Array.Reverse(distinctCombinedScore);           

            // Add Rank of score to aliceRank
            var rankIndex = Array.IndexOf(distinctCombinedScore,  score);
            var rank = rankIndex + 1;           
            aliceRank = aliceRank.Concat(new int[] {rank}).ToArray();
            
            //clear arrays for scores            
            Array.Clear(combinedScores, 0, combinedScores.Length);
            Array.Clear(distinctCombinedScore, 0, distinctCombinedScore.Length);
            
            
        }
        Array.Reverse(aliceRank);
        return aliceRank;        
    }