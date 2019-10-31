// github.com/cawhitecode

class Solution {

    // Complete the plusMinus function below.
    static void plusMinus(int[] arr) {
        int positiveNumbers = 0;
        int negativeNumbers = 0;
        int zeros = 0;
        int count = 0;
        float positives, negatives, zerosAnswer;

        foreach(int number in arr){
            count++;           
            if (number > 0)
            {
                positiveNumbers++;                
            }
            else if (number < 0)
            {
                negativeNumbers++;                
            }
            else
            {
                zeros++;                
            }
        }
        positives = (float)positiveNumbers/count;
        negatives = (float)negativeNumbers/count;
        zerosAnswer = (float)zeros/count;

        Console.WriteLine(positives);
        Console.WriteLine(negatives);
        Console.WriteLine(zerosAnswer);        
    }

    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        plusMinus(arr);
    }
}