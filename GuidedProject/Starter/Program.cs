using System;
using System.Data;
using System.Data.Common;
using System.Net.Mail;
using System.Runtime.Serialization;

// initialize variables - graded assignments 
int examAssignments = 5;
string currentLetterGrade = "";

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 ,96};
int[] studentScores = new int[10];

string[] strudentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

foreach (string names in strudentNames)
{
    string currentName = names;

    if (currentName == "Sophia")

        studentScores = sophiaScores;

    else if (currentName == "Andrew")

        studentScores = andrewScores;

    else if (currentName == "Emma")

        studentScores = emmaScores;

    else if (currentName == "Logan")

        studentScores = loganScores;

    int sumAssignmentScore = 0;
    int gradeAssignment = 0 ;
    decimal currentStudentGrade = 0;


    foreach (int score in studentScores)
    {
      
        gradeAssignment += 1;

        if( gradeAssignment <= examAssignments)
        {
             sumAssignmentScore += score; 
        } else 
        {
            sumAssignmentScore += score / 10 ;
        }
            

    }
    currentStudentGrade = (decimal)(sumAssignmentScore) / examAssignments;
    if (currentStudentGrade >= 97)
        currentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentLetterGrade = "A-";
    
    else if (currentStudentGrade >= 87)
        currentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentLetterGrade = "B+";
    
    else if (currentStudentGrade >= 80)
        currentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentLetterGrade = "C+";
    
    else if (currentStudentGrade >= 73)
        currentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentLetterGrade = "D+";
    
    else if (currentStudentGrade >= 65 )
        currentLetterGrade = "D-";

    else 
        currentLetterGrade = "F";
    


    Console.WriteLine("Student\t\tGrade\n");
    Console.WriteLine($"{currentName}\t\t{currentStudentGrade}\t{currentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
