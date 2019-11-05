
// github.com/cawhitecode

class Solution {



    static void Main(string[] args) {
        string[] nd = Console.ReadLine().Split(' ');

        int n = Convert.ToInt32(nd[0]);

        int d = Convert.ToInt32(nd[1]);

        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), aTemp => Convert.ToInt32(aTemp));

        Queue<int> queue = new Queue<int>(a);
        Stack<int> stack = new Stack<int>();
        
        // Loop for number of elements in array = d
        while(d > 0)
        {
            stack.Push(queue.Dequeue());
            queue.Enqueue(stack.Pop());
            d--;            
        }
        queue.ToArray();
        
        foreach(int number in queue){
            Console.Write(number.ToString()+ " ");
        }
        ;
    }
}