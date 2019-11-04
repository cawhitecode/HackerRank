   // github.com/cawhitecode
   
    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        int level = 0;
        int valleys = 0;
        bool inValley = false;
        for(int x = 0; x < s.Length; x++){            
            if (s[x] == 'U' ){
                level++;
            }
            else if (s[x] == 'D' ){
                level--;
            }
            if (!inValley && level < 0) {
                inValley = true;
            }
            if (inValley && level == 0){
                valleys++;
                inValley = false;
            }
        }
        return valleys;

    }