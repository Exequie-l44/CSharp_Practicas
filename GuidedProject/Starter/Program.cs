using System;
using System.Data;
using System.Net.Mail;

// initialize variables - graded assignments 
int currentAssignments = 5;

string[] strudentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};

int sophiaSum = 0;
int andrewSum = 0;
int emmaSum = 0;
int loganSum = 0;

decimal sophiaScore;
decimal andrewScore;
decimal emmaScore;
decimal loganScore;

foreach (string names in strudentNames)
{
    if (names == "Sophia")
    {
        int []  sophiaScores = new int [] {90, 86, 87, 98, 100};
        foreach (int sum in sophiaScores)
        {
            sophiaSum += sum;
        }
        sophiaScore = (decimal)sophiaSum / currentAssignments;
        Console.WriteLine("Student\t\tGrade\n");
        Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
    } 
    else if (names == "Andrew")
    {
        int []  andrewScores = new int [] {92, 89, 81, 96, 90};
        foreach (int sum in andrewScores)
        {
            andrewSum += sum;
        }
        andrewScore = (decimal)andrewSum / currentAssignments;
        Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
    } 
    else if (names == "Emma")
    {
        int []        emmaScores = new int [] {90,85, 87, 98, 68};
        foreach(int sum in emmaScores )
        {
            emmaSum += sum;
        }
        emmaScore = (decimal)emmaSum / currentAssignments;
        Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
    }
    else if(names == "Logan")
    {
        int []        loganScores = new int [] {90, 95, 87, 88, 96};
        foreach(int sum in loganScores)
        {
            loganSum += sum;
        }
        loganScore = (decimal)loganSum / currentAssignments;
        Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");
    }

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
