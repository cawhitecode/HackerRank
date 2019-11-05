// github.com/cawhitecode

    // Complete the rotLeft function below.
    static int[] rotLeft(int[] a, int d) {
        //Add Array to Stack
        Queue<int> queue = new Queue<int>(a);
        Stack<int> stack = new Stack<int>();
        
        // while loop for number of elements in array = d
        while(d > 0)
        {
            stack.Push(queue.Dequeue());
            queue.Enqueue(stack.Pop());
            d--;            
        }

    return queue.ToArray();


    }