//This code is used to count how many character the massage has 

string massage = "The quick brown fox jumps over the Lay dog";
char[] charMassage = massage.ToCharArray();
int x = 0;

Array.Reverse(charMassage);

foreach(char i in charMassage)
{
    if(i == 'o')
    {
        x++;
    }
}

string new_massge = new string(charMassage);

System.Console.WriteLine($"{new_massge} \n 'o' appears {x} times.");