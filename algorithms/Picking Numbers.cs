// github.com/cawhitecode


class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {  
        int length = a.Count();
        var sortedList = a.OrderBy(x => x).ToList();
        int maxCount = 0;
        for(int i = 0; i < length; i++)
        {
                var currentCount = 1;
                if (i > 0)
                    if (sortedList[i] == sortedList[i-1])
                        continue;

                for (int j = i+1; j < sortedList.Count; j++)
                {
                    if (Math.Abs(sortedList[j]-sortedList[i]) <=1)
                        currentCount++;
                    else
                        break;
                }

                if (currentCount > maxCount)
                    maxCount = currentCount;           
            

        }
        return maxCount;
          
    }  

}