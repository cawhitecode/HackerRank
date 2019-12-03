// github.com/cawhitecode

// https://www.hackerrank.com/challenges/beautiful-days-at-the-movies/problem

    static int beautifulDays(int i, int j, int k) {
        int x = i - j;
        int beautifulDays = 0;
        while ( i <= j ){
            int reverse = Reverse(i);  
            int rNumber = Math.Abs(i - reverse);
            var numberCheck = rNumber % k;
            if (numberCheck == 0){
                beautifulDays++;
                i++;
            }
            else {
                i++;
            }
        }
        return beautifulDays;


    }

    private static int Reverse(int n){
        int left = n;
        int rev = 0;
        while(left>0)
        {
        int r = left % 10;   
        rev = rev * 10 + r;
        left = left / 10; 
        }
        return rev;
    }