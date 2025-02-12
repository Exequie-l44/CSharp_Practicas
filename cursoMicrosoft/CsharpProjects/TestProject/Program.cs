using System.Runtime.CompilerServices;

Random random = new Random();

string [] orderIDs = new string[5];
//loop through each blank order 
System.Console.WriteLine(orderIDs.Length);
for (int i=0 ; i < orderIDs.Length; i++)
{
    System.Console.WriteLine(i);
    //get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    //convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    //create the random number, pad with zeroes 
    string suffix = random.Next(1, 1000).ToString();
    //combine the prefix and suffix togothe, then assing to current orderIDs
    
    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    System.Console.WriteLine(orderID);
}