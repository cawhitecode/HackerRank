// github.com/cawhitecode

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        //if pm return base + 12 hours
        if (s.Contains("12:") && s.Contains("AM"))
        {
            string hours = s.Remove(2);
            int intMilitaryHours = int.Parse(hours) - 12;
            string sMilitaryHours = intMilitaryHours.ToString();
            string militaryHours = sMilitaryHours + s.Remove(0,2).Remove(6);
            return "0" + militaryHours;

        }
        else if (s.Contains("12:") && s.Contains("PM"))
        {
            string amMilitaryTime= s.Remove(8); 
            return amMilitaryTime;
        }   
        else if (s.Contains("PM"))
        {
            string hours = s.Remove(2);
            int intMilitaryHours = int.Parse(hours) + 12;
            string sMilitaryHours = intMilitaryHours.ToString();
            string militaryHours = sMilitaryHours + s.Remove(0,2).Remove(6);
            return militaryHours;
                        
        }
        //if AM return base
        else if (s.Contains("AM"))
        {
            string amMilitaryTime= s.Remove(8); 
            return amMilitaryTime;
        }
        else {
            return s;
        }  
        
    }