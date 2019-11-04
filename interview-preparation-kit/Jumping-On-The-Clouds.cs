// github.com/cawhitecode

// Complete the jumpingOnClouds function below.
    static int jumpingOnClouds(int[] c) {
        int jumps = -1;
         
        for(int x = 0; x < c.Length ; jumps++){
            if (x + 1 < c.Length - 1 && c[x+2] != 1){
                x+= 2;                                
            }
            else if (c[x] == 0){
                x++;                
            }
            
        }
        return jumps;

    }