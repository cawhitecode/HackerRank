// github.com/cawhitecode

// https://www.hackerrank.com/challenges/utopian-tree/problem

    static int utopianTree(int n) {
        
            int i = 1;
            int height = 1;
            while (i <= n) {
                if (i % 2 == 0) {
                    height+=1;
                }
                else {
                    height *= 2;
                }
                i++;
            }
            return height;


    }