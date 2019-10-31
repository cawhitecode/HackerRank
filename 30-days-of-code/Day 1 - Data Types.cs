// github.com/cawhitecode

        
        // Declare second integer, double, and String variables.
        int j;
        double e;
        string newString = "";
        
        
        // Read and save an integer, double, and String to your variables.
        j  = Convert.ToInt32(Console.ReadLine());
        e = Convert.ToDouble(Console.ReadLine());
        newString = Console.ReadLine();

        // Print the sum of both integer variables on a new line.
        Console.WriteLine(j + i);
                
        // Print the sum of the double variables on a new line.
        Console.WriteLine("{0:F1}", e + d);        
        // Concatenate and print the String variables on a new line
        Console.WriteLine(s + newString);
        // The 's' variable above should be printed first.