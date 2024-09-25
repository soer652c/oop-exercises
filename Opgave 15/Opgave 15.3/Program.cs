using System;

// Definerer klassen AvgGradeError
class AvgGradeError
{
    // Deklarerer og initialiserer en int[] variabel kaldet grades
    private int[] grades = new int[] { 4, 7, 02, 00, 10, 4, 12 };

    // Offentlig egenskab for at få adgang til grades uden for klassen
    public int[] Grades
    {
        get { return grades; }
    }

    // Funktion der tager en int parameter kaldet courseid og returnerer en int
    public int GetGrade(int courseid)
    {
        // Tjekker om courseid er uden for arrayets grænser
        if (courseid < 0 || courseid >= grades.Length)
        {
            throw new ArgumentOutOfRangeException(nameof(courseid), "Course ID is out of range.");
        }

        // Udtrækker værdien fra courseid positionen af grades
        int grade = grades[courseid];

        // Hvis karakteren er bestået, returneres den, ellers kastes en exception
        if (grade >= 02) // 02 er bestået karakter
        {
            return grade;
        }
        else
        {
            throw new Exception("Grade is not passing.");
        }
    }
}

// Hovedprogrammet
class Program
{
    static void Main(string[] args)
    {
        // Initialiserer en instans af AvgGradeError
        AvgGradeError avgGradeError = new AvgGradeError();

        // Initialisering af variablerne count og sum
        int count = 0;
        int sum = 0;

        // Gennemløber alle indekser fra grades med et for-loop
        for (int courseid = 0; courseid < avgGradeError.Grades.Length; courseid++)
        {
            try
            {
                // Kalder GetGrade for hvert courseid
                int grade = avgGradeError.GetGrade(courseid);

                // Hvis kaldet ikke resulterer i en exception, inkrementeres count og sum forøges med returværdien
                count++;
                sum += grade;
            }
            catch (Exception e)
            {
                // Håndterer undtagelser ved at udskrive en fejlmeddelelse
                Console.WriteLine($"Exception for course ID {courseid}: {e.Message}");
            }
        }

        // Udregner og printer gennemsnittet af de beståede karakterer
        if (count > 0)
        {
            double average = (double)sum / count;
            Console.WriteLine($"The average grade is: {average}");
        }
        else
        {
            Console.WriteLine("No passing grades to calculate an average.");
        }
    }
}