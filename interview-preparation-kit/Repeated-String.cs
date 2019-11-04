// github.com/cawhitecode

static long repeatedString(string s, long n) {
       
        int numberOfAs = s.Count( c => c == 'a');
        if (numberOfAs == 0){
            return 0;
        }
        int length = s.Length;
        long repeats = n / length;
        var fullRepeat = repeats * numberOfAs;
        var remainder = (int) (n % length);

        if (numberOfAs == 0){
            return 0;
        }
        else if (remainder == 0){
            return fullRepeat;
        }
        else {
            var lastRepeat = s.Substring(0, remainder);
            long numberOfAsLast = lastRepeat.Count(c => c == 'a');
            return fullRepeat + numberOfAsLast;
        }
    }