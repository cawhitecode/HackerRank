// github.com/cawhitecode
   
    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar){
        int pairs = 0;
        var sockColor = new Dictionary<int, int>();

        foreach(int sock in ar)
        {
            if (sockColor.ContainsKey(sock))
            {
                pairs++;
                sockColor.Remove(sock);
            }
            else
                sockColor.Add(sock, 1);
        }
        return pairs;
    }