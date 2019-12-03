// github.com/cawhitecode

// https://www.hackerrank.com/challenges/designer-pdf-viewer/problem
    
    static int designerPdfViewer(int[] h, string word) {
        int length = word.Length;
        int maxHeight = 0;
        var heights = new Dictionary<char, int>();
        var alphabet = 'a';
        
        foreach( var height in h){
            heights.Add(alphabet++, height);
        }
        foreach (var letter in word)
            {
                if (heights[letter] > maxHeight)
                {
                    maxHeight = heights[letter];
                }
            }

        
        return maxHeight * length;
    }