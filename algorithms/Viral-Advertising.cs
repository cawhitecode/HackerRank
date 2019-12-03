// github.com/cawhitecode

// https://www.hackerrank.com/challenges/strange-advertising/problem
   
    static int viralAdvertising(int n) {
        int adsShared = 5;
        int adsLiked = 0;
        for(int x = 0; x < n; x++){
             adsLiked += adsShared / 2;
             adsShared = (adsShared /2) * 3;
        }
        return adsLiked;

    }