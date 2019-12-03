// github.com/cawhitecode

// https://www.hackerrank.com/challenges/climbing-the-leaderboard/problem

    static int[] climbingLeaderboard(int[] scores, int[] alice) {
        // foreach score in alice find score and give rank
    
        var ranks = GetRanks(scores, alice);
        return ranks;
    }

    private static int[] GetRanks(int[] leaderboard, int[] person) {
        var comparer = Comparer<int>.Default;
        var reverseComparer = Comparer<int>.Create((x, y) => -comparer.Compare(x, y));
        var distinctLeaderboard = leaderboard.Distinct().OrderBy(i => i, reverseComparer).ToArray();
        return person
            .Select(i => Array.BinarySearch(distinctLeaderboard, i, reverseComparer))
            .Select(rank => (rank >= 0 ? rank : ~rank) + 1)
            .ToArray();               
    }
    
    