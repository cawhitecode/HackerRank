// github.com/cawhitecode

class Result
{
    public static List<int> gradingStudents(List<int> grades)
    {
        int length = grades.Count();
        List<int> finalGrades = new List<int>();
        for (int x = 0; x < length; x++)
        {   
            int grade = grades[x];        
            if ( grade < 38)
            {
                finalGrades.Add(grade);
            }
            else
            {
                int roundedGrade = 5* (int)Math.Round(grade / 5.0);
                if (roundedGrade - grade <= 2 && roundedGrade - grade >= 0)
                {
                    finalGrades.Add(roundedGrade);
                }
                else 
                {
                    finalGrades.Add(grade);
                }
            }
        }
        return finalGrades;
        
    }

}