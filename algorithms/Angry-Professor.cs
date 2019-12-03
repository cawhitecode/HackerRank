    // github.com/cawhitecode

    // https://www.hackerrank.com/challenges/angry-professor/problem
    
    static string angryProfessor(int k, int[] a) {
        bool onTime = false;
        int proTrigger = k;
        int classTrigger = 0;
        foreach(int student in a){
            if (proTrigger <= classTrigger){
                onTime = true;
                break;
            }
            else if (student <= 0){
                classTrigger++;
            }
            else {
                continue;
            }
        }

        if (onTime == true){
            return "NO";
        }
        else {
            return "YES";
        }
    }
